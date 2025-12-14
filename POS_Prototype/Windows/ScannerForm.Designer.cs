namespace POS_Prototype.Windows
{

	public partial class ScannerForm
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
			this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxCamera
			// 
			this.pictureBoxCamera.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxCamera.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxCamera.Name = "pictureBoxCamera";
			this.pictureBoxCamera.Size = new System.Drawing.Size(424, 324);
			this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxCamera.TabIndex = 0;
			this.pictureBoxCamera.TabStop = false;
			// 
			// ScannerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 324);
			this.Controls.Add(this.pictureBoxCamera);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ScannerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Scanner";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScannerForm_FormClosing);
			this.Load += new System.EventHandler(this.ScannerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

	
		private System.Windows.Forms.PictureBox pictureBoxCamera;
	}
}