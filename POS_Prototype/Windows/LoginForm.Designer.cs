namespace POS_Prototype
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            userTextBox = new TextBox();
            passTextBox = new TextBox();
            btnClose = new Button();
            btnLogin = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userTextBox
            // 
            userTextBox.BackColor = SystemColors.GradientInactiveCaption;
            userTextBox.BorderStyle = BorderStyle.FixedSingle;
            userTextBox.Font = new Font("Microsoft YaHei UI", 9F);
            userTextBox.Location = new Point(443, 195);
            userTextBox.Name = "userTextBox";
            userTextBox.PlaceholderText = "Username";
            userTextBox.Size = new Size(260, 30);
            userTextBox.TabIndex = 0;
            userTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passTextBox
            // 
            passTextBox.BackColor = SystemColors.GradientInactiveCaption;
            passTextBox.BorderStyle = BorderStyle.FixedSingle;
            passTextBox.Font = new Font("Microsoft YaHei UI", 9F);
            passTextBox.Location = new Point(443, 249);
            passTextBox.Name = "passTextBox";
            passTextBox.PlaceholderText = "Password";
            passTextBox.Size = new Size(260, 30);
            passTextBox.TabIndex = 1;
            passTextBox.TextAlign = HorizontalAlignment.Center;
            passTextBox.UseSystemPasswordChar = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SteelBlue;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(443, 326);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(104, 34);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(599, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 36, 62);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 450);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(71, 277);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 1;
            label1.Text = "Self-proclaimed POS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(492, 109);
            label2.Name = "label2";
            label2.Size = new Size(151, 22);
            label2.TabIndex = 5;
            label2.Text = "Login an Account";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(userTextBox);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(btnClose);
            Controls.Add(passTextBox);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTextBox;
        private TextBox passTextBox;
        private Button btnClose;
        private Button btnLogin;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
