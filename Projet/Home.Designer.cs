namespace Projet
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Client = new Bunifu.Framework.UI.BunifuTileButton();
            this.Aliment = new Bunifu.Framework.UI.BunifuTileButton();
            this.commande = new Bunifu.Framework.UI.BunifuTileButton();
            this.menu = new Bunifu.Framework.UI.BunifuTileButton();
            this.pancli = new System.Windows.Forms.Panel();
            this.Accueil = new Bunifu.Framework.UI.BunifuTileButton();
            this.panalim = new System.Windows.Forms.Panel();
            this.pancom = new System.Windows.Forms.Panel();
            this.panmen = new System.Windows.Forms.Panel();
            this.panac = new System.Windows.Forms.Panel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.forms = new System.Windows.Forms.Panel();
            this.accueil1 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.moncompte = new Bunifu.Framework.UI.BunifuThinButton2();
            this.commander = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.forms.SuspendLayout();
            this.accueil1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.Client);
            this.panel1.Controls.Add(this.Aliment);
            this.panel1.Controls.Add(this.commande);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.pancli);
            this.panel1.Controls.Add(this.Accueil);
            this.panel1.Controls.Add(this.panalim);
            this.panel1.Controls.Add(this.pancom);
            this.panel1.Controls.Add(this.panmen);
            this.panel1.Controls.Add(this.panac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 612);
            this.panel1.TabIndex = 0;
            // 
            // Client
            // 
            this.Client.BackColor = System.Drawing.Color.Transparent;
            this.Client.color = System.Drawing.Color.Transparent;
            this.Client.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.Client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Client.ForeColor = System.Drawing.Color.White;
            this.Client.Image = global::Projet.Properties.Resources._001_reunion2;
            this.Client.ImagePosition = 5;
            this.Client.ImageZoom = 50;
            this.Client.LabelPosition = 30;
            this.Client.LabelText = "Client";
            this.Client.Location = new System.Drawing.Point(21, 500);
            this.Client.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(149, 107);
            this.Client.TabIndex = 85;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Aliment
            // 
            this.Aliment.BackColor = System.Drawing.Color.Transparent;
            this.Aliment.color = System.Drawing.Color.Transparent;
            this.Aliment.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.Aliment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aliment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Aliment.ForeColor = System.Drawing.Color.White;
            this.Aliment.Image = global::Projet.Properties.Resources.food;
            this.Aliment.ImagePosition = 5;
            this.Aliment.ImageZoom = 50;
            this.Aliment.LabelPosition = 30;
            this.Aliment.LabelText = "Aliment";
            this.Aliment.Location = new System.Drawing.Point(21, 387);
            this.Aliment.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Aliment.Name = "Aliment";
            this.Aliment.Size = new System.Drawing.Size(149, 107);
            this.Aliment.TabIndex = 84;
            this.Aliment.Click += new System.EventHandler(this.Aliment_Click);
            // 
            // commande
            // 
            this.commande.BackColor = System.Drawing.Color.Transparent;
            this.commande.color = System.Drawing.Color.Transparent;
            this.commande.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.commande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.commande.ForeColor = System.Drawing.Color.White;
            this.commande.Image = global::Projet.Properties.Resources._003_restaurant1;
            this.commande.ImagePosition = 5;
            this.commande.ImageZoom = 50;
            this.commande.LabelPosition = 30;
            this.commande.LabelText = "Commandes";
            this.commande.Location = new System.Drawing.Point(21, 274);
            this.commande.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.commande.Name = "commande";
            this.commande.Size = new System.Drawing.Size(149, 107);
            this.commande.TabIndex = 84;
            this.commande.Click += new System.EventHandler(this.bunifuTileButton1_Click_1);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.color = System.Drawing.Color.Transparent;
            this.menu.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = global::Projet.Properties.Resources.menu__1_;
            this.menu.ImagePosition = 5;
            this.menu.ImageZoom = 50;
            this.menu.LabelPosition = 30;
            this.menu.LabelText = "Menu";
            this.menu.Location = new System.Drawing.Point(21, 161);
            this.menu.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(149, 107);
            this.menu.TabIndex = 83;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // pancli
            // 
            this.pancli.BackColor = System.Drawing.Color.Cyan;
            this.pancli.Location = new System.Drawing.Point(0, 500);
            this.pancli.Name = "pancli";
            this.pancli.Size = new System.Drawing.Size(18, 107);
            this.pancli.TabIndex = 4;
            // 
            // Accueil
            // 
            this.Accueil.BackColor = System.Drawing.Color.Transparent;
            this.Accueil.color = System.Drawing.Color.Transparent;
            this.Accueil.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.Accueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Accueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Accueil.ForeColor = System.Drawing.Color.White;
            this.Accueil.Image = global::Projet.Properties.Resources.store__1_;
            this.Accueil.ImagePosition = 5;
            this.Accueil.ImageZoom = 50;
            this.Accueil.LabelPosition = 30;
            this.Accueil.LabelText = "Accueil";
            this.Accueil.Location = new System.Drawing.Point(21, 48);
            this.Accueil.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Accueil.Name = "Accueil";
            this.Accueil.Size = new System.Drawing.Size(149, 107);
            this.Accueil.TabIndex = 82;
            this.Accueil.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // panalim
            // 
            this.panalim.BackColor = System.Drawing.Color.Cyan;
            this.panalim.Location = new System.Drawing.Point(0, 387);
            this.panalim.Name = "panalim";
            this.panalim.Size = new System.Drawing.Size(18, 107);
            this.panalim.TabIndex = 8;
            // 
            // pancom
            // 
            this.pancom.BackColor = System.Drawing.Color.Cyan;
            this.pancom.Location = new System.Drawing.Point(0, 274);
            this.pancom.Name = "pancom";
            this.pancom.Size = new System.Drawing.Size(18, 107);
            this.pancom.TabIndex = 6;
            // 
            // panmen
            // 
            this.panmen.BackColor = System.Drawing.Color.Cyan;
            this.panmen.Location = new System.Drawing.Point(0, 161);
            this.panmen.Name = "panmen";
            this.panmen.Size = new System.Drawing.Size(18, 107);
            this.panmen.TabIndex = 4;
            // 
            // panac
            // 
            this.panac.BackColor = System.Drawing.Color.Cyan;
            this.panac.Location = new System.Drawing.Point(0, 48);
            this.panac.Name = "panac";
            this.panac.Size = new System.Drawing.Size(18, 107);
            this.panac.TabIndex = 0;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(174, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(907, 15);
            this.bunifuCards1.TabIndex = 1;
            // 
            // forms
            // 
            this.forms.BackColor = System.Drawing.Color.White;
            this.forms.Controls.Add(this.accueil1);
            this.forms.Location = new System.Drawing.Point(174, 94);
            this.forms.Name = "forms";
            this.forms.Size = new System.Drawing.Size(907, 518);
            this.forms.TabIndex = 2;
            // 
            // accueil1
            // 
            this.accueil1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.accueil1.Controls.Add(this.richTextBox2);
            this.accueil1.Controls.Add(this.richTextBox1);
            this.accueil1.Controls.Add(this.moncompte);
            this.accueil1.Controls.Add(this.commander);
            this.accueil1.Controls.Add(this.bunifuCards2);
            this.accueil1.Controls.Add(this.label4);
            this.accueil1.Controls.Add(this.bunifuImageButton2);
            this.accueil1.Location = new System.Drawing.Point(0, 1);
            this.accueil1.Name = "accueil1";
            this.accueil1.Size = new System.Drawing.Size(907, 518);
            this.accueil1.TabIndex = 0;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.richTextBox2.Location = new System.Drawing.Point(423, 257);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(474, 47);
            this.richTextBox2.TabIndex = 111;
            this.richTextBox2.Text = "Pour plus d\'informations contactez-nous";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.richTextBox1.Location = new System.Drawing.Point(424, 213);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(474, 91);
            this.richTextBox1.TabIndex = 110;
            this.richTextBox1.Text = "Bienvenue Vous pouvez maintenant commander votre nourriture préférée à des prix r" +
    "aisonnables";
            // 
            // moncompte
            // 
            this.moncompte.ActiveBorderThickness = 1;
            this.moncompte.ActiveCornerRadius = 20;
            this.moncompte.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.moncompte.ActiveForecolor = System.Drawing.Color.White;
            this.moncompte.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.moncompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.moncompte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moncompte.BackgroundImage")));
            this.moncompte.ButtonText = "MON COMPTE";
            this.moncompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moncompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moncompte.ForeColor = System.Drawing.Color.SeaGreen;
            this.moncompte.IdleBorderThickness = 1;
            this.moncompte.IdleCornerRadius = 20;
            this.moncompte.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.moncompte.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.moncompte.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.moncompte.Location = new System.Drawing.Point(424, 352);
            this.moncompte.Margin = new System.Windows.Forms.Padding(5);
            this.moncompte.Name = "moncompte";
            this.moncompte.Size = new System.Drawing.Size(211, 64);
            this.moncompte.TabIndex = 109;
            this.moncompte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moncompte.Click += new System.EventHandler(this.moncompte_Click);
            // 
            // commander
            // 
            this.commander.ActiveBorderThickness = 1;
            this.commander.ActiveCornerRadius = 20;
            this.commander.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.commander.ActiveForecolor = System.Drawing.Color.White;
            this.commander.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.commander.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.commander.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commander.BackgroundImage")));
            this.commander.ButtonText = "Commander";
            this.commander.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commander.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commander.ForeColor = System.Drawing.Color.SeaGreen;
            this.commander.IdleBorderThickness = 1;
            this.commander.IdleCornerRadius = 20;
            this.commander.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.commander.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.commander.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.commander.Location = new System.Drawing.Point(671, 352);
            this.commander.Margin = new System.Windows.Forms.Padding(5);
            this.commander.Name = "commander";
            this.commander.Size = new System.Drawing.Size(211, 64);
            this.commander.TabIndex = 108;
            this.commander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.commander.Click += new System.EventHandler(this.commander_Click);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(424, 181);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(458, 6);
            this.bunifuCards2.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(417, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 37);
            this.label4.TabIndex = 106;
            this.label4.Text = "ANONYME - RESTURANT ";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::Projet.Properties.Resources._1;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(9, 102);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(349, 314);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 105;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Location = new System.Drawing.Point(191, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 82);
            this.panel2.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(261, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restourent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resto - Anonyme";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Projet.Properties.Resources.cooker;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // username
            // 
            this.username.AllowDrop = true;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.username.BorderColorFocused = System.Drawing.Color.Blue;
            this.username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.username.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.username.BorderThickness = 3;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.isPassword = false;
            this.username.Location = new System.Drawing.Point(765, 28);
            this.username.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(181, 46);
            this.username.TabIndex = 109;
            this.username.Text = "Test";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(699, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "User :";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = global::Projet.Properties.Resources.power_button_off;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(1000, 21);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(69, 61);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 108;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1081, 612);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.forms);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.forms.ResumeLayout(false);
            this.accueil1.ResumeLayout(false);
            this.accueil1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel forms;
        private System.Windows.Forms.Panel panac;
        private System.Windows.Forms.Panel pancom;
        private System.Windows.Forms.Panel panmen;
        private System.Windows.Forms.Panel pancli;
        private System.Windows.Forms.Panel panalim;
        private Bunifu.Framework.UI.BunifuTileButton menu;
        private Bunifu.Framework.UI.BunifuTileButton Accueil;
        private Bunifu.Framework.UI.BunifuTileButton commande;
        private Bunifu.Framework.UI.BunifuTileButton Aliment;
        private Bunifu.Framework.UI.BunifuTileButton Client;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel accueil1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 moncompte;
        private Bunifu.Framework.UI.BunifuThinButton2 commander;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}