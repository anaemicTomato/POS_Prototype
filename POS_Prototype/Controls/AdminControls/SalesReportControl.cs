using Microsoft.Data.Sqlite;
using POS_Prototype.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace POS_Prototype.Controls.AdminControls
{
    public partial class SalesReportControl : UserControl
    {
        private readonly string dbPath = DBhelper.GetProjectDbPath();
        private readonly string connectionString;

        public SalesReportControl()
        {
            InitializeComponent();
            connectionString = DBhelper.GetConnectionString();

            // DateTimePicker format
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "MM/dd/yyyy";

            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "MM/dd/yyyy";

            // Hook events
            dtpFrom.ValueChanged += DtpFromTo_ValueChanged;
            dtpTo.ValueChanged += DtpFromTo_ValueChanged;

            label10.Text = "From:";
            label11.Text = "To:";
            label2.Text = "Total Sales:";
            label3.Text = "Total Discount:";
            label4.Text = "Net Sales:";
            label5.Text = "Total Cash Tendered:";
            label6.Text = "Total Change:";
            label7.Text = "Number of Transactions:";

            LoadSales();
        }

        private void DtpFromTo_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1).AddSeconds(-1); // end of day

            if (from > to)
            {
                // optional: ignore invalid ranges
                return;
            }

            LoadSales(from, to);
        }


        private void LoadSales(DateTime? from = null, DateTime? to = null)
        {
            using var con = new SqliteConnection(connectionString);
            con.Open();

            string sql = @"
        SELECT sale_id, datetime, subtotal, discount, total_amount,
               cash_tendered, change_given
        FROM sales";

            if (from.HasValue || to.HasValue)
            {
                sql += " WHERE ";
                if (from.HasValue && to.HasValue)
                {
                    sql += "date(datetime) >= date(@from) AND date(datetime) <= date(@to) ";
                }
                else if (from.HasValue)
                {
                    sql += "date(datetime) >= date(@from) ";
                }
                else if (to.HasValue)
                {
                    sql += "date(datetime) <= date(@to) ";
                }
            }

            sql += " ORDER BY datetime DESC;";

            using var cmd = new SqliteCommand(sql, con);

            if (from.HasValue)
                cmd.Parameters.AddWithValue("@from", from.Value);
            if (to.HasValue)
                cmd.Parameters.AddWithValue("@to", to.Value.Date);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            // Convert to DateTime so formatting works
            foreach (DataRow row in dt.Rows)
            {
                row["datetime"] = Convert.ToDateTime(row["datetime"]);
            }

            dgvSales.DataSource = dt;
            dgvSales.Columns["datetime"].DefaultCellStyle.Format = "MM/dd/yyyy";

            // Format columns (same as before)
            dgvSales.Columns["sale_id"].HeaderText = "Sale ID";
            dgvSales.Columns["datetime"].HeaderText = "Date & Time";
            dgvSales.Columns["subtotal"].HeaderText = "Subtotal (₱)";
            dgvSales.Columns["discount"].HeaderText = "Discount (₱)";
            dgvSales.Columns["total_amount"].HeaderText = "Total Amount (₱)";
            dgvSales.Columns["cash_tendered"].HeaderText = "Cash Given (₱)";
            dgvSales.Columns["change_given"].HeaderText = "Change Given (₱)";

            UpdateSummary(dt);

            // Load items for first sale
            if (dgvSales.Rows.Count > 0)
            {
                int firstSaleId = Convert.ToInt32(dgvSales.Rows[0].Cells["sale_id"].Value);
                LoadSaleItems(firstSaleId);
            }
            else
            {
                dgvItemSummary.DataSource = null;
            }
        }

        private void UpdateSummary(DataTable salesTable)
        {
            decimal totalSubtotal = 0, totalDiscount = 0, totalAmount = 0;
            decimal totalCash = 0, totalChange = 0;
            int transactionCount = salesTable.Rows.Count;

            foreach (DataRow row in salesTable.Rows)
            {
                totalSubtotal += Convert.ToDecimal(row["subtotal"]);
                totalDiscount += Convert.ToDecimal(row["discount"]);
                totalAmount += Convert.ToDecimal(row["total_amount"]);
                totalCash += Convert.ToDecimal(row["cash_tendered"]);
                totalChange += Convert.ToDecimal(row["change_given"]);
            }

            label2.Text = $"Total Sales: ₱ {totalAmount:N2}";
            label3.Text = $"Total Discount: ₱ {totalDiscount:N2}";
            label4.Text = $"Gross Subtotal: ₱ {totalSubtotal:N2}";
            label5.Text = $"Total Cash Tendered: ₱ {totalCash:N2}";
            label6.Text = $"Total Change: ₱ {totalChange:N2}";
            label7.Text = $"Transactions: {transactionCount}";
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1).AddSeconds(-1); // end of day

            if (from > to)
            {
                MessageBox.Show("From date cannot be after To date.");
                return;
            }

            LoadSales(from, to);

            if (dgvSales.Rows.Count == 0)
            {
                MessageBox.Show("No sales found in the selected date range.");
                return;
            }

            // Ask for PDF export
            var result = MessageBox.Show(
                "Report generated successfully.\n\nDo you want to export this report as a PDF?",
                "Export to PDF",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ExportReportToPdf(from.Date, to.Date);
            }
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int saleId = Convert.ToInt32(
                dgvSales.Rows[e.RowIndex].Cells["sale_id"].Value);

            LoadSaleItems(saleId);
        }

        private void LoadSaleItems(int saleId)
        {
            using var con = new SqliteConnection(connectionString);
            con.Open();

            using var cmd = new SqliteCommand(
                @"SELECT 
              si.product_id,
              p.Name AS Product,
              si.quantity,
              si.price,
              si.subtotal
              FROM sale_items si
              JOIN Products p ON p.Id = si.product_id
              WHERE si.sale_id = @saleId;", con);

            cmd.Parameters.AddWithValue("@saleId", saleId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvItemSummary.DataSource = dt;

            dgvItemSummary.Columns["product_id"].HeaderText = "Product ID";
            dgvItemSummary.Columns["Product"].HeaderText = "Product Name";
            dgvItemSummary.Columns["quantity"].HeaderText = "Quantity";
            dgvItemSummary.Columns["price"].HeaderText = "Price (₱)";
            dgvItemSummary.Columns["subtotal"].HeaderText = "Subtotal (₱)";
        }

        private DataTable LoadAllItemsInRange(DateTime from, DateTime to)
        {
            using var con = new SqliteConnection(connectionString);
            con.Open();

            using var cmd = new SqliteCommand(@"
            SELECT 
                p.Id AS product_id,
                p.Name AS Product,
                SUM(si.quantity) AS total_quantity,
                si.price,
                SUM(si.subtotal) AS total_sales
            FROM sale_items si
            JOIN sales s ON s.sale_id = si.sale_id
            JOIN Products p ON p.Id = si.product_id
            WHERE s.datetime BETWEEN @from AND @to
            GROUP BY si.product_id, si.price
            ORDER BY total_quantity DESC;
        ", con);

            cmd.Parameters.AddWithValue("@from", from);
            cmd.Parameters.AddWithValue("@to", to);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }


        private void ExportReportToPdf(DateTime from, DateTime to)
        {
            // Get current data from grids
            var salesDt = (DataTable)dgvSales.DataSource;
            var itemsDt = LoadAllItemsInRange(from, to);

            SaveFileDialog saveDlg = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = $"Sales_Report_{from:yyyyMMdd}_to_{to:yyyyMMdd}.pdf"
            };

            if (saveDlg.ShowDialog() != DialogResult.OK) return;

            try
            {
                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(40);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(12));

                        page.Header().Text($"Sales Report\nFrom: {from:MMMM dd, yyyy} To: {to:MMMM dd, yyyy}")
                            .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                        page.Content().Column(col =>
                        {
                            // Summary Section
                            col.Item().Text("Summary").FontSize(16).SemiBold();
                            col.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                });

                                table.Cell().Text($"Total Sales: ₱ {label2.Text.Replace("Total Sales: ₱ ", "")}");
                                table.Cell().Text($"Total Discount: ₱ {label3.Text.Replace("Total Discount: ₱ ", "")}");
                                // Add other summary lines similarly...
                                table.Cell().Text($"Transactions: {label7.Text.Replace("Transactions: ", "")}");
                            });

                            col.Item().PaddingTop(20);

                            // Sales Table
                            col.Item().Text("Sales Transactions").FontSize(16).SemiBold();
                            col.Item().Table(table =>
                            {
                                // Headers
                                table.ColumnsDefinition(cols =>
                                {
                                    cols.ConstantColumn(50);  // ID
                                    cols.RelativeColumn(2);   // DateTime
                                    cols.RelativeColumn();    // Subtotal
                                    cols.RelativeColumn();    // Discount
                                    cols.RelativeColumn();    // Total
                                    cols.RelativeColumn();    // Cash
                                    cols.RelativeColumn();    // Change
                                });

                                table.Header(header =>
                                {
                                    void HeaderCell(string text)
                                    {
                                        header.Cell()
                                            .Background(Colors.Grey.Lighten2)
                                            .Padding(5)
                                            .AlignCenter()
                                            .Text(text)
                                            .SemiBold();
                                    }

                                    HeaderCell("ID");
                                    HeaderCell("Date & Time");
                                    HeaderCell("Subtotal");
                                    HeaderCell("Discount");
                                    HeaderCell("Total");
                                    HeaderCell("Cash");
                                    HeaderCell("Change");
                                });

                                foreach (DataRow row in salesDt.Rows)
                                {
                                    table.Cell().Text(row["sale_id"].ToString());
                                    table.Cell().Text(row["datetime"].ToString());
                                    table.Cell().Text($"₱ {Convert.ToDecimal(row["subtotal"]):N2}");
                                    table.Cell().Text($"₱ {Convert.ToDecimal(row["discount"]):N2}");
                                    table.Cell().Text($"₱ {Convert.ToDecimal(row["total_amount"]):N2}");
                                    table.Cell().Text($"₱ {Convert.ToDecimal(row["cash_tendered"]):N2}");
                                    table.Cell().Text($"₱ {Convert.ToDecimal(row["change_given"]):N2}");
                                }
                            });

                            col.Item().PaddingTop(20);

                            // Item Summary Table (for the selected sale)
                            if (itemsDt.Rows.Count > 0)
                            {
                                col.Item().Text("Item Summary (All Transactions)")
                                    .FontSize(16).SemiBold();

                                col.Item().Table(table =>
                                {
                                    table.ColumnsDefinition(cols =>
                                    {
                                        cols.ConstantColumn(80);   // Product ID
                                        cols.RelativeColumn(3);    // Name
                                        cols.ConstantColumn(80);   // Qty
                                        cols.ConstantColumn(90);   // Price
                                        cols.ConstantColumn(110);  // Total
                                    });

                                    table.Header(header =>
                                    {
                                        void HeaderCell(string text)
                                        {
                                            header.Cell()
                                                .Background(Colors.Grey.Lighten2)
                                                .Padding(5)
                                                .AlignCenter()
                                                .Text(text)
                                                .SemiBold();
                                        }

                                        HeaderCell("Product ID");
                                        HeaderCell("Product Name");
                                        HeaderCell("Total Qty");
                                        HeaderCell("Unit Price");
                                        HeaderCell("Total Sales");
                                    });

                                    foreach (DataRow row in itemsDt.Rows)
                                    {
                                        table.Cell().Padding(5).Text(row["product_id"].ToString());
                                        table.Cell().Padding(5).Text(row["Product"].ToString());
                                        table.Cell().Padding(5).AlignRight().Text(row["total_quantity"].ToString());
                                        table.Cell().Padding(5).AlignRight()
                                            .Text($"₱ {Convert.ToDecimal(row["price"]):N2}");
                                        table.Cell().Padding(5).AlignRight()
                                            .Text($"₱ {Convert.ToDecimal(row["total_sales"]):N2}");
                                    }
                                });
                            }
                        });

                        page.Footer().AlignCenter().Text(x =>
                        {
                            x.CurrentPageNumber();
                            x.Span(" / ");
                            x.TotalPages();
                        });
                    });
                }).GeneratePdf(saveDlg.FileName);

                MessageBox.Show("PDF exported successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"PDF generation failed:\n\n{ex}\n\nInner:\n{ex.InnerException}",
                    "PDF Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvItemSummary_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                string colName = e.Cell.OwningColumn.Name;

                if (colName == "product_id" || colName == "Product" || colName == "quantity" || colName == "price" || colName == "subtotal")
                {
                    e.Cell.Selected = false;
                }
            }
        }
    }
}
