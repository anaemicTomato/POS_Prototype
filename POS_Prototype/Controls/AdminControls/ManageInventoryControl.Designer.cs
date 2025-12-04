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
            panel1 = new Panel();
            txtSearch = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvInventory = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colStocks = new DataGridViewTextBoxColumn();
            colBarcode = new DataGridViewTextBoxColumn();
            colAddStock = new DataGridViewButtonColumn();
            colMinusStock = new DataGridViewButtonColumn();
            colCustomStock = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 109);
            panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(746, 62);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(177, 31);
            txtSearch.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(672, 65);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 1;
            label2.Text = "Search:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(400, 19);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management";
            // 
            // dgvInventory
            // 
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colStocks, colBarcode, colAddStock, colMinusStock, colCustomStock });
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(0, 109);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 62;
            dgvInventory.Size = new Size(969, 440);
            dgvInventory.TabIndex = 1;
            dgvInventory.CellClick += dgvInventory_CellClick;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            dgvInventory.CellEndEdit += dgvInventory_CellEndEdit;
            // 
            // colId
            // 
            colId.HeaderText = "Product ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colName
            // 
            colName.HeaderText = "Product Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            // 
            // colStocks
            // 
            colStocks.HeaderText = "Stocks";
            colStocks.MinimumWidth = 8;
            colStocks.Name = "colStocks";
            // 
            // colBarcode
            // 
            colBarcode.HeaderText = "Barcode";
            colBarcode.MinimumWidth = 8;
            colBarcode.Name = "colBarcode";
            // 
            // colAddStock
            // 
            colAddStock.HeaderText = "";
            colAddStock.MinimumWidth = 8;
            colAddStock.Name = "colAddStock";
            colAddStock.Text = "Increase Stock";
            colAddStock.UseColumnTextForButtonValue = true;
            // 
            // colMinusStock
            // 
            colMinusStock.HeaderText = "";
            colMinusStock.MinimumWidth = 8;
            colMinusStock.Name = "colMinusStock";
            colMinusStock.Text = "Decrease Stock";
            colMinusStock.UseColumnTextForButtonValue = true;
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
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colStocks;
        private DataGridViewTextBoxColumn colBarcode;
        private DataGridViewButtonColumn colAddStock;
        private DataGridViewButtonColumn colMinusStock;
        private DataGridViewTextBoxColumn colCustomStock;
        private TextBox txtSearch;
        private Label label2;
    }
}
