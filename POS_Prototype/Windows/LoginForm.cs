using POS_Prototype.Windows;
using Microsoft.Data.Sqlite;

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

            // Build path to your database
            string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "pos.db");
            string connectionString = $"Data Source={dbPath}";

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
                            MessageBox.Show($"Login successful! Role: {role}");

                            if (role == "admin")
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
                            else if (role == "cashier")
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
