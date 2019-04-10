using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Imgur.API.Models;
using System.Diagnostics;

namespace OKF_Jelenetes
{
    public partial class OKF_Jelentes_Iro : Form
    {
        

        string FilePath = String.Empty;
        string ImagePath = String.Empty;

        public OKF_Jelentes_Iro()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private async void generateReport_ClickAsync(object sender, EventArgs e)
        {
            if(FilePath == String.Empty || ImagePath == String.Empty)
            {
                Sound.PlaySound(Sounds.error);
                MessageBox.Show("Válaszd ki a cél mappát, vagy a feltöltendő képet");
                return;
            }

            if(reportName.Text == String.Empty || eventDesc.Text == String.Empty)
            {
                Sound.PlaySound(Sounds.error);
                MessageBox.Show("A név, káreset leírás nem lehet üres");
                return;
            }

            generateReport.Text = "Generálás folyamatban...";
            generateReport.Enabled = false;

            await ReportGenerator.GenerateReport(reportName.Text, rankName.selectedValue, eventDesc.Text, ImagePath, FilePath);

            Sound.PlaySound(Sounds.ADVANCEMENT_WON);
            generateReport.Text = "Generálás";
            selectImage.Text = "Kiválasztás";
            generateReport.Enabled = true;
            ImagePath = String.Empty;
        }

        private void changeDirectory_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = folderBrowserDialog.SelectedPath + "\\Jelentések";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(Images.okf, new Size(50, 50));
            string Date = DateTime.Now.ToString("yyyy. MM. dd.");
            dateLabel.Text = "Jelenlegi dátum: " + Date;
            FilePath = Directory.GetCurrentDirectory() + "\\Jelentések";
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            outputDir.Text = FilePath;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = false;
        }


        private void chooseDirectory_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = folderBrowserDialog.SelectedPath;
                outputDir.Text = FilePath;
            }
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectImage.Text = openFileDialog.FileName;
                ImagePath = openFileDialog.FileName;
            }
        }


        // MOZGATÁS
        int MValX;
        int MValY;
        bool canMove = false;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            canMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            canMove = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(@FilePath);
        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
