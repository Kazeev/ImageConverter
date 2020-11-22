using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        int[,] GryMassPix;
        int[,,] RGBMassPix;
        public Form1()
        {
            InitializeComponent();
            save.Enabled = false;
            open.Enabled = false;
        }

        private void go_Click(object sender, EventArgs e)
        {
            var image = new OpenFiles().Image;
            Bitmap bmp = new Bitmap(image);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipX);
            if (cbGry.Checked)
            {
                cbGry.Enabled = false;
                GryMassPix = GryMap.GetGryColorMap(bmp);
            }else if (cbRGB.Checked)
            {
                cbRGB.Enabled = false;
                RGBMassPix = RGBMap.GetRGBColorMap(bmp);
            }
            
            Graphics g = Graphics.FromImage(bmp);
            g = this.CreateGraphics();
            int a = this.ClientSize.Width-50;
            int b = this.ClientSize.Height/2+50;
            g.DrawImage(image, 25, 5, a, b);
            g.Dispose(); 
            
            save.Enabled = true;
        }
        
        private void save_Click(object sender, EventArgs e)
        {
            if (cbGry.Checked)
            {
                new SaveFiles(GryMap.GetGryBinaryMas(GryMassPix));
            }else if (cbRGB.Checked)
            {
                new SaveFiles(RGBMap.GetRGBBinaryMas(RGBMassPix));
            }

            {
                save.Enabled = false;
                cbRGB.Enabled = true;
                cbGry.Enabled = true;
                open.Enabled = false;
                cbRGB.Checked = false;
                cbGry.Checked = false;
            }
        }


        private void cbGry_Click(object sender, EventArgs e)
        {
            cbRGB.Enabled = false;
            cbGry.Enabled = false;
            open.Enabled = true;

        }

        private void cbRGB_Click(object sender, EventArgs e)
        {
            cbRGB.Enabled = false;
            cbGry.Enabled = false;
            open.Enabled = true;
        }
    }
}