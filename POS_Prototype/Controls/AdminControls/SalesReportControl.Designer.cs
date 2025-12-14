namespace POS_Prototype.Controls.AdminControls
{
    partial class SalesReportControl
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
            topPanel = new Panel();
            label11 = new Label();
            label10 = new Label();
            btnGenerateReport = new Button();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            dgvItemSummary = new DataGridView();
            panel6 = new Panel();
            label9 = new Label();
            panel3 = new Panel();
            dgvSales = new DataGridView();
            panel5 = new Panel();
            label8 = new Label();
            topPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemSummary).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(15, 20, 35);
            topPanel.Controls.Add(label11);
            topPanel.Controls.Add(label10);
            topPanel.Controls.Add(btnGenerateReport);
            topPanel.Controls.Add(dtpTo);
            topPanel.Controls.Add(dtpFrom);
            topPanel.Controls.Add(label1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1131, 152);
            topPanel.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(339, 92);
            label11.Name = "label11";
            label11.Size = new Size(35, 25);
            label11.TabIndex = 7;
            label11.Text = "To";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(25, 93);
            label10.Name = "label10";
            label10.Size = new Size(60, 25);
            label10.TabIndex = 6;
            label10.Text = "From";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerateReport.BackColor = Color.FromArgb(57, 216, 205);
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.Location = new Point(926, 87);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(176, 35);
            btnGenerateReport.TabIndex = 5;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dtpTo
            // 
            dtpTo.CustomFormat = "MM/dd/yyyy";
            dtpTo.Location = new Point(381, 89);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(168, 31);
            dtpTo.TabIndex = 4;
            // 
            // dtpFrom
            // 
            dtpFrom.CustomFormat = "";
            dtpFrom.Location = new Point(98, 91);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(173, 31);
            dtpFrom.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.MediumSpringGreen;
            label1.Location = new Point(507, 26);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 2;
            label1.Text = "Sales Report";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 83, 137);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(713, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 747);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(32, 53);
            label7.Name = "label7";
            label7.Size = new Size(140, 27);
            label7.TabIndex = 5;
            label7.Text = "Transactions";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(32, 369);
            label6.Name = "label6";
            label6.Size = new Size(152, 27);
            label6.TabIndex = 4;
            label6.Text = "Total Change:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(32, 165);
            label5.Name = "label5";
            label5.Size = new Size(226, 27);
            label5.TabIndex = 3;
            label5.Text = "Total Cash Tendered:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(32, 542);
            label4.Name = "label4";
            label4.Size = new Size(159, 27);
            label4.TabIndex = 2;
            label4.Text = "Gross Subtotal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(32, 270);
            label3.Name = "label3";
            label3.Size = new Size(159, 27);
            label3.TabIndex = 1;
            label3.Text = "Total Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(32, 657);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 0;
            label2.Text = "Total Sales";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 747);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvItemSummary);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 429);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 15, 15, 0);
            panel4.Size = new Size(713, 318);
            panel4.TabIndex = 1;
            // 
            // dgvItemSummary
            // 
            dgvItemSummary.AllowUserToAddRows = false;
            dgvItemSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItemSummary.BackgroundColor = Color.FromArgb(207, 217, 255);
            dgvItemSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemSummary.Dock = DockStyle.Fill;
            dgvItemSummary.Location = new Point(0, 59);
            dgvItemSummary.Name = "dgvItemSummary";
            dgvItemSummary.RowHeadersWidth = 62;
            dgvItemSummary.Size = new Size(698, 259);
            dgvItemSummary.TabIndex = 1;
            dgvItemSummary.CellStateChanged += dgvItemSummary_CellStateChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.MediumSpringGreen;
            panel6.Controls.Add(label9);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(698, 44);
            panel6.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label9.Location = new Point(20, 10);
            label9.Name = "label9";
            label9.Size = new Size(107, 25);
            label9.TabIndex = 0;
            label9.Text = "Items Sold";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvSales);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 15, 15, 0);
            panel3.Size = new Size(713, 429);
            panel3.TabIndex = 0;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.BackgroundColor = Color.FromArgb(207, 217, 255);
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvSales.DefaultCellStyle = dataGridViewCellStyle1;
            dgvSales.Dock = DockStyle.Fill;
            dgvSales.Location = new Point(0, 57);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 62;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(698, 372);
            dgvSales.TabIndex = 1;
            dgvSales.CellClick += dgvSales_CellClick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumSpringGreen;
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(698, 42);
            panel5.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label8.Location = new Point(21, 9);
            label8.Name = "label8";
            label8.Size = new Size(57, 25);
            label8.TabIndex = 0;
            label8.Text = "Sales";
            // 
            // SalesReportControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            Name = "SalesReportControl";
            Size = new Size(1131, 899);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItemSummary).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvItemSummary;
        private Panel panel6;
        private DataGridView dgvSales;
        private Panel panel5;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label10;
        private Button btnGenerateReport;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
    }
}
