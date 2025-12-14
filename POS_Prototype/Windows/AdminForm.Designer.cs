namespace POS_Prototype.Windows
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            topPanel = new Panel();
            SidePanel = new Panel();
            btnReturn = new Button();
            iconImageList = new ImageList(components);
            btnReports = new Button();
            btnManageUsers = new Button();
            btnManageInventory = new Button();
            btnManageProducts = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            MainPanel = new Panel();
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(15, 20, 35);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1378, 80);
            topPanel.TabIndex = 0;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(29, 36, 62);
            SidePanel.Controls.Add(btnReturn);
            SidePanel.Controls.Add(btnReports);
            SidePanel.Controls.Add(btnManageUsers);
            SidePanel.Controls.Add(btnManageInventory);
            SidePanel.Controls.Add(btnManageProducts);
            SidePanel.Controls.Add(label2);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 80);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(400, 764);
            SidePanel.TabIndex = 1;
            // 
            // btnReturn
            // 
            btnReturn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReturn.BackColor = Color.LightSkyBlue;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.ImageKey = "ReturnKey (Black).png";
            btnReturn.ImageList = iconImageList;
            btnReturn.Location = new Point(36, 691);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(88, 40);
            btnReturn.TabIndex = 7;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // iconImageList
            // 
            iconImageList.ColorDepth = ColorDepth.Depth32Bit;
            iconImageList.ImageStream = (ImageListStreamer)resources.GetObject("iconImageList.ImageStream");
            iconImageList.TransparentColor = Color.Transparent;
            iconImageList.Images.SetKeyName(0, "Inventory (Black).png");
            iconImageList.Images.SetKeyName(1, "Inventory (White).png");
            iconImageList.Images.SetKeyName(2, "Products (Black).png");
            iconImageList.Images.SetKeyName(3, "Products (White).png");
            iconImageList.Images.SetKeyName(4, "Sales Report (Black).png");
            iconImageList.Images.SetKeyName(5, "Sales Report (White).png");
            iconImageList.Images.SetKeyName(6, "Settings (Black).png");
            iconImageList.Images.SetKeyName(7, "Settings (White).png");
            iconImageList.Images.SetKeyName(8, "User Management (Black).png");
            iconImageList.Images.SetKeyName(9, "User Management (White).png");
            iconImageList.Images.SetKeyName(10, "ReturnKey (Black).png");
            iconImageList.Images.SetKeyName(11, "ReturnKey (White).png");
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Black;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnReports.ForeColor = SystemColors.ButtonHighlight;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.ImageKey = "Sales Report (White).png";
            btnReports.ImageList = iconImageList;
            btnReports.Location = new Point(36, 582);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(328, 53);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = Color.Black;
            btnManageUsers.FlatAppearance.BorderSize = 0;
            btnManageUsers.FlatStyle = FlatStyle.Flat;
            btnManageUsers.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnManageUsers.ForeColor = SystemColors.ButtonHighlight;
            btnManageUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageUsers.ImageKey = "User Management (White).png";
            btnManageUsers.ImageList = iconImageList;
            btnManageUsers.Location = new Point(36, 518);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(328, 53);
            btnManageUsers.TabIndex = 4;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = false;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnManageInventory
            // 
            btnManageInventory.BackColor = Color.Black;
            btnManageInventory.FlatAppearance.BorderSize = 0;
            btnManageInventory.FlatStyle = FlatStyle.Flat;
            btnManageInventory.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnManageInventory.ForeColor = SystemColors.ButtonHighlight;
            btnManageInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageInventory.ImageKey = "Inventory (White).png";
            btnManageInventory.ImageList = iconImageList;
            btnManageInventory.Location = new Point(36, 454);
            btnManageInventory.Name = "btnManageInventory";
            btnManageInventory.Size = new Size(328, 53);
            btnManageInventory.TabIndex = 3;
            btnManageInventory.Text = "Manage Inventory";
            btnManageInventory.UseVisualStyleBackColor = false;
            btnManageInventory.Click += btnManageInventory_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.BackColor = Color.Black;
            btnManageProducts.FlatAppearance.BorderSize = 0;
            btnManageProducts.FlatStyle = FlatStyle.Flat;
            btnManageProducts.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnManageProducts.ForeColor = SystemColors.ButtonHighlight;
            btnManageProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageProducts.ImageKey = "Products (White).png";
            btnManageProducts.ImageList = iconImageList;
            btnManageProducts.Location = new Point(36, 391);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(328, 53);
            btnManageProducts.TabIndex = 2;
            btnManageProducts.Text = "Manage Products";
            btnManageProducts.UseVisualStyleBackColor = false;
            btnManageProducts.Click += btnManageProducts_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumSpringGreen;
            label2.Location = new Point(120, 216);
            label2.Name = "label2";
            label2.Size = new Size(152, 27);
            label2.TabIndex = 1;
            label2.Text = "Administrator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(138, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(400, 80);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(15);
            MainPanel.Size = new Size(978, 764);
            MainPanel.TabIndex = 2;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 844);
            Controls.Add(MainPanel);
            Controls.Add(SidePanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminWindow";
            Load += AdminForm_Load;
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Panel SidePanel;
        private Panel MainPanel;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnManageProducts;
        private ImageList iconImageList;
        private Button btnReports;
        private Button btnManageUsers;
        private Button btnManageInventory;
        private Button btnReturn;
    }
}