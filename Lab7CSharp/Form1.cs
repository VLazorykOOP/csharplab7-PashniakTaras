using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg|GIF Image|*.gif";
                saveFileDialog.Title = "Save an Image File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string extension = System.IO.Path.GetExtension(saveFileDialog.FileName);

                    if (extension != null)
                    {
                        ImageFormat format;
                        switch (extension.ToLower())
                        {
                            case ".jpg":
                            case ".jpeg":
                                format = ImageFormat.Jpeg;
                                break;
                            case ".bmp":
                                format = ImageFormat.Bmp;
                                break;
                            case ".gif":
                                format = ImageFormat.Gif;
                                break;
                            default:
                                format = ImageFormat.Png;
                                break;
                        }
                        pictureBox.Image.Save(saveFileDialog.FileName, format);
                    }
                }
            }
            else
            {
                MessageBox.Show("No image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvertToMonochrome_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Bitmap originalImage = new Bitmap(pictureBox.Image);
                Bitmap monochromeImage = new Bitmap(originalImage.Width, originalImage.Height);

                for (int x = 0; x < originalImage.Width; x++)
                {
                    for (int y = 0; y < originalImage.Height; y++)
                    {
                        Color pixelColor = originalImage.GetPixel(x, y);
                        int averageColor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        Color newColor = Color.FromArgb(averageColor, averageColor, averageColor);
                        monochromeImage.SetPixel(x, y, newColor);
                    }
                }

                pictureBox.Image = monochromeImage;
            }
            else
            {
                MessageBox.Show("No image to convert.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
