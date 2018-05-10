using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Merger
{
    public partial class frmImageMerger : Form
    {
        public frmImageMerger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image3 = (Bitmap)Image.FromFile(txtPathHeader.Text, true);
            FileInfo[] files = new DirectoryInfo(txtPathImages.Text).GetFiles();
            foreach (FileInfo item in files)
            {
                Bitmap image2 = (Bitmap)Image.FromFile(item.FullName, true);
                Bitmap bitmap = new Bitmap(Math.Max(image3.Width, image2.Width), image3.Height + image2.Height);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawImage(image3, 0, 0);
                    g.DrawImage(image2, 0, image3.Height);
                }
                picShow.Image = bitmap;
                picShow.Refresh();
                System.Threading.Thread.Sleep(90);
                bitmap.Save(txtPathOutput.Text+"\\" +DateTime.Now.ToLongTimeString()+ item.Name);
            }
        }
    }
}
