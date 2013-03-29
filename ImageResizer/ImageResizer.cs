using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageResizer
{
    public partial class ImageResizer : Form
    {
        public ImageResizer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Wrap the creation of the OpenFileDialog instance in a using statement,
            // rather than manually calling the Dispose method to ensure proper disposal
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.png;*.jpg;*.gif;*.bmp)|*.png;*.jpg;*.gif;*.bmp";
                dlg.Multiselect = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    for (int i = 0; i < dlg.FileNames.Length; i++)
                    {

                        listBoxImages.Items.Add(dlg.FileNames[i]);
                    }


                  //  label1.Text = dlg.FileName;
          //     ConvertToPng(dlg.FileName);
                
                    //pictureBox1.Image = new Bitmap(dlg.FileName);

                    //pictureBox1.Image.
                 
                }

            }
        }




        protected void ConvertToPng(string filename)
        {
            var origImg = System.Drawing.Image.FromFile(filename);
            var widthDivisor = (double)origImg.Width / (double)numericWidth.Value;
            var heightDivisor = (double)origImg.Height / (double)numericHeight.Value;


            //var widthDivisor = (double)origImg.Width / (double)System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //var heightDivisor = (double)origImg.Height / (double)System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;


            int newWidth, newHeight;

            if (widthDivisor < heightDivisor)
            {
                newWidth = (int)((double)origImg.Width / widthDivisor);
                newHeight = (int)((double)origImg.Height / widthDivisor);
            }
            else
            {
                newWidth = (int)((double)origImg.Width / heightDivisor);
                newHeight = (int)((double)origImg.Height / heightDivisor);
            }

            var newImg = new Bitmap(newWidth, newHeight);
            Graphics g = Graphics.FromImage(newImg);    
            g.DrawImage(origImg, new Rectangle(0, 0, newWidth, newHeight));

            

           

            string a = filename.Split('\\').Last().Split('.')[0].ToString();

             string newFilename =  Path.Combine(txtSaveFolder.Text, a);
            if (radioJPG.Checked)
            {
                newFilename = newFilename+".jpg";
                newImg.Save(newFilename, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                newFilename = newFilename + ".png";
                newImg.Save(newFilename, System.Drawing.Imaging.ImageFormat.Png);
            }
            
            g.Dispose();
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {


                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtSaveFolder.Text = dlg.SelectedPath;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBarDone.Value = 0;
            lblPer.Text = "";
            if (txtSaveFolder.Text.Trim().Length>3)
            {
                if (listBoxImages.Items.Count > 0)
                {
                    for (int i = 0; i < listBoxImages.Items.Count; i++)
                    {
                        ConvertToPng(listBoxImages.Items[i].ToString());
                        progressBarDone.Value = (int)(i * 100 / listBoxImages.Items.Count);
                    }
                    progressBarDone.Value = 100;
                    lblPer.Text = "Done!";
                }
                else
                {
                    MessageBox.Show("Select images to resize");
                }
            }
            else
            {
                    MessageBox.Show("Select save path");
            }
       

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            listBoxImages.Items.Clear();
        }

    }
}
