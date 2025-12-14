using System;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading.Tasks;
using ZXing.Windows.Compatibility;
using ZXing;

namespace POS_Prototype.Windows
{

	public partial class ScannerForm : Form
	{

		public event Action<string> BarcodeScanned;

		private FilterInfoCollection videoDevices;
		private VideoCaptureDevice videoSource;


		private BarcodeReader barcodeReader;


		private System.Windows.Forms.Timer scanDelayTimer;
		private int scanAttempts = 0;

	


		public ScannerForm()
		{
			InitializeComponent();


			barcodeReader = new BarcodeReader { AutoRotate = true };
		}

		private void ScannerForm_Load(object sender, EventArgs e)
		{
			StartCameraAndScanner();
		}


		private void StopCamera()
		{
			scanDelayTimer?.Stop();

			if (videoSource != null && videoSource.IsRunning)
			{
				videoSource.SignalToStop();

				Task.Run(() =>
				{
					videoSource.WaitForStop();
					videoSource = null;

					if (pictureBoxCamera.IsHandleCreated)
					{
						pictureBoxCamera.Invoke(new MethodInvoker(delegate
						{
							if (pictureBoxCamera.Image != null)
							{
								pictureBoxCamera.Image.Dispose();
								pictureBoxCamera.Image = null;
							}
						}));
					}
				});
			}
			else
			{
				if (pictureBoxCamera.Image != null)
				{
					pictureBoxCamera.Image.Dispose();
					pictureBoxCamera.Image = null;
				}
			}
		}

		private void StartCameraAndScanner()
		{
			try
			{
				videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

				if (videoDevices.Count == 0)
				{
					MessageBox.Show("No video input devices found. Cannot start scanner.", "Error");
					this.Close();
					return;
				}


				videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);


				videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
				videoSource.Start();


				scanDelayTimer = new System.Windows.Forms.Timer();
				scanDelayTimer.Interval = 500;
				scanDelayTimer.Tick += ScanningTimer_Tick;
				scanDelayTimer.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error initializing camera: {ex.Message}", "Camera Error");
				this.Close();
			}
		}

		private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			if (pictureBoxCamera.InvokeRequired)
			{
				pictureBoxCamera.Invoke(new MethodInvoker(delegate
				{
					if (pictureBoxCamera.Image != null)
						pictureBoxCamera.Image.Dispose();
					pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
				}));
			}
			else
			{
				if (pictureBoxCamera.Image != null)
					pictureBoxCamera.Image.Dispose();
				pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
			}
		}

		private void ScanningTimer_Tick(object sender, EventArgs e)
		{
			if (pictureBoxCamera.Image == null) return;


			Bitmap currentFrame = null;
			try
			{
				if (pictureBoxCamera.InvokeRequired)
				{
					pictureBoxCamera.Invoke(new MethodInvoker(delegate
					{
						currentFrame = (Bitmap)pictureBoxCamera.Image.Clone();
					}));
				}
				else
				{
					currentFrame = (Bitmap)pictureBoxCamera.Image.Clone();
				}
			}
			catch (Exception)
			{
				return;
			}

			string scannedBarcode = AttemptToScanFrame(currentFrame);

			if (!string.IsNullOrEmpty(scannedBarcode))
			{
				

				BarcodeScanned?.Invoke(scannedBarcode);

				SystemSounds.Beep.Play();

				StopCamera();
				this.Close();
			}


			currentFrame?.Dispose();

			scanAttempts++;
			this.Text = $"Scanning... (Attempt: {scanAttempts})";
		}


		private string AttemptToScanFrame(Bitmap frame)
		{
			if (frame == null) return null;

			try
			{
				Result result = barcodeReader.Decode(frame);

				if (result != null)
				{
					return result.Text;
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		private void ScannerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			StopCamera();
		}
	}
}