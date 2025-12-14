namespace POS_Prototype.Controls.AdminControls
{
    partial class ManageInventoryControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInventoryControl));
            panel1 = new Panel();
            txtSearch = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvInventory = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colStocks = new DataGridViewTextBoxColumn();
            colBarcode = new DataGridViewTextBoxColumn();
            colAddStock = new DataGridViewImageColumn();
            colMinusStock = new DataGridViewImageColumn();
            colCustomStock = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 20, 35);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 150);
            panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(108, 101);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(192, 31);
            txtSearch.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(25, 105);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Search:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSpringGreen;
            label1.Location = new Point(371, 25);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.FromArgb(207, 217, 255);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colStocks, colBarcode, colAddStock, colMinusStock, colCustomStock });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.EditMode = DataGridViewEditMode.EditOnF2;
            dgvInventory.Location = new Point(0, 150);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 62;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvInventory.Size = new Size(969, 399);
            dgvInventory.TabIndex = 1;
            dgvInventory.CellClick += dgvInventory_CellClick;
            dgvInventory.CellEndEdit += dgvInventory_CellEndEdit;
            dgvInventory.CellFormatting += dgvInventory_CellFormatting;
            dgvInventory.CellStateChanged += dgvInventory_CellStateChanged;
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
            colName.HeaderText = "Product Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colStocks
            // 
            colStocks.HeaderText = "Stocks";
            colStocks.MinimumWidth = 8;
            colStocks.Name = "colStocks";
            colStocks.ReadOnly = true;
            // 
            // colBarcode
            // 
            colBarcode.HeaderText = "Barcode";
            colBarcode.MinimumWidth = 8;
            colBarcode.Name = "colBarcode";
            colBarcode.ReadOnly = true;
            // 
            // colAddStock
            // 
            colAddStock.HeaderText = "Increase Stock";
            colAddStock.Image = (Image)resources.GetObject("colAddStock.Image");
            colAddStock.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colAddStock.MinimumWidth = 8;
            colAddStock.Name = "colAddStock";
            colAddStock.Resizable = DataGridViewTriState.True;
            // 
            // colMinusStock
            // 
            colMinusStock.HeaderText = "Decrease Stock";
            colMinusStock.Image = (Image)resources.GetObject("colMinusStock.Image");
            colMinusStock.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colMinusStock.MinimumWidth = 8;
            colMinusStock.Name = "colMinusStock";
            colMinusStock.Resizable = DataGridViewTriState.True;
            // 
            // colCustomStock
            // 
            colCustomStock.HeaderText = "New Stock";
            colCustomStock.MinimumWidth = 8;
            colCustomStock.Name = "colCustomStock";
            // 
            // ManageInventoryControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvInventory);
            Controls.Add(panel1);
            Name = "ManageInventoryControl";
            Size = new Size(969, 549);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvInventory;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colStocks;
        private DataGridViewTextBoxColumn colBarcode;
        private DataGridViewImageColumn colAddStock;
        private DataGridViewImageColumn colMinusStock;
        private DataGridViewTextBoxColumn colCustomStock;
    }
}
