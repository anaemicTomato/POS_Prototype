using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace POS_Prototype.Windows
{
    public partial class AddEditProductForm : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private readonly string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "pos.db");
        private readonly string connectionString;
        private int? productId = null; // nullable, only set in edit mode


        // ADD MODE constructor
        public AddEditProductForm()
        {
            InitializeComponent();
            this.Text = "Add Product";

            // Build connection string
            connectionString = $"Data Source={dbPath}";
        }

        // EDIT MODE constructor
        public AddEditProductForm(int id)
        {
            InitializeComponent();
            this.Text = "Edit Product";
            productId = id;

            // Build connection string
            connectionString = $"Data Source={dbPath}";

            LoadProduct(); // populate fields for editing
        }

        private void AddEditProductForm_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No webcam detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load all webcam names into ComboBox
            foreach (FilterInfo device in videoDevices)
            {
                cBoxCamPicker.Items.Add(device.Name);
            }

            // Auto-select first webcam
            cBoxCamPicker.SelectedIndex = 0;
        }
        // Load product for edit mode
        private void LoadProduct()
        {
            if (!File.Exists(dbPath))
            {
                MessageBox.Show($"Database not found at:\n{dbPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var con = new SqliteConnection(connectionString))
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Products WHERE Id = $id";
                    cmd.Parameters.AddWithValue("$id", productId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtPrice.Text = reader["Price"].ToString();
                            txtBarcode.Text = reader["Barcode"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load product:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // i-validate sa ang input bruv
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price!");
                return;
            }

            if (!File.Exists(dbPath))
            {
                MessageBox.Show($"Database not found at:\n{dbPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var con = new SqliteConnection(connectionString))
                {
                    con.Open();
                    var cmd = con.CreateCommand();

                    if (productId == null) // ADD mode
                    {
                        cmd.CommandText = @"INSERT INTO Products (Name, Price, Barcode)
                                    VALUES ($name, $price, $barcode)";
                    }
                    else // EDIT mode
                    {
                        cmd.CommandText = @"UPDATE Products SET 
                                    Name=$name, 
                                    Price=$price,
                                    Barcode=$barcode
                                    WHERE Id=$id";
                        cmd.Parameters.AddWithValue("$id", productId.Value);
                    }

                    cmd.Parameters.AddWithValue("$name", txtName.Text);
                    cmd.Parameters.AddWithValue("$price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("$barcode", txtBarcode.Text);

                    cmd.ExecuteNonQuery();
                }

                this.Close(); // close the form after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save product:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBoxCamPicker.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a webcam first.", "Error");
                    return;
                }

                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                // Get selected webcam index
                int selectedIndex = cBoxCamPicker.SelectedIndex;

                videoSource = new VideoCaptureDevice(videoDevices[selectedIndex].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();

                MessageBox.Show("Point a barcode at the camera...", "Scanning Started");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing camera:\n{ex.Message}");
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

                // --- Show webcam preview ---
                if (picPreview.Image != null)
                    picPreview.Image.Dispose();

                picPreview.Image = (Bitmap)bitmap.Clone();

                // --- Barcode reader ---
                var reader = new ZXing.Windows.Compatibility.BarcodeReader();
                var result = reader.Decode(bitmap);

                // Dispose bitmap after decoding
                bitmap.Dispose();

                if (result != null)
                {
                    Invoke(new Action(() =>
                    {
                        txtBarcode.Text = result.Text;

                        MessageBox.Show($"Barcode detected: {result.Text}");

                        // Stop camera safely
                        if (videoSource != null && videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                        }

                        videoSource = null;
                    }));
                }
            }
            catch
            {
                // Ignore frame processing errors
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
            base.OnFormClosing(e);
        }

        

        //Nigga kulang kag Function para sa btnScan Nigga
        //Daun wala pa nimo na test tanan Nigga tang ina mo.
    }
}
