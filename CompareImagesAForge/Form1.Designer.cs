namespace CompareImagesAForge
{
    partial class Form1
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.smallLink = new System.Windows.Forms.LinkLabel();
            this.largeLink = new System.Windows.Forms.LinkLabel();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputMessage = new System.Windows.Forms.Label();
            this.smallPicBox = new System.Windows.Forms.PictureBox();
            this.largePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.smallPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(5, 89);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(115, 23);
            this.btnCompare.TabIndex = 8;
            this.btnCompare.Text = "Compare images";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // smallLink
            // 
            this.smallLink.AutoSize = true;
            this.smallLink.Location = new System.Drawing.Point(5, 61);
            this.smallLink.Name = "smallLink";
            this.smallLink.Size = new System.Drawing.Size(94, 13);
            this.smallLink.TabIndex = 7;
            this.smallLink.TabStop = true;
            this.smallLink.Text = "Select small image";
            this.smallLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.smallLink_LinkClicked);
            // 
            // largeLink
            // 
            this.largeLink.AutoSize = true;
            this.largeLink.Location = new System.Drawing.Point(5, 39);
            this.largeLink.Name = "largeLink";
            this.largeLink.Size = new System.Drawing.Size(94, 13);
            this.largeLink.TabIndex = 6;
            this.largeLink.TabStop = true;
            this.largeLink.Text = "Select large image";
            this.largeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.largeLink_LinkClicked);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // outputMessage
            // 
            this.outputMessage.AutoSize = true;
            this.outputMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessage.Location = new System.Drawing.Point(5, 314);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Size = new System.Drawing.Size(263, 24);
            this.outputMessage.TabIndex = 11;
            this.outputMessage.Text = "Your result will be shown here";
            // 
            // smallPicBox
            // 
            this.smallPicBox.Location = new System.Drawing.Point(224, 120);
            this.smallPicBox.Name = "smallPicBox";
            this.smallPicBox.Size = new System.Drawing.Size(186, 191);
            this.smallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smallPicBox.TabIndex = 9;
            this.smallPicBox.TabStop = false;
            // 
            // largePicBox
            // 
            this.largePicBox.Location = new System.Drawing.Point(5, 120);
            this.largePicBox.Name = "largePicBox";
            this.largePicBox.Size = new System.Drawing.Size(186, 191);
            this.largePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.largePicBox.TabIndex = 10;
            this.largePicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 376);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.smallLink);
            this.Controls.Add(this.largeLink);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.smallPicBox);
            this.Controls.Add(this.largePicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smallPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox largePicBox;
        private System.Windows.Forms.PictureBox smallPicBox;
        private System.Windows.Forms.Label outputMessage;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.LinkLabel largeLink;
        private System.Windows.Forms.LinkLabel smallLink;
        private System.Windows.Forms.Button btnCompare;
    }
}

