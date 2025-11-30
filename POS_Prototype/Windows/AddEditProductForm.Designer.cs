namespace POS_Prototype.Windows
{
    partial class AddEditProductForm
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
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnScan = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            txtBarcode = new TextBox();
            picPreview = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 57);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 19);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 0;
            label5.Text = "Product Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 108);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 169);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 232);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 291);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 4;
            label4.Text = "Barcode:";
            // 
            // btnScan
            // 
            btnScan.Location = new Point(383, 289);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(112, 34);
            btnScan.TabIndex = 5;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(131, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(317, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 31);
            txtName.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(162, 169);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(205, 31);
            txtPrice.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(162, 232);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(205, 31);
            txtStock.TabIndex = 10;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(162, 291);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(205, 31);
            txtBarcode.TabIndex = 11;
            // 
            // picPreview
            // 
            picPreview.Location = new Point(529, 108);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(323, 302);
            picPreview.TabIndex = 12;
            picPreview.TabStop = false;
            // 
            // AddEditProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 496);
            Controls.Add(picPreview);
            Controls.Add(txtBarcode);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnScan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddEditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditProductForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnScan;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private TextBox txtBarcode;
        private PictureBox picPreview;
    }
}