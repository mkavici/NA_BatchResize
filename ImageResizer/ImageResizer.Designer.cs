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
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Location = new System.Drawing.Point(281, 314);
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
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioPNG
            // 
            this.radioPNG.AutoSize = true;
            this.radioPNG.Location = new System.Drawing.Point(407, 42);
            this.radioPNG.Name = "radioPNG";
            this.radioPNG.Size = new System.Drawing.Size(48, 17);
            this.radioPNG.TabIndex = 2;
            this.radioPNG.Text = "PNG";
            this.radioPNG.UseVisualStyleBackColor = true;
            // 
            // radioJPG
            // 
            this.radioJPG.AutoSize = true;
            this.radioJPG.Checked = true;
            this.radioJPG.Location = new System.Drawing.Point(408, 65);
            this.radioJPG.Name = "radioJPG";
            this.radioJPG.Size = new System.Drawing.Size(45, 17);
            this.radioJPG.TabIndex = 3;
            this.radioJPG.TabStop = true;
            this.radioJPG.Text = "JPG";
            this.radioJPG.UseVisualStyleBackColor = true;
            // 
            // txtSaveFolder
            // 
            this.txtSaveFolder.Location = new System.Drawing.Point(12, 39);
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.Size = new System.Drawing.Size(291, 20);
            this.txtSaveFolder.TabIndex = 4;
            this.txtSaveFolder.Text = "C:\\Sites";
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.Location = new System.Drawing.Point(309, 39);
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
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Save Path";
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(55, 77);
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
            this.numericWidth.Size = new System.Drawing.Size(120, 20);
            this.numericWidth.TabIndex = 7;
            this.numericWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(264, 79);
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
            this.numericHeight.Size = new System.Drawing.Size(120, 20);
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
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // listBoxImages
            // 
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.Location = new System.Drawing.Point(12, 119);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(372, 186);
            this.listBoxImages.TabIndex = 11;
            // 
            // btnResize
            // 
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResize.Location = new System.Drawing.Point(400, 121);
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
            this.label5.Location = new System.Drawing.Point(401, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Image Format";
            // 
            // progressBarDone
            // 
            this.progressBarDone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBarDone.Location = new System.Drawing.Point(400, 180);
            this.progressBarDone.Name = "progressBarDone";
            this.progressBarDone.Size = new System.Drawing.Size(100, 10);
            this.progressBarDone.Step = 1;
            this.progressBarDone.TabIndex = 14;
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(400, 210);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(0, 13);
            this.lblPer.TabIndex = 15;
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(15, 313);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 16;
            this.btnClr.Text = "Clear List";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // ImageResizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 349);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.progressBarDone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.listBoxImages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericHeight);
            this.Controls.Add(this.numericWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFolderSelect);
            this.Controls.Add(this.txtSaveFolder);
            this.Controls.Add(this.radioJPG);
            this.Controls.Add(this.radioPNG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectImages);
            this.Name = "ImageResizer";
            this.Text = "Image Resizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

