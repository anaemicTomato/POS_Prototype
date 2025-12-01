using Microsoft.Data.Sqlite;
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
            LoadProducts();
        }

        private void LoadProducts()
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

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvInventory.Rows.Add(
                                reader["Id"],
                                reader["Name"],
                                reader["Stock"],
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
        //pag add ug bale tulo ka columns ban, ag type in amount, (+) nga button ug (-) nga button nigga
    }
}
