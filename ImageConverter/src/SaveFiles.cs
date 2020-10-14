using System.Windows.Forms;

namespace ImageConverter
{
    public class SaveFiles
    {
        private SaveFileDialog File;
        
        public SaveFiles(string text)
        {
            this.File = new SaveFileDialog();
            if (File.ShowDialog() == DialogResult.Cancel)
                return;
            File.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            System.IO.File.WriteAllText(File.FileName, text);
        }
    }
}