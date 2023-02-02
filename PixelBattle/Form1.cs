using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PixelBattle
{
    public partial class Form1 : Form
    {
        public Bitmap image = null;
        public string IMGPath = null;
        public string FileSelectionFilter = "PNG images|*.png"; 
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = FileSelectionFilter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IMGPath = openFileDialog1.FileName;
                try
                {
                    image = new Bitmap(IMGPath);
                    UpdateGUI();
                }
                catch
                {
                    MessageBox.Show("Unable to load the image.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                var newX = Convert.ToInt32(image.Width * (double)PercentageScale.Value / 100);
                var newY = Convert.ToInt32(image.Height * (double)PercentageScale.Value / 100);
                image = new Bitmap(image, new Size(newX, newY));
                UpdateGUI();
            }
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            button2_Click(null, e);
        }

        private void RewriteButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (image != null) image.Save(saveFileDialog1.FileName);
                }
                catch
                {
                    return;
                }
            }
        }

        void UpdateGUI()
        {
            if (image != null)
            {
                Scales.Items.Clear();
                Scales.Items.Add(image.Width + ";" + image.Height);
                PicBox.Image = image;
            }
        }

        private void ColorsConverter_Click(object sender, EventArgs e)
        {
            if(image != null) image = image.Clone(new Rectangle(0, 0, image.Width, image.Height), PixelFormat.Format4bppIndexed);
            UpdateGUI();
        }
    }
}
