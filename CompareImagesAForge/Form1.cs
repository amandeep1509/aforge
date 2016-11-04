using AForge.Imaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareImagesAForge
{
    public partial class Form1 : Form
    {
        private string largeFileName;
        private string smallFileName;
        private bool img1Selected;
        private bool img2Selected;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            largePicBox.Visible = false;
            smallPicBox.Visible = false;
            btnCompare.Enabled = false;
            ShowStatus("no status");

        }
        private void ShowStatus(string status)
        {
            outputMessage.Text = status;
            outputMessage.Invalidate();
            outputMessage.Update();
            outputMessage.Refresh();
        }

        private void largeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialog.FileName = "";
            fileDialog.Title = "Select large image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                largeFileName = fileDialog.FileName.ToString();
                largeLink.Text = largeFileName;
                largePicBox.Image = System.Drawing.Image.FromFile(largeFileName);
                largePicBox.Visible = true;
                img1Selected = true;
            }
            ValidateSelections();
        }

        private void smallLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialog.FileName = "";
            fileDialog.Title = "Select small image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                smallFileName = fileDialog.FileName.ToString();
                smallLink.Text = smallFileName;
                smallPicBox.Image = System.Drawing.Image.FromFile(smallFileName);
                smallPicBox.Visible = true;
                img2Selected = true;
            }
            ValidateSelections();
        }
        private void ValidateSelections()
        {
            ShowStatus("");
            if (img1Selected && img2Selected)
            {
                btnCompare.Enabled = true;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            ShowStatus("Processing...");
            Bitmap largeImage = (Bitmap)System.Drawing.Image.FromFile(largeFileName);
            Bitmap smallImage = (Bitmap)System.Drawing.Image.FromFile(smallFileName);

            ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0.9f);

            TemplateMatch[] match = tm.ProcessImage(largeImage, smallImage);

            if (match.Length > 0)
            {
                TemplateMatch matches = match[0];
                ShowStatus("Match found at X:" + match[0].Rectangle.Location.X + "and Y:" + match[0].Rectangle.Location.Y);
            }
            else
            {
                ShowStatus("Match not found");
            }
        }
    }
}
