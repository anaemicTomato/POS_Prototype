namespace POS_Prototype.Windows
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            panel1 = new Panel();
            btnLogout = new Button();
            label2 = new Label();
            panel2 = new Panel();
            panel9 = new Panel();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colAddToCart = new DataGridViewImageColumn();
            panel3 = new Panel();
            btnScan = new Button();
            label4 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            panel4 = new Panel();
            dgvCart = new DataGridView();
            colCId = new DataGridViewTextBoxColumn();
            colCname = new DataGridViewTextBoxColumn();
            colCprice = new DataGridViewTextBoxColumn();
            colCqty = new DataGridViewTextBoxColumn();
            colCtotal = new DataGridViewTextBoxColumn();
            colCremove = new DataGridViewImageColumn();
            panel8 = new Panel();
            panel7 = new Panel();
            lblChange = new Label();
            label11 = new Label();
            label10 = new Label();
            txtCashReceived = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtDiscount = new TextBox();
            lblDiscount = new Label();
            lblTotal = new Label();
            lblSubtotal = new Label();
            panel6 = new Panel();
            btnCheckout = new Button();
            btnClearCart = new Button();
            panel5 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 20, 35);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1361, 107);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(57, 216, 205);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            btnLogout.Location = new Point(1201, 34);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 42);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumSpringGreen;
            label2.Location = new Point(590, 32);
            label2.Name = "label2";
            label2.Size = new Size(211, 31);
            label2.TabIndex = 0;
            label2.Text = "Cashier Window";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(dgvProducts);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15, 15, 5, 15);
            panel2.Size = new Size(750, 907);
            panel2.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(44, 58, 106);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(15, 773);
            panel9.Name = "panel9";
            panel9.Size = new Size(730, 119);
            panel9.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.FromArgb(207, 217, 255);
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPrice, colStock, colAddToCart });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(15, 93);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(730, 799);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellClick += DgvProducts_CellClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colName
            // 
            colName.HeaderText = "Product Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colAddToCart
            // 
            colAddToCart.HeaderText = "Add to Cart";
            colAddToCart.Image = (Image)resources.GetObject("colAddToCart.Image");
            colAddToCart.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colAddToCart.MinimumWidth = 8;
            colAddToCart.Name = "colAddToCart";
            colAddToCart.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 58, 106);
            panel3.Controls.Add(btnScan);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtSearch);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(15, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(730, 78);
            panel3.TabIndex = 0;
            // 
            // btnScan
            // 
            btnScan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnScan.BackColor = Color.FromArgb(116, 220, 206);
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            btnScan.Location = new Point(582, 25);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(118, 33);
            btnScan.TabIndex = 3;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(36, 27);
            label4.Name = "label4";
            label4.Size = new Size(131, 27);
            label4.TabIndex = 2;
            label4.Text = "Product List";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(264, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(337, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(171, 31);
            txtSearch.TabIndex = 0;
            txtSearch.Click += TxtSearch_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvCart);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(750, 107);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15);
            panel4.Size = new Size(611, 907);
            panel4.TabIndex = 2;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.FromArgb(207, 217, 255);
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { colCId, colCname, colCprice, colCqty, colCtotal, colCremove });
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvCart.Location = new Point(85, 93);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 62;
            dgvCart.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCart.Size = new Size(238, 680);
            dgvCart.TabIndex = 4;
            dgvCart.CellBeginEdit += dgvCart_CellBeginEdit;
            dgvCart.CellClick += DgvCart_CellClick;
            dgvCart.CellEndEdit += dgvCart_CellEndEdit;
            // 
            // colCId
            // 
            colCId.HeaderText = "ID";
            colCId.MinimumWidth = 8;
            colCId.Name = "colCId";
            colCId.ReadOnly = true;
            colCId.Visible = false;
            // 
            // colCname
            // 
            colCname.HeaderText = "Product Name";
            colCname.MinimumWidth = 8;
            colCname.Name = "colCname";
            colCname.ReadOnly = true;
            // 
            // colCprice
            // 
            colCprice.HeaderText = "Price";
            colCprice.MinimumWidth = 8;
            colCprice.Name = "colCprice";
            colCprice.ReadOnly = true;
            // 
            // colCqty
            // 
            colCqty.HeaderText = "Quantity";
            colCqty.MinimumWidth = 8;
            colCqty.Name = "colCqty";
            // 
            // colCtotal
            // 
            colCtotal.HeaderText = "Total";
            colCtotal.MinimumWidth = 8;
            colCtotal.Name = "colCtotal";
            colCtotal.ReadOnly = true;
            // 
            // colCremove
            // 
            colCremove.HeaderText = "Remove";
            colCremove.Image = (Image)resources.GetObject("colCremove.Image");
            colCremove.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colCremove.MinimumWidth = 8;
            colCremove.Name = "colCremove";
            colCremove.ReadOnly = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(67, 83, 137);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(15, 93);
            panel8.Name = "panel8";
            panel8.Size = new Size(70, 680);
            panel8.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(67, 83, 137);
            panel7.Controls.Add(lblChange);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(txtCashReceived);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txtDiscount);
            panel7.Controls.Add(lblDiscount);
            panel7.Controls.Add(lblTotal);
            panel7.Controls.Add(lblSubtotal);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(323, 93);
            panel7.Name = "panel7";
            panel7.Size = new Size(273, 680);
            panel7.TabIndex = 2;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.BackColor = Color.FromArgb(67, 83, 137);
            lblChange.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            lblChange.ForeColor = SystemColors.ButtonHighlight;
            lblChange.Location = new Point(106, 527);
            lblChange.Margin = new Padding(4, 0, 4, 0);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(45, 22);
            lblChange.TabIndex = 13;
            lblChange.Text = "00.0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(67, 83, 137);
            label11.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(36, 478);
            label11.Name = "label11";
            label11.Size = new Size(86, 22);
            label11.TabIndex = 11;
            label11.Text = "CHANGE:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(67, 83, 137);
            label10.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(33, 363);
            label10.Name = "label10";
            label10.Size = new Size(175, 22);
            label10.TabIndex = 10;
            label10.Text = "AMOUNT RECEIVED:";
            // 
            // txtCashReceived
            // 
            txtCashReceived.Location = new Point(36, 402);
            txtCashReceived.Name = "txtCashReceived";
            txtCashReceived.Size = new Size(198, 31);
            txtCashReceived.TabIndex = 9;
            txtCashReceived.TextChanged += TxtCashReceived_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(36, 573);
            label9.Name = "label9";
            label9.Size = new Size(69, 22);
            label9.TabIndex = 8;
            label9.Text = "TOTAL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(67, 83, 137);
            label8.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(33, 239);
            label8.Name = "label8";
            label8.Size = new Size(111, 22);
            label8.TabIndex = 7;
            label8.Text = "TO DEDUCT:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(67, 83, 137);
            label7.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(33, 155);
            label7.Name = "label7";
            label7.Size = new Size(114, 22);
            label7.TabIndex = 6;
            label7.Text = "Discount (%)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(67, 83, 137);
            label5.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(33, 27);
            label5.Name = "label5";
            label5.Size = new Size(102, 22);
            label5.TabIndex = 5;
            label5.Text = "SUBTOTAL:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(36, 194);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(198, 31);
            txtDiscount.TabIndex = 4;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.BackColor = Color.FromArgb(67, 83, 137);
            lblDiscount.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            lblDiscount.ForeColor = SystemColors.ButtonHighlight;
            lblDiscount.Location = new Point(106, 288);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(45, 22);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "00.0";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            lblTotal.ForeColor = SystemColors.ButtonHighlight;
            lblTotal.Location = new Point(106, 617);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 22);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "00.0";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.FromArgb(67, 83, 137);
            lblSubtotal.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            lblSubtotal.ForeColor = SystemColors.ButtonHighlight;
            lblSubtotal.Location = new Point(106, 81);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(45, 22);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "00.0";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(44, 58, 106);
            panel6.Controls.Add(btnCheckout);
            panel6.Controls.Add(btnClearCart);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(15, 773);
            panel6.Name = "panel6";
            panel6.Size = new Size(581, 119);
            panel6.TabIndex = 1;
            // 
            // btnCheckout
            // 
            btnCheckout.Anchor = AnchorStyles.Right;
            btnCheckout.BackColor = Color.FromArgb(57, 216, 205);
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Popup;
            btnCheckout.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnCheckout.ForeColor = SystemColors.ActiveCaptionText;
            btnCheckout.Location = new Point(391, 35);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(138, 45);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.Anchor = AnchorStyles.Right;
            btnClearCart.BackColor = Color.FromArgb(57, 216, 205);
            btnClearCart.FlatAppearance.BorderSize = 0;
            btnClearCart.FlatStyle = FlatStyle.Popup;
            btnClearCart.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnClearCart.ForeColor = SystemColors.ActiveCaptionText;
            btnClearCart.Location = new Point(218, 35);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(138, 45);
            btnClearCart.TabIndex = 0;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(44, 58, 106);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(15, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(581, 78);
            panel5.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(29, 26);
            label3.Name = "label3";
            label3.Size = new Size(53, 27);
            label3.TabIndex = 0;
            label3.Text = "Cart";
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 1014);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierForm";
            Load += CashierForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvProducts;
        private Panel panel3;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Panel panel7;
        private Label lblTotal;
        private Label lblSubtotal;
        private Panel panel6;
        private Button btnCheckout;
        private Button btnClearCart;
        private Label label3;
        private Button btnLogout;
        private DataGridView dgvCart;
        private Panel panel8;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewImageColumn colAddToCart;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Button btnScan;
        private Label label11;
        private Label label10;
        private TextBox txtCashReceived;
        private Label lblChange;
        private DataGridViewTextBoxColumn colCId;
        private DataGridViewTextBoxColumn colCname;
        private DataGridViewTextBoxColumn colCprice;
        private DataGridViewTextBoxColumn colCqty;
        private DataGridViewTextBoxColumn colCtotal;
        private DataGridViewImageColumn colCremove;
        private Panel panel9;
    }
}