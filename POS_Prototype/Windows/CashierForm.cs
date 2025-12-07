using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using POS_Prototype.Data;



namespace POS_Prototype.Windows
{
    public partial class CashierForm : Form
    {
        string connectionString = DBhelper.GetConnectionString();

        public CashierForm()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("ProductName", "Product");
            dgvCart.Columns.Add("Price", "Price");
            dgvCart.Columns.Add("Qty", "Qty");
            dgvCart.Columns.Add("Total", "Total");

            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Name = "Remove";
            btnRemove.HeaderText = "Remove";
            btnRemove.Text = "X";
            btnRemove.UseColumnTextForButtonValue = true;
            dgvCart.Columns.Add(btnRemove);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            int qty = (int)numQty.Value;

            // 1. Check for missing search input
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Please enter the barcode or product name to search.");
                return;
            }

            // 2. Check for invalid quantity
            if (qty <= 0)
            {
                MessageBox.Show("Please enter a quantity greater than zero.");
                return;
            }

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open(); // If this fails, the 'catch' block will execute
                    string query = "SELECT name, price FROM products WHERE barcode = @search OR name LIKE @name";

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", search);
                        cmd.Parameters.AddWithValue("@name", "%" + search + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader.GetString(0);
                                decimal price = reader.GetDecimal(1);

                                AddOrUpdateCart(name, price, qty);
                            }
                            else
                            {
                                MessageBox.Show("Product not found."); // This is now reachable
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // CRITICAL: This will show the exact reason for the failure (e.g., file not found)
                MessageBox.Show($"Database Connection/Query Error: {ex.Message}\nCheck your connectionString and database file path.");
            }

            txtSearch.Clear();
            numQty.Value = 1;
        }

        private void AddOrUpdateCart(string name, decimal price, int qty)
        {
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["ProductName"].Value?.ToString() == name)
                {
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    int newQty = currentQty + qty;

                    row.Cells["Qty"].Value = newQty;
                    row.Cells["Total"].Value = (price * newQty).ToString("0.00");

                    UpdateTotals();
                    return;
                }
            }

            dgvCart.Rows.Add(name, price.ToString("0.00"), qty, (price * qty).ToString("0.00"));
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            decimal vat = subtotal * 0.12m;
            decimal total = subtotal + vat;

            lblSubtotal.Text = subtotal.ToString("0.00");
            lblVAT.Text = vat.ToString("0.00");
            lblTotal.Text = total.ToString("0.00");
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvCart.Columns["Remove"].Index && e.RowIndex >= 0)
            {

                if (dgvCart.Rows[e.RowIndex].IsNewRow)
                {

                    dgvCart.CancelEdit();
                    return;
                }
                dgvCart.Rows.RemoveAt(e.RowIndex);
                UpdateTotals();
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(lblTotal.Text, out decimal total) &&
               decimal.TryParse(txtCash.Text, out decimal cash))
            {
                lblChange.Text = (cash - total).ToString("0.00");
            }
        }

		private void btnComplete_Click(object sender, EventArgs e)
		{
			// 1. Validation for Empty Cart is still good.
			if (dgvCart.Rows.Count == 0)
			{
				MessageBox.Show("Cart is empty. Nothing to print.");
				return;
			}

			// 2. Validation for Cash/Total is optional, but recommended for a real POS.
			// Keeping it ensures the cashier has processed the payment.
			if (!decimal.TryParse(lblTotal.Text, out decimal total) ||
				!decimal.TryParse(txtCash.Text, out decimal cash) || cash < total)
			{
				MessageBox.Show("Insufficient cash or payment not entered.");
				return;
			}

			// 3. Print the Receipt (New step)
			PrintReceipt();
			MessageBox.Show("Receipt Printed!");

			// 4. Cleanup (Crucial to clear the screen for the next sale)
			dgvCart.Rows.Clear();
			txtCash.Clear();
			lblChange.Text = "0.00";
			UpdateTotals();
		}
		private void PrintReceipt()
		{
			// Make sure you have the 'using System.Windows.Forms;' directive
			// or fully qualify the class name like this:
			System.Drawing.Printing.PrintDocument receipt =
				new System.Drawing.Printing.PrintDocument();

			receipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Receipt_PrintPage);

			try
			{
				// 1. CREATE the Print Preview Dialog instance
				PrintPreviewDialog preview = new PrintPreviewDialog();

				// 2. ASSIGN your receipt document to the dialog
				preview.Document = receipt;

				// 3. SHOW the dialog instead of sending to the printer
				preview.ShowDialog();

				// You can comment out the MessageBox for "Receipt Printed!" to avoid confusion
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Printing Error: {ex.Message}");
			}
		}
		private void Receipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			// Define the font and brush for drawing text
			System.Drawing.Font printFont = new System.Drawing.Font("Consolas", 10);
			System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

			// Starting coordinates for printing
			float yPos = 10;
			float leftMargin = e.MarginBounds.Left;

			// Header
			e.Graphics.DrawString("--- SALE RECEIPT ---", printFont, myBrush, leftMargin + 50, yPos);
			yPos += 20;

			// Items List
			e.Graphics.DrawString("Product    Qty    Total", printFont, myBrush, leftMargin, yPos);
			yPos += 15;
			e.Graphics.DrawString("-----------------------", printFont, myBrush, leftMargin, yPos);
			yPos += 15;

			// Loop through the DataGridView rows to print items
			foreach (DataGridViewRow row in dgvCart.Rows)
			{
				if (row.IsNewRow) continue; // Skip the empty new row

				string productName = row.Cells["ProductName"].Value?.ToString() ?? "";
				string qty = row.Cells["Qty"].Value?.ToString() ?? "";
				string total = row.Cells["Total"].Value?.ToString() ?? "";

				// Simple formatting for the receipt line
				string line = $"{productName.PadRight(10).Substring(0, Math.Min(productName.Length, 10))}  {qty.PadLeft(3)}  {total.PadLeft(6)}";

				e.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPos);
				yPos += 15;
			}

			// Totals
			yPos += 20;
			e.Graphics.DrawString("-----------------------", printFont, myBrush, leftMargin, yPos);
			yPos += 15;
			e.Graphics.DrawString($"Subtotal: {lblSubtotal.Text.PadLeft(10)}", printFont, myBrush, leftMargin, yPos);
			yPos += 15;
			e.Graphics.DrawString($"VAT (12%): {lblVAT.Text.PadLeft(10)}", printFont, myBrush, leftMargin, yPos);
			yPos += 15;
			e.Graphics.DrawString($"TOTAL: {lblTotal.Text.PadLeft(14)}", printFont, myBrush, leftMargin, yPos);

			// Change and Payment
			yPos += 25;
			e.Graphics.DrawString($"Cash: {txtCash.Text.PadLeft(17)}", printFont, myBrush, leftMargin, yPos);
			yPos += 15;
			e.Graphics.DrawString($"Change: {lblChange.Text.PadLeft(15)}", printFont, myBrush, leftMargin, yPos);

			// Tell the printer there are no more pages
			e.HasMorePages = false;
		
        //OTEN
        }
	}
}
