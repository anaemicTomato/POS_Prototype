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
using POS_Prototype.Data;


namespace POS_Prototype.Controls.AdminControls
{
    public partial class ManageProductsControl : UserControl
    {
        private readonly string dbPath = DBhelper.GetProjectDbPath();
        private readonly string connectionString;

        public ManageProductsControl()
        {
            InitializeComponent();

            // Create the connection string
            connectionString = DBhelper.GetConnectionString();
            txtSearch.TextChanged += TxtSearch_TextChanged;
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
                MessageBox.Show($"Database not found at:\n{dbPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var con = new SqliteConnection(connectionString))
                {
                    con.Open();
                    var cmd = con.CreateCommand();

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
                       OR Price LIKE $search
                ";
                        cmd.Parameters.AddWithValue("$search", $"%{search}%");
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvProducts.Rows.Add(
                                reader["Id"],
                                reader["Name"],
                                reader["Price"],
                                reader["Barcode"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load products:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditProductForm addForm = new AddEditProductForm();

            // Refresh the products list when the form closes
            addForm.ShowDialog();  // Wait for modal form to close
            LoadProducts();        // Now reload the data
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header

            // EDIT button column
            if (dgvProducts.Columns[e.ColumnIndex].Name == "colEdit")
            {
                int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["colId"].Value);
                // Open the edit form modally
                AddEditProductForm editForm = new AddEditProductForm(productId);
                editForm.ShowDialog(); // Wait for the form to close
                LoadProducts();
            }

            // DELETE button column
            if (dgvProducts.Columns[e.ColumnIndex].Name == "colDelete")
            {
                int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["colId"].Value);
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    DeleteProduct(productId); // your delete logic
                    LoadProducts();
                }
            }
        }

        private void DeleteProduct(int productId)
        {
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
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Products WHERE Id = $id";
                        cmd.Parameters.AddWithValue("$id", productId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Product deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete product:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvProducts.Columns[e.ColumnIndex].Name;           

            if (colName == "colEdit")
            {
                e.CellStyle.BackColor = Color.LightSkyBlue;
                e.CellStyle.ForeColor = Color.Black;
            }

            if (colName == "colDelete")
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 128, 128);
                e.CellStyle.ForeColor = Color.Black;
            }
        }

        //pang disable rani siya sa selection highlight ban
        private void dgvInventory_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                string colName = e.Cell.OwningColumn.Name;

                if (colName == "colName" || colName == "colPrice" || colName == "colBarcode")
                {
                    e.Cell.Selected = false;
                }
            }
        }
    }
}
