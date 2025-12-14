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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditProductForm));
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnScan = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtBarcode = new TextBox();
            picPreview = new PictureBox();
            cBoxCamPicker = new ComboBox();
            pbOverlay = new PictureBox();
            lblOverlay = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOverlay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 20, 35);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 70);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            label5.ForeColor = Color.MediumSpringGreen;
            label5.Location = new Point(405, 24);
            label5.Name = "label5";
            label5.Size = new Size(136, 22);
            label5.TabIndex = 0;
            label5.Text = "Product Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(58, 106);
            label1.Name = "label1";
            label1.Size = new Size(133, 22);
            label1.TabIndex = 1;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(58, 203);
            label2.Name = "label2";
            label2.Size = new Size(55, 22);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(58, 300);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 4;
            label4.Text = "Barcode:";
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.SteelBlue;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            btnScan.ForeColor = SystemColors.ButtonHighlight;
            btnScan.Location = new Point(278, 331);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(112, 34);
            btnScan.TabIndex = 5;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(58, 417);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(32, 212, 148);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(214, 417);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft YaHei UI", 9F);
            txtName.Location = new Point(58, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 30);
            txtName.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Microsoft YaHei UI", 9F);
            txtPrice.Location = new Point(58, 234);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(205, 30);
            txtPrice.TabIndex = 9;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Microsoft YaHei UI", 9F);
            txtBarcode.Location = new Point(58, 331);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(205, 30);
            txtBarcode.TabIndex = 11;
            // 
            // picPreview
            // 
            picPreview.Location = new Point(467, 166);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(422, 302);
            picPreview.TabIndex = 12;
            picPreview.TabStop = false;
            // 
            // cBoxCamPicker
            // 
            cBoxCamPicker.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxCamPicker.FormattingEnabled = true;
            cBoxCamPicker.Location = new Point(672, 106);
            cBoxCamPicker.Name = "cBoxCamPicker";
            cBoxCamPicker.Size = new Size(217, 29);
            cBoxCamPicker.TabIndex = 13;
            // 
            // pbOverlay
            // 
            pbOverlay.Image = (Image)resources.GetObject("pbOverlay.Image");
            pbOverlay.Location = new Point(567, 203);
            pbOverlay.Name = "pbOverlay";
            pbOverlay.Size = new Size(230, 189);
            pbOverlay.SizeMode = PictureBoxSizeMode.Zoom;
            pbOverlay.TabIndex = 14;
            pbOverlay.TabStop = false;
            // 
            // lblOverlay
            // 
            lblOverlay.AutoSize = true;
            lblOverlay.Location = new Point(633, 395);
            lblOverlay.Name = "lblOverlay";
            lblOverlay.Size = new Size(95, 25);
            lblOverlay.TabIndex = 15;
            lblOverlay.Text = "Scan Here:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(467, 110);
            label3.Name = "label3";
            label3.Size = new Size(115, 22);
            label3.TabIndex = 16;
            label3.Text = "Pick Camera:";
            // 
            // AddEditProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 496);
            Controls.Add(label3);
            Controls.Add(cBoxCamPicker);
            Controls.Add(lblOverlay);
            Controls.Add(pbOverlay);
            Controls.Add(picPreview);
            Controls.Add(txtBarcode);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnScan);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditProductForm";
            Load += AddEditProductForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOverlay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btnScan;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtBarcode;
        private PictureBox picPreview;
        private ComboBox cBoxCamPicker;
        private PictureBox pbOverlay;
        private Label lblOverlay;
        private Label label3;
    }
}