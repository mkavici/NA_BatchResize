using System;
using System.Diagnostics;
using SixLabors.ImageSharp;

using System.IO;
using System.Threading;
using System.Windows.Forms;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;

namespace ImageResizer
{
    public partial class ImageResizer : Form
    {
        public ImageResizer()
        {
            InitializeComponent();
        }
        protected bool validData;
        protected Thread getImageThread;
        protected string lastFilename = String.Empty;

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



        #region drag drop

        private void OnDragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Debug.WriteLine("OnDragDrop");
            if (validData)
            {
                listBoxImages.Items.Add(lastFilename);
            }
        }

        private void OnDragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Debug.WriteLine("OnDragEnter");
            string filename;
            validData = GetFilename(out filename, e);
            if (validData)
            {
                if (lastFilename != filename)
                {
             
                    lastFilename = filename;
           
                }
                else
                {
                  //
                }
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }




        protected bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;

            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }


        #endregion





        protected void ConvertToPng(string filename)
        {
            using (var origImg = Image.Load(filename))
            {
                // Calculate the scaling factors
                var widthDivisor = (double)origImg.Width / (double)numericWidth.Value;
                var heightDivisor = (double)origImg.Height / (double)numericHeight.Value;

                int newWidth, newHeight;

                // Determine new dimensions
                if (widthDivisor < heightDivisor)
                {
                    newWidth = (int)(origImg.Width / widthDivisor);
                    newHeight = (int)(origImg.Height / widthDivisor);
                }
                else
                {
                    newWidth = (int)(origImg.Width / heightDivisor);
                    newHeight = (int)(origImg.Height / heightDivisor);
                }

                // Resize the image
                origImg.Mutate(x => x.Resize(newWidth, newHeight));

                // Prepare the output filename
                string baseFilename = Path.GetFileNameWithoutExtension(filename);
                string newFilename = Path.Combine(txtSaveFolder.Text, baseFilename);

                if (radioJPG.Checked)
                {
                    newFilename += ".jpg";
                    var jpegEncoder = new JpegEncoder();
                    origImg.Save(newFilename, jpegEncoder);
                }
                else
                {
                    newFilename += ".png";
                    var pngEncoder = new PngEncoder();
                    origImg.Save(newFilename, pngEncoder);
                }
            }
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

        private void progressBarDone_Click(object sender, EventArgs e)
        {

        }

    }
}
