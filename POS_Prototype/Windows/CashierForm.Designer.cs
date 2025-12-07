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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtCash = new TextBox();
            lblChange = new Label();
            lblTotal = new Label();
            lblVAT = new Label();
            lblSubtotal = new Label();
            btnAddToCart = new Button();
            numQty = new NumericUpDown();
            txtSearch = new TextBox();
            dgvCart = new DataGridView();
            btnComplete = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            Search = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 88, 110);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 48);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(220, 200, 148);
            label2.Location = new Point(12, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 2;
            label2.Text = "Cashier";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtCash);
            panel2.Controls.Add(lblChange);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblVAT);
            panel2.Controls.Add(lblSubtotal);
            panel2.Controls.Add(btnAddToCart);
            panel2.Controls.Add(numQty);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(dgvCart);
            panel2.Controls.Add(btnComplete);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Search);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 48);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(709, 457);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Location = new Point(244, 428);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 24;
            label7.Text = "Change";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(603, 238);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 23;
            label6.Text = "TOTAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(603, 205);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 22;
            label5.Text = "VAT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(603, 174);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 21;
            label1.Text = "SUBTOTAL";
            // 
            // txtCash
            // 
            txtCash.Location = new Point(120, 422);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(100, 23);
            txtCash.TabIndex = 20;
            txtCash.TextChanged += txtCash_TextChanged;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.BackColor = Color.LawnGreen;
            lblChange.Location = new Point(298, 428);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(13, 15);
            lblChange.TabIndex = 19;
            lblChange.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.LawnGreen;
            lblTotal.Location = new Point(670, 238);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 15);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "0";
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.BackColor = Color.LawnGreen;
            lblVAT.Location = new Point(670, 205);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(13, 15);
            lblVAT.TabIndex = 17;
            lblVAT.Text = "0";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.LawnGreen;
            lblSubtotal.Location = new Point(670, 174);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(13, 15);
            lblSubtotal.TabIndex = 16;
            lblSubtotal.Text = "0";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(233, 84);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(88, 23);
            btnAddToCart.TabIndex = 15;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // numQty
            // 
            numQty.Location = new Point(164, 84);
            numQty.Name = "numQty";
            numQty.Size = new Size(45, 23);
            numQty.TabIndex = 14;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(153, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(147, 23);
            txtSearch.TabIndex = 13;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(105, 124);
            dgvCart.Name = "dgvCart";
            dgvCart.Size = new Size(492, 284);
            dgvCart.TabIndex = 12;
            dgvCart.CellClick += dgvCart_CellClick;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(537, 424);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(75, 23);
            btnComplete.TabIndex = 11;
            btnComplete.Text = "Confirm";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 425);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(383, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 112);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(306, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Scan";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 84);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Quantity";
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(105, 44);
            Search.Name = "Search";
            Search.Size = new Size(42, 15);
            Search.TabIndex = 2;
            Search.Text = "Search";
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 505);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "CashierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            //        ((System.ComponentModel.ISupportInitialize)this.numQty).EndInit();
            //          ((System.ComponentModel.ISupportInitialize)this.dgvCart).EndInit();
            //         ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private Label Search;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button2;
        private Button btnComplete;
        private DataGridView dgvCart;
        private TextBox txtSearch;
        private NumericUpDown numQty;
        private Button btnAddToCart;
        private Label lblSubtotal;
        private Label lblVAT;
        private Label lblTotal;
        private Label lblChange;
        private TextBox txtCash;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label7;
    }
}