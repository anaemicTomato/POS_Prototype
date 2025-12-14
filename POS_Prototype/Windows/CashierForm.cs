using Microsoft.Data.Sqlite;
using POS_Prototype.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;


namespace POS_Prototype.Windows
{
    public partial class CashierForm : Form
    {
        private readonly string dbPath = DBhelper.GetProjectDbPath();
        private readonly string connectionString;
        private int previousQty = 0;

        public CashierForm()
        {
            InitializeComponent();
            connectionString = DBhelper.GetConnectionString();

            txtSearch.TextChanged += TxtSearch_TextChanged;
            txtDiscount.TextChanged += (s, e) => ComputeTotals();
            txtCashReceived.TextChanged += TxtCashReceived_TextChanged;
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadProducts();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }


        private void LoadProducts(string search = "")
        {
            dgvProducts.Rows.Clear();

            if (!File.Exists(dbPath))
            {
                MessageBox.Show("Database not found.", "Error");
                return;
            }

            using var con = new SqliteConnection(connectionString);
            con.Open();
            var cmd = con.CreateCommand();

            if (string.IsNullOrEmpty(search))
            {
                cmd.CommandText = "SELECT Id, Name, Price, Stock, Barcode FROM Products";
            }
            else
            {

                cmd.CommandText = @"
                    SELECT Id, Name, Price, Stock, Barcode 
                    FROM Products
                    WHERE Barcode = @s OR Name LIKE @s_like OR Barcode LIKE @s_like";
                cmd.Parameters.AddWithValue("@s", search);
                cmd.Parameters.AddWithValue("@s_like", $"%{search}%");
            }

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                dgvProducts.Rows.Add(
                  r["Id"],
                  r["Name"],
                  r["Price"],
                  r["Stock"]
                );
            }
        }

        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvProducts.Columns[e.ColumnIndex].Name == "colAddToCart")
            {
                int id = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["colId"].Value);
                string name = dgvProducts.Rows[e.RowIndex].Cells["colName"].Value.ToString();
                decimal price = Convert.ToDecimal(dgvProducts.Rows[e.RowIndex].Cells["colPrice"].Value);
                int stock = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["colStock"].Value);

                if (stock <= 0)
                {
                    MessageBox.Show("Item out of stock.");
                    return;
                }

                AddToCart(id, name, price);
            }
        }

        private void dgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCart.Columns[e.ColumnIndex].Name != "colCqty") return;

            try
            {
                var row = dgvCart.Rows[e.RowIndex];

                int productId = Convert.ToInt32(row.Cells["colCId"].Value);
                decimal price = Convert.ToDecimal(row.Cells["colCPrice"].Value);

                var cellValue = row.Cells["colCqty"].Value;

                if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    MessageBox.Show("Please enter a value.");
                    row.Cells["colCqty"].Value = previousQty;
                    return;
                }

                int newQty = int.Parse(cellValue.ToString());

                if (newQty <= 0)
                {
                    MessageBox.Show("Quantity must be at least 1.");
                    row.Cells["colCqty"].Value = previousQty;
                    return;
                }

                int availableStock = GetCurrentProductStock(productId)
                                     + previousQty; // return old qty to stock calculation

                if (newQty > availableStock)
                {
                    MessageBox.Show("Not enough stock.");
                    newQty = availableStock;
                    row.Cells["colCqty"].Value = newQty;
                }

                // COMPUTE DIFFERENCE
                int qtyDifference = newQty - previousQty;

                // UPDATE PRODUCT STOCK
                UpdateProductStock(productId, -qtyDifference);

                // UPDATE TOTAL
                row.Cells["colCtotal"].Value = newQty * price;

                ComputeTotals();
            }
            catch
            {
                MessageBox.Show("Invalid quantity.");
                dgvCart.Rows[e.RowIndex].Cells["colCqty"].Value = previousQty;
            }
        }

        private void dgvCart_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvCart.Columns[e.ColumnIndex].Name == "colCqty")
            {
                var value = dgvCart.Rows[e.RowIndex].Cells["colCqty"].Value;
                previousQty = value == null ? 0 : Convert.ToInt32(value);
            }
        }

        //Helper method ni siya para makuha ang current product stock
        private int GetCurrentProductStock(int productId)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells["colId"].Value != null &&
                    Convert.ToInt32(row.Cells["colId"].Value) == productId)
                {
                    return Convert.ToInt32(row.Cells["colStock"].Value);
                }
            }
            return 0;
        }


        private void DgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCart.BeginEdit(true);

            if (e.RowIndex < 0) return;

            if (dgvCart.Columns[e.ColumnIndex].Name == "colCremove")
            {

                if (dgvCart.Rows[e.RowIndex].IsNewRow) return;

                int productId = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["colCId"].Value);
                int qty = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["colCqty"].Value);

                dgvCart.Rows.RemoveAt(e.RowIndex);

                UpdateProductStock(productId, qty);
                ComputeTotals();
            }
        }

        private void AddToCart(int id, string name, decimal price)
        {
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["colCId"].Value != null && Convert.ToInt32(row.Cells["colCId"].Value) == id)
                {
                    int qty = Convert.ToInt32(row.Cells["colCqty"].Value) + 1;
                    row.Cells["colCqty"].Value = qty;
                    row.Cells["colCtotal"].Value = price * qty;
                    UpdateProductStock(id, -1);

                    ComputeTotals();
                    return;
                }
            }

            dgvCart.Rows.Add(id, name, price, 1, price);
            UpdateProductStock(id, -1);
            ComputeTotals();
        }

        private void UpdateProductStock(int productId, int change)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells["colId"].Value != null && Convert.ToInt32(row.Cells["colId"].Value) == productId)
                {
                    int currentStock = Convert.ToInt32(row.Cells["colStock"].Value);
                    row.Cells["colStock"].Value = currentStock + change;
                    break;
                }
            }
        }

        private void ComputeTotals()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;

                subtotal += Convert.ToDecimal(row.Cells["colCtotal"].Value);
            }

            lblSubtotal.Text = $"₱ {subtotal:N2}";

            decimal discountPercent = 0;
            if (decimal.TryParse(txtDiscount.Text, out decimal d))
                discountPercent = d;

            decimal discountAmount = subtotal * (discountPercent / 100);
            lblDiscount.Text = $"₱ {discountAmount:N2}";

            decimal total = subtotal - discountAmount;
            lblTotal.Text = $"₱ {total:N2}";

            ComputeChange();
        }

        private void ComputeChange()
        {
            string totalText = lblTotal.Text.Replace("₱", "").Trim();
            string cashText = txtCashReceived.Text.Trim();

            if (decimal.TryParse(totalText, out decimal total) &&
              decimal.TryParse(cashText, out decimal cash))
            {
                decimal change = cash - total;
                lblChange.Text = $"₱ {change:N2}";
            }
            else
            {
                lblChange.Text = "₱ 0.00";
            }
        }

        private void TxtCashReceived_TextChanged(object sender, EventArgs e)
        {
            ComputeChange();
        }

        //CHECKOUT BUTTON
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty. Please add items before checking out.");
                return;
            }

            if (!decimal.TryParse(lblSubtotal.Text.Replace("₱", "").Trim(), out decimal subtotal) ||
                !decimal.TryParse(lblDiscount.Text.Replace("₱", "").Trim(), out decimal discount) ||
                !decimal.TryParse(lblTotal.Text.Replace("₱", "").Trim(), out decimal total) ||
                !decimal.TryParse(txtCashReceived.Text.Trim(), out decimal cash) ||
                cash < total)
            {
                MessageBox.Show("Payment error. Please check cash amount.", "Error");
                return;
            }

            decimal change = cash - total;

            using var con = new SqliteConnection(connectionString);
            con.Open();
            using var tran = con.BeginTransaction();

            try
            {
                // 1️⃣ INSERT SALE
                string saleSql = @"
            INSERT INTO sales 
            (datetime, subtotal, discount, total_amount, cash_tendered, change_given)
            VALUES (datetime('now','localtime'), @sub, @disc, @total, @cash, @change);
            SELECT last_insert_rowid();
        ";

                long saleId;
                using (var cmdSale = new SqliteCommand(saleSql, con, tran))
                {
                    cmdSale.Parameters.AddWithValue("@sub", subtotal);
                    cmdSale.Parameters.AddWithValue("@disc", discount);
                    cmdSale.Parameters.AddWithValue("@total", total);
                    cmdSale.Parameters.AddWithValue("@cash", cash);
                    cmdSale.Parameters.AddWithValue("@change", change);

                    saleId = (long)cmdSale.ExecuteScalar();
                }

                // 2️⃣ INSERT SALE ITEMS + UPDATE STOCK
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow) continue;

                    int productId = Convert.ToInt32(row.Cells["colCId"].Value);
                    int qty = Convert.ToInt32(row.Cells["colCqty"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["colCPrice"].Value);
                    decimal itemSubtotal = Convert.ToDecimal(row.Cells["colCtotal"].Value);

                    // Insert sale item
                    string itemSql = @"
                INSERT INTO sale_items 
                (sale_id, product_id, quantity, price, subtotal)
                VALUES (@saleId, @pid, @qty, @price, @sub);
            ";

                    using var cmdItem = new SqliteCommand(itemSql, con, tran);
                    cmdItem.Parameters.AddWithValue("@saleId", saleId);
                    cmdItem.Parameters.AddWithValue("@pid", productId);
                    cmdItem.Parameters.AddWithValue("@qty", qty);
                    cmdItem.Parameters.AddWithValue("@price", price);
                    cmdItem.Parameters.AddWithValue("@sub", itemSubtotal);
                    cmdItem.ExecuteNonQuery();

                    // Update stock ONCE
                    string stockSql = @"
                UPDATE Products 
                SET Stock = Stock - @qty 
                WHERE Id = @id AND Stock >= @qty;
            ";

                    using var cmdStock = new SqliteCommand(stockSql, con, tran);
                    cmdStock.Parameters.AddWithValue("@qty", qty);
                    cmdStock.Parameters.AddWithValue("@id", productId);
                    cmdStock.ExecuteNonQuery();
                }

                tran.Commit();

                // 3️⃣ PRINT RECEIPT
                PrintReceipt();

                MessageBox.Show(
                    $"Sale completed successfully!\nSale ID: {saleId}\nChange: ₱ {change:N2}",
                    "Success"
                );

                // 4️⃣ RESET UI
                dgvCart.Rows.Clear();
                txtCashReceived.Clear();
                txtDiscount.Clear();
                lblChange.Text = "₱ 0.00";

                ComputeTotals();
                LoadProducts();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show($"Checkout failed:\n{ex.Message}", "Error");
            }
        }

        // --- NEW PRINTING METHODS ---

        private void PrintReceipt()
        {
            System.Drawing.Printing.PrintDocument receipt = new System.Drawing.Printing.PrintDocument();


            receipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Receipt_PrintPage);

            try
            {

                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = receipt;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Printing Error: {ex.Message}");
            }
        }

        private void Receipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            System.Drawing.Font printFont = new System.Drawing.Font("Consolas", 14);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            float yPos = 10;
            float leftMargin = 50;
            float lineSpacing = 20;


            e.Graphics.DrawString("--- SALE RECEIPT ---", printFont, myBrush, leftMargin + 10, yPos);
            yPos += lineSpacing * 2;


            e.Graphics.DrawString("Product    Qty    Total", printFont, myBrush, leftMargin, yPos);
            yPos += lineSpacing;
            e.Graphics.DrawString("-----------------------", printFont, myBrush, leftMargin, yPos);
            yPos += lineSpacing;


            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;

                string productName = row.Cells["colCName"].Value?.ToString() ?? "";
                string qty = row.Cells["colCqty"].Value?.ToString() ?? "";
                string total = row.Cells["colCtotal"].Value?.ToString() ?? "";

                string line = $"{productName.PadRight(10).Substring(0, Math.Min(productName.Length, 10))}  {qty.PadLeft(3)}  {total.PadLeft(6)}";

                e.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPos);
                yPos += lineSpacing;
            }


            yPos += lineSpacing;
            e.Graphics.DrawString("-----------------------", printFont, myBrush, leftMargin, yPos);
            yPos += lineSpacing;
            e.Graphics.DrawString($"Subtotal: {lblSubtotal.Text.PadLeft(10)}", printFont, myBrush, leftMargin, yPos);
            yPos += lineSpacing;
            e.Graphics.DrawString($"Discount: {lblDiscount.Text.PadLeft(10)}", printFont, myBrush, leftMargin, yPos);
            yPos += lineSpacing;
            e.Graphics.DrawString($"TOTAL: {lblTotal.Text.PadLeft(14)}", printFont, myBrush, leftMargin, yPos);


            yPos += lineSpacing * 2;
            e.Graphics.DrawString($"Cash: {txtCashReceived.Text.PadLeft(17)}", printFont, myBrush, leftMargin, yPos);
            yPos += lineSpacing;
            e.Graphics.DrawString($"Change: {lblChange.Text.PadLeft(15)}", printFont, myBrush, leftMargin, yPos);

            e.HasMorePages = false;
        }


        private void btnClearCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;

                int productId = Convert.ToInt32(row.Cells["colCId"].Value);
                int qty = Convert.ToInt32(row.Cells["colCqty"].Value);
                UpdateProductStock(productId, qty);
            }

            dgvCart.Rows.Clear();
            ComputeTotals();
        }

        //LOGOUT BUTTON
        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }


        private void btnScan_Click(object sender, EventArgs e)
        {

            ScannerForm scanner = new ScannerForm();


            scanner.BarcodeScanned += HandleScannedBarcode;


            scanner.ShowDialog();
        }


        private void HandleScannedBarcode(string barcode)
        {

            LoadProducts(barcode);


            if (dgvProducts.Rows.Count == 1)
            {



                int addToCartColumnIndex = dgvProducts.Columns["colAddToCart"].Index;


                DgvProducts_CellClick(dgvProducts,
                    new DataGridViewCellEventArgs(addToCartColumnIndex, 0));
            }
        }

        
    }
}