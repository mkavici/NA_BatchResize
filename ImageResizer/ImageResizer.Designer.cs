namespace ImageResizer
{
    partial class ImageResizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageResizer));
            this.btnSelectImages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioPNG = new System.Windows.Forms.RadioButton();
            this.radioJPG = new System.Windows.Forms.RadioButton();
            this.txtSaveFolder = new System.Windows.Forms.TextBox();
            this.btnFolderSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarDone = new System.Windows.Forms.ProgressBar();
            this.lblPer = new System.Windows.Forms.Label();
            this.btnClr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectImages.Location = new System.Drawing.Point(273, 299);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(103, 23);
            this.btnSelectImages.TabIndex = 0;
            this.btnSelectImages.Text = "Select Images";
            this.btnSelectImages.UseVisualStyleBackColor = true;
            this.btnSelectImages.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioPNG
            // 
            this.radioPNG.AutoSize = true;
            this.radioPNG.Checked = true;
            this.radioPNG.Location = new System.Drawing.Point(26, 46);
            this.radioPNG.Name = "radioPNG";
            this.radioPNG.Size = new System.Drawing.Size(51, 19);
            this.radioPNG.TabIndex = 2;
            this.radioPNG.TabStop = true;
            this.radioPNG.Text = "PNG";
            this.radioPNG.UseVisualStyleBackColor = true;
            // 
            // radioJPG
            // 
            this.radioJPG.AutoSize = true;
            this.radioJPG.Location = new System.Drawing.Point(92, 46);
            this.radioJPG.Name = "radioJPG";
            this.radioJPG.Size = new System.Drawing.Size(48, 19);
            this.radioJPG.TabIndex = 3;
            this.radioJPG.Text = "JPG";
            this.radioJPG.UseVisualStyleBackColor = true;
            // 
            // txtSaveFolder
            // 
            this.txtSaveFolder.Location = new System.Drawing.Point(26, 153);
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.Size = new System.Drawing.Size(177, 21);
            this.txtSaveFolder.TabIndex = 4;
            this.txtSaveFolder.Text = "C:\\Sites";
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.Location = new System.Drawing.Point(128, 180);
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.Size = new System.Drawing.Size(75, 23);
            this.btnFolderSelect.TabIndex = 5;
            this.btnFolderSelect.Text = "Select";
            this.btnFolderSelect.UseVisualStyleBackColor = true;
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Save Path";
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(26, 96);
            this.numericWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(75, 21);
            this.numericWidth.TabIndex = 7;
            this.numericWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(141, 96);
            this.numericHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(62, 21);
            this.numericHeight.TabIndex = 8;
            this.numericHeight.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // listBoxImages
            // 
            this.listBoxImages.AllowDrop = true;
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 15;
            this.listBoxImages.Location = new System.Drawing.Point(10, 46);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(366, 244);
            this.listBoxImages.TabIndex = 11;
            this.listBoxImages.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.listBoxImages.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            // 
            // btnResize
            // 
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResize.Location = new System.Drawing.Point(103, 287);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(100, 34);
            this.btnResize.TabIndex = 12;
            this.btnResize.Text = "Resize Images";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Image Format";
            // 
            // progressBarDone
            // 
            this.progressBarDone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBarDone.Location = new System.Drawing.Point(26, 235);
            this.progressBarDone.Name = "progressBarDone";
            this.progressBarDone.Size = new System.Drawing.Size(177, 15);
            this.progressBarDone.Step = 1;
            this.progressBarDone.TabIndex = 14;
            this.progressBarDone.Click += new System.EventHandler(this.progressBarDone_Click);
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(41, 235);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(0, 15);
            this.lblPer.TabIndex = 15;
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(10, 298);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 16;
            this.btnClr.Text = "Clear List";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectImages);
            this.groupBox1.Controls.Add(this.btnClr);
            this.groupBox1.Controls.Add(this.listBoxImages);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 361);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPNG);
            this.groupBox2.Controls.Add(this.radioJPG);
            this.groupBox2.Controls.Add(this.txtSaveFolder);
            this.groupBox2.Controls.Add(this.lblPer);
            this.groupBox2.Controls.Add(this.btnFolderSelect);
            this.groupBox2.Controls.Add(this.progressBarDone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericWidth);
            this.groupBox2.Controls.Add(this.btnResize);
            this.groupBox2.Controls.Add(this.numericHeight);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(415, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 361);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // ImageResizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageResizer";
            this.Text = "Image Resizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioPNG;
        private System.Windows.Forms.RadioButton radioJPG;
        private System.Windows.Forms.TextBox txtSaveFolder;
        private System.Windows.Forms.Button btnFolderSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarDone;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

