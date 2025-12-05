using Microsoft.Data.Sqlite;
using POS_Prototype.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Prototype.Controls.AdminControls
{
    public partial class ManageInventoryControl : UserControl
    {
        private readonly string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "pos.db");
        private readonly string connectionString;

        public ManageInventoryControl()
        {
            InitializeComponent();
            connectionString = $"Data Source={dbPath}";
            txtSearch.TextChanged += TxtSearch_TextChanged;
            LoadProducts();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        private void LoadProducts(string search = "")
        {
            dgvInventory.Rows.Clear();

            if (!File.Exists(dbPath))
            {
                MessageBox.Show($"Database not found at:\n{dbPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var con = new SqliteConnection(connectionString))
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT Id, Name, Stock, Barcode FROM Products";

                    if (string.IsNullOrEmpty(search))
                    {
                        cmd.CommandText = "SELECT * FROM Products";
                    }
                    else
                    {
                        cmd.CommandText = @"
                    SELECT * FROM Products
                    WHERE Name LIKE $search
                       OR Barcode LIKE $search
                ";
                        cmd.Parameters.AddWithValue("$search", $"%{search}%");
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvInventory.Rows.Add();
                            dgvInventory.Rows[rowIndex].Cells["colId"].Value = reader["Id"];
                            dgvInventory.Rows[rowIndex].Cells["colName"].Value = reader["Name"];
                            dgvInventory.Rows[rowIndex].Cells["colStocks"].Value = reader["Stock"]; // ensure this is your grid column name
                            dgvInventory.Rows[rowIndex].Cells["colBarcode"].Value = reader["Barcode"];

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load products:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInventory.BeginEdit(true);

            if (e.RowIndex < 0) return; // Ignore header

            // Increase Stock (+)

            if (dgvInventory.Columns[e.ColumnIndex].Name == "colAddStock")
            {
                int productId = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["colId"].Value);

                IncreaseStock(productId, 1);

                LoadProducts();
            }

            // Decrease Stock (-)

            if (dgvInventory.Columns[e.ColumnIndex].Name == "colMinusStock")
            {
                int productId = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["colId"].Value);

                DecreaseStock(productId);

                LoadProducts();
            }
        }

        private void dgvInventory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInventory.Columns[e.ColumnIndex].Name == "colCustomStock")
            {
                try
                {
                    int productId = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["colId"].Value);
                    var cellValue = dgvInventory.Rows[e.RowIndex].Cells["colCustomStock"].Value;

                    if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
                    {
                        MessageBox.Show("Please enter a value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int newStock = int.Parse(cellValue.ToString());

                    if (newStock < 0)
                    {
                        MessageBox.Show("Stock cannot be negative.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Set the stock in the database
                    SetStock(productId, newStock);

                    // Clear the editable cell
                    dgvInventory.Rows[e.RowIndex].Cells["colCustomStock"].Value = null;

                    // Refresh the grid to show the new stock
                    LoadProducts();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Only numeric values are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvInventory.Rows[e.RowIndex].Cells["colCustomStock"].Value = null;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("The number is too large.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvInventory.Rows[e.RowIndex].Cells["colCustomStock"].Value = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Logics paras Stock nga Column etc.
        private void IncreaseStock(int productId, int amount)
        {
            using (var con = new SqliteConnection(connectionString))
            {
                con.Open();

                string query = "UPDATE Products SET Stock = Stock + @Amount WHERE Id = @Id";

                using (var cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Id", productId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DecreaseStock(int productId)
        {
            using (var con = new SqliteConnection(connectionString))
            {
                con.Open();

                string query = "UPDATE Products SET Stock = Stock - 1 WHERE Id = @Id AND Stock > 0";

                using (var cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", productId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SetStock(int productId, int newStock)
        {
            using (var con = new SqliteConnection(connectionString))
            {
                con.Open();

                string query = "UPDATE Products SET Stock = @Stock WHERE Id = @Id";

                using (var cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Stock", newStock);
                    cmd.Parameters.AddWithValue("@Id", productId);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //Color2 rani siya diari

        private void dgvInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvInventory.Columns[e.ColumnIndex].Name;

            if (colName == "colStocks")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int stockQuantity))
                {
                    string[] colorColumns = { "colId", "colName", "colStocks", "colBarcode" };

                    foreach (string targetCol in colorColumns)
                    {
                        var cell = dgvInventory.Rows[e.RowIndex].Cells[targetCol];

                        if (stockQuantity == 0)
                        {
                            cell.Style.BackColor = Color.IndianRed;
                            cell.Style.ForeColor = Color.White;
                        }
                        else if (stockQuantity > 0 && stockQuantity <= 10)
                        {
                            cell.Style.BackColor = Color.Khaki;
                            cell.Style.ForeColor = Color.Black;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                            cell.Style.ForeColor = Color.Black;
                        }
                    }
                }
            }

            int stock = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["colStocks"].Value);

            if (colName == "colAddStock")
            {
                e.CellStyle.BackColor = Color.LightGreen;
                e.CellStyle.ForeColor = Color.Black;
            }

            if (colName == "colMinusStock")
            {
                if (stock <= 0)
                {
                    e.CellStyle.BackColor = Color.FromArgb(241, 218, 218);
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 128, 128);
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }



        //naa pay problema sa imoang stock column ug ag New Stock, dli mu update
        //after ana, either ipakita sa Product management ang stock or pagbutang ug indicators
        //mupula ang row pag isa nalang ang stock or unsa.
    }
}
