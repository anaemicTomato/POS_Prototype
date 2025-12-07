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
    public partial class ManageUsersControl : UserControl
    {
        private readonly string dbPath = DBhelper.GetProjectDbPath();
        private readonly string connectionString;

        public ManageUsersControl()
        {
            InitializeComponent();
            connectionString = DBhelper.GetConnectionString();
            txtSearch.TextChanged += TxtSearch_TextChanged;
            LoadUsers();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUsers(txtSearch.Text.Trim());
        }

        private void LoadUsers(string search = "")
        {
            dgvUsers.Rows.Clear();

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
                        cmd.CommandText = "SELECT username, password, role, last_login FROM users";
                    }
                    else
                    {
                        cmd.CommandText = @"
                    SELECT username, password, role, last_login
                    FROM users
                    WHERE username LIKE $search
                       OR password LIKE $search
                       OR role LIKE $search
                       OR last_login Like $search
                ";
                        cmd.Parameters.AddWithValue("$search", $"%{search}%");
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvUsers.Rows.Add(
                                reader["username"],
                                reader["password"],
                                reader["role"],
                                reader["last_login"] == DBNull.Value ? "" : reader["last_login"].ToString()
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

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            AddEditUserForm addForm = new AddEditUserForm();
            addForm.ShowDialog();
            LoadUsers();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvUsers.SelectedRows[0];

            string username = row.Cells["colUsername"].Value?.ToString();
            string password = row.Cells["colPassword"].Value?.ToString();
            string role = row.Cells["colRole"].Value?.ToString();

            // Pass data to the form
            AddEditUserForm editForm = new AddEditUserForm(username, password, role);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Reload users after editing
                LoadUsers();
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvUsers.SelectedRows[0];
            string username = row.Cells["colUsername"].Value?.ToString();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Invalid user selected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to remove user '{username}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (var con = new SqliteConnection(connectionString))
                {
                    con.Open();

                    var cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM users WHERE username = $username";
                    cmd.Parameters.AddWithValue("$username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //pang mask sa password
        private void dataGridViewUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colPassword" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
        }
        //wala pakay functions ari ban, paghimog bag ong window sama sa AddEditProductForm
    }
}
