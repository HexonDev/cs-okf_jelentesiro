namespace OKF_Jelenetes
{
    partial class OKF_Jelentes_Iro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OKF_Jelentes_Iro));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.eventDesc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.outputDir = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.selectImage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chooseDirectory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.generateReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenFolder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rankName = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 47);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.Image = global::OKF_Jelenetes.Images.icons8_delete_104;
            this.exitButton.Location = new System.Drawing.Point(864, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(47, 47);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(53, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(405, 22);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Országos Katasztrófavédelmi Főigazgatóság";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::OKF_Jelenetes.Images.OKF001_500x500;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // reportName
            // 
            this.reportName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.reportName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.reportName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.reportName.BorderThickness = 3;
            this.reportName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.reportName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.reportName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.reportName.isPassword = false;
            this.reportName.Location = new System.Drawing.Point(57, 101);
            this.reportName.Margin = new System.Windows.Forms.Padding(4);
            this.reportName.Name = "reportName";
            this.reportName.Size = new System.Drawing.Size(375, 35);
            this.reportName.TabIndex = 1;
            this.reportName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(54, 81);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(36, 16);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Név:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(54, 148);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 16);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Rendfokozat:";
            // 
            // eventDesc
            // 
            this.eventDesc.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.eventDesc.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.eventDesc.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.eventDesc.BorderThickness = 3;
            this.eventDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eventDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.eventDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.eventDesc.isPassword = false;
            this.eventDesc.Location = new System.Drawing.Point(57, 229);
            this.eventDesc.Margin = new System.Windows.Forms.Padding(4);
            this.eventDesc.Name = "eventDesc";
            this.eventDesc.Size = new System.Drawing.Size(375, 35);
            this.eventDesc.TabIndex = 5;
            this.eventDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(54, 209);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(101, 16);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Káreset leírása:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(54, 269);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(35, 16);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Kép:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(12, 463);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(124, 20);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Jelenlegi dátum:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(515, 81);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(77, 16);
            this.bunifuCustomLabel6.TabIndex = 15;
            this.bunifuCustomLabel6.Text = "Cél mappa:";
            // 
            // outputDir
            // 
            this.outputDir.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.outputDir.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.outputDir.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.outputDir.BorderThickness = 3;
            this.outputDir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outputDir.Enabled = false;
            this.outputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.outputDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.outputDir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.outputDir.isPassword = false;
            this.outputDir.Location = new System.Drawing.Point(518, 101);
            this.outputDir.Margin = new System.Windows.Forms.Padding(4);
            this.outputDir.Name = "outputDir";
            this.outputDir.Size = new System.Drawing.Size(375, 35);
            this.outputDir.TabIndex = 14;
            this.outputDir.Text = "Kiviteli mappa";
            this.outputDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(12, 496);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(326, 20);
            this.bunifuCustomLabel7.TabIndex = 17;
            this.bunifuCustomLabel7.Text = "Készítette: Derek Wright // Hexon; Verzió: 0.5";
            this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuCustomLabel7_Click);
            // 
            // selectImage
            // 
            this.selectImage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.selectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.selectImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectImage.BorderRadius = 0;
            this.selectImage.ButtonText = "Kiválasztás";
            this.selectImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectImage.DisabledColor = System.Drawing.Color.Gray;
            this.selectImage.Iconcolor = System.Drawing.Color.Transparent;
            this.selectImage.Iconimage = global::OKF_Jelenetes.Images.icons8_xlarge_icons_filled_100;
            this.selectImage.Iconimage_right = null;
            this.selectImage.Iconimage_right_Selected = null;
            this.selectImage.Iconimage_Selected = null;
            this.selectImage.IconMarginLeft = 0;
            this.selectImage.IconMarginRight = 0;
            this.selectImage.IconRightVisible = true;
            this.selectImage.IconRightZoom = 0D;
            this.selectImage.IconVisible = true;
            this.selectImage.IconZoom = 60D;
            this.selectImage.IsTab = false;
            this.selectImage.Location = new System.Drawing.Point(57, 288);
            this.selectImage.Name = "selectImage";
            this.selectImage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.selectImage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.selectImage.OnHoverTextColor = System.Drawing.Color.White;
            this.selectImage.selected = false;
            this.selectImage.Size = new System.Drawing.Size(375, 31);
            this.selectImage.TabIndex = 18;
            this.selectImage.Text = "Kiválasztás";
            this.selectImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectImage.Textcolor = System.Drawing.Color.White;
            this.selectImage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImage.Click += new System.EventHandler(this.selectImage_Click);
            // 
            // chooseDirectory
            // 
            this.chooseDirectory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.chooseDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chooseDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseDirectory.BorderRadius = 0;
            this.chooseDirectory.ButtonText = "Kiválasztás";
            this.chooseDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseDirectory.DisabledColor = System.Drawing.Color.Gray;
            this.chooseDirectory.Iconcolor = System.Drawing.Color.Transparent;
            this.chooseDirectory.Iconimage = global::OKF_Jelenetes.Images.icons8_folder_filled_100;
            this.chooseDirectory.Iconimage_right = null;
            this.chooseDirectory.Iconimage_right_Selected = null;
            this.chooseDirectory.Iconimage_Selected = null;
            this.chooseDirectory.IconMarginLeft = 0;
            this.chooseDirectory.IconMarginRight = 0;
            this.chooseDirectory.IconRightVisible = true;
            this.chooseDirectory.IconRightZoom = 0D;
            this.chooseDirectory.IconVisible = true;
            this.chooseDirectory.IconZoom = 60D;
            this.chooseDirectory.IsTab = false;
            this.chooseDirectory.Location = new System.Drawing.Point(725, 148);
            this.chooseDirectory.Name = "chooseDirectory";
            this.chooseDirectory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chooseDirectory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.chooseDirectory.OnHoverTextColor = System.Drawing.Color.White;
            this.chooseDirectory.selected = false;
            this.chooseDirectory.Size = new System.Drawing.Size(168, 31);
            this.chooseDirectory.TabIndex = 16;
            this.chooseDirectory.Text = "Kiválasztás";
            this.chooseDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseDirectory.Textcolor = System.Drawing.Color.White;
            this.chooseDirectory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDirectory.Click += new System.EventHandler(this.chooseDirectory_Click);
            // 
            // generateReport
            // 
            this.generateReport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.generateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.generateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateReport.BorderRadius = 0;
            this.generateReport.ButtonText = "Generálás";
            this.generateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateReport.DisabledColor = System.Drawing.Color.Gray;
            this.generateReport.Iconcolor = System.Drawing.Color.Transparent;
            this.generateReport.Iconimage = global::OKF_Jelenetes.Images.icons8_synchronize_96;
            this.generateReport.Iconimage_right = null;
            this.generateReport.Iconimage_right_Selected = null;
            this.generateReport.Iconimage_Selected = null;
            this.generateReport.IconMarginLeft = 0;
            this.generateReport.IconMarginRight = 0;
            this.generateReport.IconRightVisible = true;
            this.generateReport.IconRightZoom = 0D;
            this.generateReport.IconVisible = true;
            this.generateReport.IconZoom = 80D;
            this.generateReport.IsTab = false;
            this.generateReport.Location = new System.Drawing.Point(652, 463);
            this.generateReport.Name = "generateReport";
            this.generateReport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.generateReport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.generateReport.OnHoverTextColor = System.Drawing.Color.White;
            this.generateReport.selected = false;
            this.generateReport.Size = new System.Drawing.Size(241, 48);
            this.generateReport.TabIndex = 7;
            this.generateReport.Text = "Generálás";
            this.generateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateReport.Textcolor = System.Drawing.Color.White;
            this.generateReport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReport.Click += new System.EventHandler(this.generateReport_ClickAsync);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // OpenFolder
            // 
            this.OpenFolder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.OpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OpenFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenFolder.BorderRadius = 0;
            this.OpenFolder.ButtonText = "Megnyitás";
            this.OpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFolder.DisabledColor = System.Drawing.Color.Gray;
            this.OpenFolder.Iconcolor = System.Drawing.Color.Transparent;
            this.OpenFolder.Iconimage = global::OKF_Jelenetes.Images.icons8_folder_filled_100;
            this.OpenFolder.Iconimage_right = null;
            this.OpenFolder.Iconimage_right_Selected = null;
            this.OpenFolder.Iconimage_Selected = null;
            this.OpenFolder.IconMarginLeft = 0;
            this.OpenFolder.IconMarginRight = 0;
            this.OpenFolder.IconRightVisible = true;
            this.OpenFolder.IconRightZoom = 0D;
            this.OpenFolder.IconVisible = true;
            this.OpenFolder.IconZoom = 60D;
            this.OpenFolder.IsTab = false;
            this.OpenFolder.Location = new System.Drawing.Point(518, 148);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OpenFolder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.OpenFolder.OnHoverTextColor = System.Drawing.Color.White;
            this.OpenFolder.selected = false;
            this.OpenFolder.Size = new System.Drawing.Size(168, 31);
            this.OpenFolder.TabIndex = 19;
            this.OpenFolder.Text = "Megnyitás";
            this.OpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFolder.Textcolor = System.Drawing.Color.White;
            this.OpenFolder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // rankName
            // 
            this.rankName.BackColor = System.Drawing.Color.Transparent;
            this.rankName.BorderRadius = 3;
            this.rankName.DisabledColor = System.Drawing.Color.Gray;
            this.rankName.ForeColor = System.Drawing.Color.White;
            this.rankName.Items = new string[] {
        "Inaktív",
        "Önkéntes",
        "Őrmester",
        "Törzsőrmester",
        "Főtörzsőrmester",
        "Zászlós",
        "Törzszászlós",
        "Főtörzszászlós",
        "Hadnagy",
        "Főhadnagy",
        "Százados",
        "Őrnagy",
        "Alezredes",
        "Ezredes",
        "Altábornagy",
        "Vezérezredes"};
            this.rankName.Location = new System.Drawing.Point(57, 167);
            this.rankName.Name = "rankName";
            this.rankName.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rankName.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.rankName.selectedIndex = 2;
            this.rankName.Size = new System.Drawing.Size(375, 35);
            this.rankName.TabIndex = 20;
            // 
            // OKF_Jelentes_Iro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(911, 525);
            this.Controls.Add(this.rankName);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.selectImage);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.chooseDirectory);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.outputDir);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.eventDesc);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.reportName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OKF_Jelentes_Iro";
            this.Text = "OKF Jelentés író";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox exitButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox reportName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox eventDesc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton generateReport;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private Bunifu.Framework.UI.BunifuCustomLabel dateLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox outputDir;
        private Bunifu.Framework.UI.BunifuFlatButton chooseDirectory;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton selectImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Bunifu.Framework.UI.BunifuFlatButton OpenFolder;
        private Bunifu.Framework.UI.BunifuDropdown rankName;
    }
}

