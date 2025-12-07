namespace POS_Prototype.Controls.AdminControls
{
    partial class ManageUsersControl
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
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            dgvUsers = new DataGridView();
            colUsername = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colLastLogin = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnRemoveUser = new Button();
            btnEditUser = new Button();
            btnCreateUser = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1086, 78);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(38, 27);
            label2.Name = "label2";
            label2.Size = new Size(68, 27);
            label2.TabIndex = 2;
            label2.Text = "Users";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(747, 31);
            label1.Name = "label1";
            label1.Size = new Size(71, 24);
            label1.TabIndex = 1;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(824, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 31);
            txtSearch.TabIndex = 0;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colUsername, colPassword, colRole, colLastLogin });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 78);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1086, 565);
            dgvUsers.TabIndex = 2;
            dgvUsers.CellFormatting += dataGridViewUsers_CellFormatting;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 8;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colPassword
            // 
            colPassword.HeaderText = "Password";
            colPassword.MinimumWidth = 8;
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            // 
            // colRole
            // 
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 8;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            // 
            // colLastLogin
            // 
            colLastLogin.HeaderText = "Last Login";
            colLastLogin.MinimumWidth = 8;
            colLastLogin.Name = "colLastLogin";
            colLastLogin.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRemoveUser);
            panel1.Controls.Add(btnEditUser);
            panel1.Controls.Add(btnCreateUser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 543);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 100);
            panel1.TabIndex = 3;
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveUser.BackColor = Color.SteelBlue;
            btnRemoveUser.FlatAppearance.BorderSize = 0;
            btnRemoveUser.FlatStyle = FlatStyle.Flat;
            btnRemoveUser.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnRemoveUser.ForeColor = SystemColors.ButtonHighlight;
            btnRemoveUser.Location = new Point(902, 30);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(134, 42);
            btnRemoveUser.TabIndex = 2;
            btnRemoveUser.Text = "Remove";
            btnRemoveUser.UseVisualStyleBackColor = false;
            btnRemoveUser.Click += btnRemoveUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditUser.BackColor = Color.SteelBlue;
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnEditUser.ForeColor = SystemColors.ButtonHighlight;
            btnEditUser.Location = new Point(732, 30);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(134, 42);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateUser.BackColor = Color.SteelBlue;
            btnCreateUser.FlatAppearance.BorderSize = 0;
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnCreateUser.ForeColor = SystemColors.ButtonHighlight;
            btnCreateUser.Location = new Point(561, 30);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(134, 42);
            btnCreateUser.TabIndex = 0;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // ManageUsersControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dgvUsers);
            Controls.Add(panel2);
            Name = "ManageUsersControl";
            Size = new Size(1086, 643);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox txtSearch;
        private DataGridView dgvUsers;
        private Panel panel1;
        private Button btnRemoveUser;
        private Button btnEditUser;
        private Button btnCreateUser;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colPassword;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colLastLogin;
    }
}
