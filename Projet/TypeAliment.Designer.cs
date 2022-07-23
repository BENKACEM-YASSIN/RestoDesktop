namespace Projet
{
    partial class TypeAliment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeAliment));
            this.lab = new System.Windows.Forms.Label();
            this.typealimet = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rech = new Bunifu.Framework.UI.BunifuImageButton();
            this.textrech = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.modifier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.annuler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ajouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.valider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.Transparent;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lab.ForeColor = System.Drawing.Color.Black;
            this.lab.Location = new System.Drawing.Point(12, 154);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(107, 16);
            this.lab.TabIndex = 91;
            this.lab.Text = "Type Aliment :";
            // 
            // typealimet
            // 
            this.typealimet.BackColor = System.Drawing.SystemColors.Control;
            this.typealimet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typealimet.Location = new System.Drawing.Point(15, 181);
            this.typealimet.Name = "typealimet";
            this.typealimet.Size = new System.Drawing.Size(197, 31);
            this.typealimet.TabIndex = 90;
            this.typealimet.TextChanged += new System.EventHandler(this.typealimet_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.bunifuImageButton3);
            this.panel4.Controls.Add(this.bunifuImageButton4);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.bunifuImageButton1);
            this.panel4.Controls.Add(this.close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 31);
            this.panel4.TabIndex = 93;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = global::Projet.Properties.Resources._001_remove;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(335, 3);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(37, 26);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 99;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = global::Projet.Properties.Resources._002_delete_button;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(382, 3);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(37, 26);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton4.TabIndex = 98;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(138, 42);
            this.panel5.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-1, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "- Gestion Type Aliment";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Projet.Properties.Resources._001_remove;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(444, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 48;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = global::Projet.Properties.Resources._002_delete_button;
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(490, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 35);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 47;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(5, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(185, 212);
            this.listBox1.TabIndex = 94;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(225, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 219);
            this.panel1.TabIndex = 95;
            // 
            // rech
            // 
            this.rech.BackColor = System.Drawing.Color.Transparent;
            this.rech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rech.Image = global::Projet.Properties.Resources.search;
            this.rech.ImageActive = null;
            this.rech.Location = new System.Drawing.Point(313, 114);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(37, 28);
            this.rech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rech.TabIndex = 100;
            this.rech.TabStop = false;
            this.rech.Zoom = 10;
            this.rech.Click += new System.EventHandler(this.rech_Click);
            // 
            // textrech
            // 
            this.textrech.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textrech.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textrech.BackgroundImage")));
            this.textrech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textrech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.textrech.Icon = ((System.Drawing.Image)(resources.GetObject("textrech.Icon")));
            this.textrech.Location = new System.Drawing.Point(66, 114);
            this.textrech.Name = "textrech";
            this.textrech.Size = new System.Drawing.Size(199, 28);
            this.textrech.TabIndex = 98;
            this.textrech.text = "Recherch par le nom";
            this.textrech.OnTextChange += new System.EventHandler(this.textrech_OnTextChange);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::Projet.Properties.Resources.recipe__3_;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(195, 37);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(57, 57);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 96;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::Projet.Properties.Resources.cooking;
            this.bunifuTileButton1.ImagePosition = 5;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Modifer Type Aliment";
            this.bunifuTileButton1.Location = new System.Drawing.Point(-218, -103);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(163, 135);
            this.bunifuTileButton1.TabIndex = 87;
            // 
            // modifier
            // 
            this.modifier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modifier.BorderRadius = 7;
            this.modifier.ButtonText = "Modifier";
            this.modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifier.DisabledColor = System.Drawing.Color.Gray;
            this.modifier.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Iconcolor = System.Drawing.Color.Transparent;
            this.modifier.Iconimage = global::Projet.Properties.Resources._001_edit;
            this.modifier.Iconimage_right = null;
            this.modifier.Iconimage_right_Selected = null;
            this.modifier.Iconimage_Selected = null;
            this.modifier.IconMarginLeft = 8;
            this.modifier.IconMarginRight = 0;
            this.modifier.IconRightVisible = true;
            this.modifier.IconRightZoom = 0D;
            this.modifier.IconVisible = true;
            this.modifier.IconZoom = 70D;
            this.modifier.IsTab = false;
            this.modifier.Location = new System.Drawing.Point(10, 276);
            this.modifier.Margin = new System.Windows.Forms.Padding(2);
            this.modifier.Name = "modifier";
            this.modifier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.modifier.OnHovercolor = System.Drawing.SystemColors.Desktop;
            this.modifier.OnHoverTextColor = System.Drawing.Color.Black;
            this.modifier.selected = false;
            this.modifier.Size = new System.Drawing.Size(99, 37);
            this.modifier.TabIndex = 84;
            this.modifier.Text = "Modifier";
            this.modifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modifier.Textcolor = System.Drawing.Color.White;
            this.modifier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // annuler
            // 
            this.annuler.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.annuler.BorderRadius = 7;
            this.annuler.ButtonText = "Annuler";
            this.annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.annuler.DisabledColor = System.Drawing.Color.Gray;
            this.annuler.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Iconcolor = System.Drawing.Color.Transparent;
            this.annuler.Iconimage = global::Projet.Properties.Resources._002_signs;
            this.annuler.Iconimage_right = null;
            this.annuler.Iconimage_right_Selected = null;
            this.annuler.Iconimage_Selected = null;
            this.annuler.IconMarginLeft = 8;
            this.annuler.IconMarginRight = 0;
            this.annuler.IconRightVisible = true;
            this.annuler.IconRightZoom = 0D;
            this.annuler.IconVisible = true;
            this.annuler.IconZoom = 70D;
            this.annuler.IsTab = false;
            this.annuler.Location = new System.Drawing.Point(114, 276);
            this.annuler.Margin = new System.Windows.Forms.Padding(2);
            this.annuler.Name = "annuler";
            this.annuler.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.annuler.OnHovercolor = System.Drawing.SystemColors.Desktop;
            this.annuler.OnHoverTextColor = System.Drawing.Color.Black;
            this.annuler.selected = false;
            this.annuler.Size = new System.Drawing.Size(99, 37);
            this.annuler.TabIndex = 86;
            this.annuler.Text = "Annuler";
            this.annuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.annuler.Textcolor = System.Drawing.Color.White;
            this.annuler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ajouter
            // 
            this.ajouter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ajouter.BorderRadius = 7;
            this.ajouter.ButtonText = "Ajouter";
            this.ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajouter.DisabledColor = System.Drawing.Color.Gray;
            this.ajouter.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Iconcolor = System.Drawing.Color.Transparent;
            this.ajouter.Iconimage = global::Projet.Properties.Resources._004_plus_black_symbol;
            this.ajouter.Iconimage_right = null;
            this.ajouter.Iconimage_right_Selected = null;
            this.ajouter.Iconimage_Selected = null;
            this.ajouter.IconMarginLeft = 8;
            this.ajouter.IconMarginRight = 0;
            this.ajouter.IconRightVisible = true;
            this.ajouter.IconRightZoom = 0D;
            this.ajouter.IconVisible = true;
            this.ajouter.IconZoom = 70D;
            this.ajouter.IsTab = false;
            this.ajouter.Location = new System.Drawing.Point(10, 232);
            this.ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.ajouter.OnHovercolor = System.Drawing.SystemColors.Desktop;
            this.ajouter.OnHoverTextColor = System.Drawing.Color.Black;
            this.ajouter.selected = false;
            this.ajouter.Size = new System.Drawing.Size(99, 37);
            this.ajouter.TabIndex = 82;
            this.ajouter.Text = "Ajouter";
            this.ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ajouter.Textcolor = System.Drawing.Color.White;
            this.ajouter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // valider
            // 
            this.valider.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.valider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.valider.BorderRadius = 7;
            this.valider.ButtonText = "Valider";
            this.valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valider.DisabledColor = System.Drawing.Color.Gray;
            this.valider.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Iconcolor = System.Drawing.Color.Transparent;
            this.valider.Iconimage = global::Projet.Properties.Resources._003_checked;
            this.valider.Iconimage_right = null;
            this.valider.Iconimage_right_Selected = null;
            this.valider.Iconimage_Selected = null;
            this.valider.IconMarginLeft = 8;
            this.valider.IconMarginRight = 0;
            this.valider.IconRightVisible = true;
            this.valider.IconRightZoom = 0D;
            this.valider.IconVisible = true;
            this.valider.IconZoom = 70D;
            this.valider.IsTab = false;
            this.valider.Location = new System.Drawing.Point(114, 232);
            this.valider.Margin = new System.Windows.Forms.Padding(2);
            this.valider.Name = "valider";
            this.valider.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.valider.OnHovercolor = System.Drawing.SystemColors.Desktop;
            this.valider.OnHoverTextColor = System.Drawing.Color.Black;
            this.valider.selected = false;
            this.valider.Size = new System.Drawing.Size(99, 37);
            this.valider.TabIndex = 83;
            this.valider.Text = "Valider";
            this.valider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valider.Textcolor = System.Drawing.Color.White;
            this.valider.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // supprimer
            // 
            this.supprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supprimer.BorderRadius = 7;
            this.supprimer.ButtonText = "supprimer";
            this.supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supprimer.DisabledColor = System.Drawing.Color.Gray;
            this.supprimer.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Iconcolor = System.Drawing.Color.Transparent;
            this.supprimer.Iconimage = global::Projet.Properties.Resources._005_trash;
            this.supprimer.Iconimage_right = null;
            this.supprimer.Iconimage_right_Selected = null;
            this.supprimer.Iconimage_Selected = null;
            this.supprimer.IconMarginLeft = 8;
            this.supprimer.IconMarginRight = 0;
            this.supprimer.IconRightVisible = true;
            this.supprimer.IconRightZoom = 0D;
            this.supprimer.IconVisible = true;
            this.supprimer.IconZoom = 70D;
            this.supprimer.IsTab = false;
            this.supprimer.Location = new System.Drawing.Point(46, 323);
            this.supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.supprimer.Name = "supprimer";
            this.supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.supprimer.OnHovercolor = System.Drawing.SystemColors.Desktop;
            this.supprimer.OnHoverTextColor = System.Drawing.Color.Black;
            this.supprimer.selected = false;
            this.supprimer.Size = new System.Drawing.Size(118, 37);
            this.supprimer.TabIndex = 85;
            this.supprimer.Text = "supprimer";
            this.supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supprimer.Textcolor = System.Drawing.Color.White;
            this.supprimer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // TypeAliment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 386);
            this.Controls.Add(this.rech);
            this.Controls.Add(this.textrech);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.typealimet);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.supprimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TypeAliment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Type de Aliment";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TypeAliment_FormClosing);
            this.Load += new System.EventHandler(this.TypeAliment_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuFlatButton modifier;
        private Bunifu.Framework.UI.BunifuFlatButton annuler;
        private Bunifu.Framework.UI.BunifuFlatButton ajouter;
        private Bunifu.Framework.UI.BunifuFlatButton valider;
        private Bunifu.Framework.UI.BunifuFlatButton supprimer;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox typealimet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuTextbox textrech;
        private Bunifu.Framework.UI.BunifuImageButton rech;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
    }
}