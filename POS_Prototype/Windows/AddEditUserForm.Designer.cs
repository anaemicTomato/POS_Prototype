namespace POS_Prototype.Windows
{
    partial class AddEditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUserForm));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cbRole = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            txtConfirmPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(563, 96);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(211, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(563, 151);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 31);
            txtPassword.TabIndex = 1;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(563, 285);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(211, 33);
            cbRole.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(706, 420);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(534, 420);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(563, 215);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(211, 31);
            txtConfirmPass.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 96);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 6;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 151);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 215);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 8;
            label3.Text = "Confirm Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 285);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 9;
            label4.Text = "Role:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 266);
            label5.Name = "label5";
            label5.Size = new Size(189, 25);
            label5.TabIndex = 11;
            label5.Text = "User Creation Window";
            // 
            // AddEditUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 500);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmPass);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "AddEditUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditUserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cbRole;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtConfirmPass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
    }
}