using POS_Prototype.Data;
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

namespace POS_Prototype.Windows
{
    public partial class AddEditUserForm : Form
    {
        private bool isEditMode = false;
        private string originalUsername = "";

        public AddEditUserForm()
        {
            InitializeComponent();
            cbRole.Items.AddRange(new string[] { "Admin", "Cashier" });
        }

        // EDIT MODE constructor
        public AddEditUserForm(string username, string password, string role)
        {
            InitializeComponent();
            isEditMode = true;

            cbRole.Items.AddRange(new string[] { "Admin", "Cashier" });
            originalUsername = username;

            txtUsername.Text = username;
            txtPassword.Text = password;
            txtConfirmPass.Text = password;
            cbRole.Text = role;

            label5.Text = "Edit User";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPass.Text.Trim();
            string role = cbRole.Text.Trim();

            if (username == "" || password == "" || confirmPass == "" || role == "")
            {
                MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPass)
            {
                MessageBox.Show("Passwords do not match!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conn = DBhelper.GetConnectionString();

            using (SqliteConnection con = new SqliteConnection(conn))
            {
                con.Open();
                var cmd = con.CreateCommand();

                if (!isEditMode)
                {
                    // INSERT user
                    cmd.CommandText = @"INSERT INTO users (username, password, role)
                                        VALUES ($u, $p, $r)";
                    cmd.Parameters.AddWithValue("$u", username);
                    cmd.Parameters.AddWithValue("$p", password);
                    cmd.Parameters.AddWithValue("$r", role);
                }
                else
                {
                    // UPDATE user
                    cmd.CommandText = @"UPDATE users
                                        SET username = $u, password = $p, role = $r
                                        WHERE username = $orig";
                    cmd.Parameters.AddWithValue("$u", username);
                    cmd.Parameters.AddWithValue("$p", password);
                    cmd.Parameters.AddWithValue("$r", role);
                    cmd.Parameters.AddWithValue("$orig", originalUsername);
                }

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(isEditMode ? "User updated successfully!" : "User created successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
