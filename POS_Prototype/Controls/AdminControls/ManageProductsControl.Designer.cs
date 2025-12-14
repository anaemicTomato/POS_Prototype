namespace POS_Prototype.Controls.AdminControls
{
    partial class ManageProductsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProductsControl));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colBarcode = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 20, 35);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(851, 150);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumSpringGreen;
            label2.Location = new Point(326, 22);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 3;
            label2.Text = "Product Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(33, 103);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 2;
            label1.Text = "Search:";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(57, 216, 205);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(656, 85);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(157, 46);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(116, 100);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 30);
            txtSearch.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.FromArgb(207, 217, 255);
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPrice, colBarcode, colEdit, colDelete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle5;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EditMode = DataGridViewEditMode.EditOnF2;
            dgvProducts.Location = new Point(0, 150);
            dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvProducts.Size = new Size(851, 369);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
            dgvProducts.CellStateChanged += dgvInventory_CellStateChanged;
            // 
            // colId
            // 
            colId.HeaderText = "Product ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
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
            // colBarcode
            // 
            colBarcode.HeaderText = "Barcode";
            colBarcode.MinimumWidth = 8;
            colBarcode.Name = "colBarcode";
            colBarcode.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit Product";
            colEdit.Image = (Image)resources.GetObject("colEdit.Image");
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.Resizable = DataGridViewTriState.True;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Remove Product";
            colDelete.Image = (Image)resources.GetObject("colDelete.Image");
            colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.Resizable = DataGridViewTriState.True;
            // 
            // ManageProductsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvProducts);
            Controls.Add(panel1);
            Name = "ManageProductsControl";
            Size = new Size(851, 519);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private TextBox txtSearch;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colBarcode;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
    }
}
