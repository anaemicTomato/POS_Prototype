using POS_Prototype.Controls.AdminControls;
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
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // pang full screen par
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear(); // remove previous page

            ManageProductsControl page = new ManageProductsControl();
            page.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(page);
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear(); // remove previous page

            ManageInventoryControl page = new ManageInventoryControl();
            page.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(page);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear(); // remove previous page

            ManageUsersControl page = new ManageUsersControl();
            page.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(page);
        }
        //kkulang pakag mga modules dri gar

        private void btnReports_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear(); // remove previous page

            SalesReportControl page = new SalesReportControl();
            page.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(page);
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        
    }
}
