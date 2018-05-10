namespace Image_Merger
{
    partial class frmImageMerger
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathHeader = new System.Windows.Forms.TextBox();
            this.txtPathImages = new System.Windows.Forms.TextBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.txtPathOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Merge";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Header Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select folder of images to merge with";
            // 
            // txtPathHeader
            // 
            this.txtPathHeader.Location = new System.Drawing.Point(234, 51);
            this.txtPathHeader.Name = "txtPathHeader";
            this.txtPathHeader.Size = new System.Drawing.Size(236, 20);
            this.txtPathHeader.TabIndex = 3;
            // 
            // txtPathImages
            // 
            this.txtPathImages.Location = new System.Drawing.Point(234, 114);
            this.txtPathImages.Name = "txtPathImages";
            this.txtPathImages.Size = new System.Drawing.Size(236, 20);
            this.txtPathImages.TabIndex = 4;
            // 
            // picShow
            // 
            this.picShow.Location = new System.Drawing.Point(51, 12);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(444, 259);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShow.TabIndex = 5;
            this.picShow.TabStop = false;
            // 
            // txtPathOutput
            // 
            this.txtPathOutput.Location = new System.Drawing.Point(234, 163);
            this.txtPathOutput.Name = "txtPathOutput";
            this.txtPathOutput.Size = new System.Drawing.Size(236, 20);
            this.txtPathOutput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 348);
            this.Controls.Add(this.txtPathOutput);
            this.Controls.Add(this.txtPathImages);
            this.Controls.Add(this.txtPathHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathHeader;
        private System.Windows.Forms.TextBox txtPathImages;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.TextBox txtPathOutput;
        private System.Windows.Forms.Label label3;
    }
}

