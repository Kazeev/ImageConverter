using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageConverter
{
    public class OpenFiles
    {
        private OpenFileDialog openDialog;
        private Image image;
        
        public OpenFiles()
        {
            this.openDialog = new OpenFileDialog();
            openDialog.Filter = "Файлы изображений|*.bmp;*.png;*.jpg";
            
            if (openDialog.ShowDialog() != DialogResult.OK)
                return;
            
            try
            {
                image = Image.FromFile(openDialog.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Ошибка чтения картинки");
                return;
            }
        }

        public Image Image
        {
            get => image;
            set => image = value;
        }
    }
}