using POS_Prototype.Windows;
using Microsoft.Data.Sqlite;
using POS_Prototype.Data;

namespace POS_Prototype
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = userTextBox.Text;
            string password = passTextBox.Text;

            // Gamita ag DBHelper class para maghimog connection string
            string connectionString = DBhelper.GetConnectionString();

            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT role FROM users WHERE username=@username AND password=@password";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        var role = command.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(role))
                        {
                            //Update last_login
                            using (var updateCon = new SqliteConnection(connectionString))
                            {
                                updateCon.Open();
                                var updateCmd = updateCon.CreateCommand();
                                updateCmd.CommandText = @"UPDATE users 
                                  SET last_login = datetime('now','localtime') 
                                  WHERE username = $username";
                                updateCmd.Parameters.AddWithValue("$username", username);
                                updateCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show($"Login successful! Role: {role}");

                            if (role == "Admin")
                            {
                                this.Hide();
                                using (AdminForm adminForm = new AdminForm())
                                {
                                    adminForm.ShowDialog(); // wait until admin closes
                                }

                                userTextBox.Clear();
                                passTextBox.Clear();
                                userTextBox.Focus();

                                this.Show(); // show login again
                            }
                            else if (role == "Cashier")
                            {
                                CashierForm cashierForm = new CashierForm();
                                cashierForm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            userTextBox.Clear();
                            passTextBox.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sencer, EventArgs e)
        {
            Application.Exit();
        }
        // what is up, this is the latest commit you fuck.
    }
}
