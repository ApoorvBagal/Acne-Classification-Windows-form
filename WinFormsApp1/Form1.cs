using System;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Windows.Forms;
using static WinFormsApp1.Form2;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        } 
        private void button1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All Files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (image1.Image != null)
            {
                try
                {
                    // Save the image to a temporary file
                    string tempImagePath = Path.GetTempFileName() + ".jpg";
                    image1.Image.Save(tempImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                    SendImageToServer(tempImagePath);
                    File.Delete(tempImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while sending the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        internal void SendImageToServer(string imagePath)
        {
            using (var client = new HttpClient())
            {
                string serverUrl = "https://f6e8-34-87-182-235.ngrok-free.app/upload";

                MultipartFormDataContent form = new MultipartFormDataContent();

                // Add the image file to the form data
                ByteArrayContent fileContent = new ByteArrayContent(File.ReadAllBytes(imagePath));
                fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "image",
                    FileName = Path.GetFileName(imagePath)
                };
                form.Add(fileContent);

                HttpResponseMessage response = client.PostAsync(serverUrl, form).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = response.Content.ReadAsStringAsync().Result;
                    MessageBox.Show(responseContent, "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
