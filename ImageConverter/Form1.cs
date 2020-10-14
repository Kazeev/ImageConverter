using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        int[,] massPix;
        public Form1()
        {
            InitializeComponent();
            save.Enabled = false;
        }

        private void go_Click(object sender, EventArgs e)
        {
            var image = new OpenFiles().Image;
            Bitmap bmp = new Bitmap(image);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipX);
            massPix = ImgReader.GetGryColorMap(bmp);
            {
                Graphics g = Graphics.FromImage(bmp);
                g = this.CreateGraphics();
                int a = this.ClientSize.Width-50;
                int b = this.ClientSize.Height/2+50;
                g.DrawImage(image, 25, 5, a, b);
                g.Dispose(); 
            }
            save.Enabled = true;
        }
        
        private void save_Click(object sender, EventArgs e)
        {
            new SaveFiles(text: ImgReader.GetGryBinaryMas(massPix));
            save.Enabled = false;
        }


    }
}