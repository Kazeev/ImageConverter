using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            save.Enabled = true;
        }
        
        private void save_Click(object sender, EventArgs e)
        {
            new SaveFiles(text: ImgReader.GetGryBinaryMas(massPix));
            save.Enabled = false;
        }
    }
}