using ImageProcess2;
using System.Diagnostics;
using System.Drawing;

namespace Coins_Activity
{
    public partial class Form1 : Form
    {
        Bitmap? loaded;
        Bitmap? processed;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Open an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }

            Bitmap loadedImage = (Bitmap)pictureBox1.Image;
            processed = new Bitmap(loadedImage.Width, loadedImage.Height);  

   
            BitmapFilter.Binary(loadedImage, processed, 200);

            Coins.CountCoin(processed, ref lblCount, ref lblTotal);

            pictureBox1.Image = processed;  
        }




    }
}
