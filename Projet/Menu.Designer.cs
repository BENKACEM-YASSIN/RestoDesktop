namespace Projet
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel4 = new System.Windows.Forms.Panel();
            this.viewcommande = new System.Windows.Forms.Panel();
            this.cmdautrealiments = new Bunifu.Framework.UI.BunifuThinButton2();
            this.modifier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.valider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.annuler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ttctxt = new System.Windows.Forms.Label();
            this.ht = new System.Windows.Forms.Label();
            this.tvatxt = new System.Windows.Forms.Label();
            this.lignecmd = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voirlacommande = new Bunifu.Framework.UI.BunifuThinButton2();
            this.aliments = new System.Windows.Forms.ListBox();
            this.commander = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.imagealiment = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prix = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.qte = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.total = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.imgtxt = new System.Windows.Forms.TextBox();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.idaliment = new System.Windows.Forms.TextBox();
            this.typealiment = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.modifierlacommande = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4.SuspendLayout();
            this.viewcommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lignecmd)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagealiment)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.modifierlacommande);
            this.panel4.Controls.Add(this.viewcommande);
            this.panel4.Controls.Add(this.voirlacommande);
            this.panel4.Controls.Add(this.aliments);
            this.panel4.Controls.Add(this.commander);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.bunifuCards1);
            this.panel4.Controls.Add(this.bunifuCards3);
            this.panel4.Controls.Add(this.typealiment);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(907, 518);
            this.panel4.TabIndex = 94;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // viewcommande
            // 
            this.viewcommande.Controls.Add(this.panel1);
            this.viewcommande.Controls.Add(this.cmdautrealiments);
            this.viewcommande.Controls.Add(this.modifier);
            this.viewcommande.Controls.Add(this.supprimer);
            this.viewcommande.Controls.Add(this.valider);
            this.viewcommande.Controls.Add(this.annuler);
            this.viewcommande.Controls.Add(this.ttctxt);
            this.viewcommande.Controls.Add(this.ht);
            this.viewcommande.Controls.Add(this.tvatxt);
            this.viewcommande.Controls.Add(this.lignecmd);
            this.viewcommande.Location = new System.Drawing.Point(190, 92);
            this.viewcommande.Name = "viewcommande";
            this.viewcommande.Size = new System.Drawing.Size(666, 400);
            this.viewcommande.TabIndex = 114;
            // 
            // cmdautrealiments
            // 
            this.cmdautrealiments.ActiveBorderThickness = 1;
            this.cmdautrealiments.ActiveCornerRadius = 20;
            this.cmdautrealiments.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.cmdautrealiments.ActiveForecolor = System.Drawing.Color.White;
            this.cmdautrealiments.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.cmdautrealiments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cmdautrealiments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdautrealiments.BackgroundImage")));
            this.cmdautrealiments.ButtonText = "Commander autre aliments";
            this.cmdautrealiments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdautrealiments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdautrealiments.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdautrealiments.IdleBorderThickness = 1;
            this.cmdautrealiments.IdleCornerRadius = 20;
            this.cmdautrealiments.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cmdautrealiments.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.cmdautrealiments.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.cmdautrealiments.Location = new System.Drawing.Point(444, 252);
            this.cmdautrealiments.Margin = new System.Windows.Forms.Padding(5);
            this.cmdautrealiments.Name = "cmdautrealiments";
            this.cmdautrealiments.Size = new System.Drawing.Size(217, 84);
            this.cmdautrealiments.TabIndex = 133;
            this.cmdautrealiments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdautrealiments.Click += new System.EventHandler(this.cmdautrealiments_Click);
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
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Iconcolor = System.Drawing.Color.Transparent;
            this.modifier.Iconimage = global::Projet.Properties.Resources._001_pencil;
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
            this.modifier.Location = new System.Drawing.Point(55, 346);
            this.modifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifier.Name = "modifier";
            this.modifier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.modifier.OnHovercolor = System.Drawing.SystemColors.Desktop;
            this.modifier.OnHoverTextColor = System.Drawing.Color.Black;
            this.modifier.selected = false;
            this.modifier.Size = new System.Drawing.Size(128, 39);
            this.modifier.TabIndex = 132;
            this.modifier.Text = "Modifier";
            this.modifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modifier.Textcolor = System.Drawing.Color.White;
            this.modifier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supprimer.BorderRadius = 7;
            this.supprimer.ButtonText = "Supprimer";
            this.supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supprimer.DisabledColor = System.Drawing.Color.Gray;
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Iconcolor = System.Drawing.Color.Transparent;
            this.supprimer.Iconimage = global::Projet.Properties.Resources._003_close_button;
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
            this.supprimer.Location = new System.Drawing.Point(357, 346);
            this.supprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supprimer.Name = "supprimer";
            this.supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.supprimer.OnHovercolor = System.Drawing.SystemColors.Desktop;
            this.supprimer.OnHoverTextColor = System.Drawing.Color.Black;
            this.supprimer.selected = false;
            this.supprimer.Size = new System.Drawing.Size(131, 39);
            this.supprimer.TabIndex = 131;
            this.supprimer.Text = "Supprimer";
            this.supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supprimer.Textcolor = System.Drawing.Color.White;
            this.supprimer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
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
            this.valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Iconcolor = System.Drawing.Color.Transparent;
            this.valider.Iconimage = global::Projet.Properties.Resources._004_bold_check_button;
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
            this.valider.Location = new System.Drawing.Point(206, 346);
            this.valider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valider.Name = "valider";
            this.valider.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.valider.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(43)))));
            this.valider.OnHoverTextColor = System.Drawing.Color.Black;
            this.valider.selected = false;
            this.valider.Size = new System.Drawing.Size(128, 39);
            this.valider.TabIndex = 129;
            this.valider.Text = "Valider";
            this.valider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valider.Textcolor = System.Drawing.Color.White;
            this.valider.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Click += new System.EventHandler(this.valider_Click);
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
            this.annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Iconcolor = System.Drawing.Color.Transparent;
            this.annuler.Iconimage = global::Projet.Properties.Resources._002_no_entry_sign;
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
            this.annuler.Location = new System.Drawing.Point(511, 347);
            this.annuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.annuler.Name = "annuler";
            this.annuler.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.annuler.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(43)))));
            this.annuler.OnHoverTextColor = System.Drawing.Color.Black;
            this.annuler.selected = false;
            this.annuler.Size = new System.Drawing.Size(128, 38);
            this.annuler.TabIndex = 130;
            this.annuler.Text = "Annuler";
            this.annuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.annuler.Textcolor = System.Drawing.Color.White;
            this.annuler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ttctxt
            // 
            this.ttctxt.AutoSize = true;
            this.ttctxt.Font = new System.Drawing.Font("Cambria", 12F);
            this.ttctxt.Location = new System.Drawing.Point(394, 131);
            this.ttctxt.Name = "ttctxt";
            this.ttctxt.Size = new System.Drawing.Size(0, 19);
            this.ttctxt.TabIndex = 128;
            // 
            // ht
            // 
            this.ht.AutoSize = true;
            this.ht.Font = new System.Drawing.Font("Cambria", 12F);
            this.ht.Location = new System.Drawing.Point(394, 72);
            this.ht.Name = "ht";
            this.ht.Size = new System.Drawing.Size(0, 19);
            this.ht.TabIndex = 126;
            // 
            // tvatxt
            // 
            this.tvatxt.AutoSize = true;
            this.tvatxt.Font = new System.Drawing.Font("Cambria", 12F);
            this.tvatxt.Location = new System.Drawing.Point(394, 101);
            this.tvatxt.Name = "tvatxt";
            this.tvatxt.Size = new System.Drawing.Size(0, 19);
            this.tvatxt.TabIndex = 127;
            // 
            // lignecmd
            // 
            this.lignecmd.AllowUserToAddRows = false;
            this.lignecmd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lignecmd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lignecmd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.lignecmd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.lignecmd.BackgroundColor = System.Drawing.Color.White;
            this.lignecmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lignecmd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lignecmd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lignecmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lignecmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.lignecmd.DoubleBuffered = true;
            this.lignecmd.EnableHeadersVisualStyles = false;
            this.lignecmd.GridColor = System.Drawing.Color.White;
            this.lignecmd.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.lignecmd.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lignecmd.Location = new System.Drawing.Point(19, 58);
            this.lignecmd.Name = "lignecmd";
            this.lignecmd.ReadOnly = true;
            this.lignecmd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lignecmd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.lignecmd.RowHeadersVisible = false;
            this.lignecmd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lignecmd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.lignecmd.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.lignecmd.Size = new System.Drawing.Size(359, 277);
            this.lignecmd.TabIndex = 81;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Libelle";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prix Unitaire";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 118;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 93;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 67;
            // 
            // voirlacommande
            // 
            this.voirlacommande.ActiveBorderThickness = 1;
            this.voirlacommande.ActiveCornerRadius = 20;
            this.voirlacommande.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.voirlacommande.ActiveForecolor = System.Drawing.Color.White;
            this.voirlacommande.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.voirlacommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.voirlacommande.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voirlacommande.BackgroundImage")));
            this.voirlacommande.ButtonText = "Voir la Commande";
            this.voirlacommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voirlacommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voirlacommande.ForeColor = System.Drawing.Color.SeaGreen;
            this.voirlacommande.IdleBorderThickness = 1;
            this.voirlacommande.IdleCornerRadius = 20;
            this.voirlacommande.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.voirlacommande.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.voirlacommande.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.voirlacommande.Location = new System.Drawing.Point(658, 337);
            this.voirlacommande.Margin = new System.Windows.Forms.Padding(5);
            this.voirlacommande.Name = "voirlacommande";
            this.voirlacommande.Size = new System.Drawing.Size(217, 84);
            this.voirlacommande.TabIndex = 113;
            this.voirlacommande.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.voirlacommande.Click += new System.EventHandler(this.voirlacommande_Click);
            // 
            // aliments
            // 
            this.aliments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.aliments.FormattingEnabled = true;
            this.aliments.ItemHeight = 29;
            this.aliments.Location = new System.Drawing.Point(42, 130);
            this.aliments.Name = "aliments";
            this.aliments.Size = new System.Drawing.Size(307, 323);
            this.aliments.TabIndex = 112;
            // 
            // commander
            // 
            this.commander.ActiveBorderThickness = 1;
            this.commander.ActiveCornerRadius = 20;
            this.commander.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.commander.ActiveForecolor = System.Drawing.Color.White;
            this.commander.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.commander.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.commander.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commander.BackgroundImage")));
            this.commander.ButtonText = "Commander";
            this.commander.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commander.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commander.ForeColor = System.Drawing.Color.SeaGreen;
            this.commander.IdleBorderThickness = 1;
            this.commander.IdleCornerRadius = 20;
            this.commander.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.commander.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.commander.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.commander.Location = new System.Drawing.Point(658, 250);
            this.commander.Margin = new System.Windows.Forms.Padding(5);
            this.commander.Name = "commander";
            this.commander.Size = new System.Drawing.Size(217, 84);
            this.commander.TabIndex = 111;
            this.commander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.commander.Click += new System.EventHandler(this.commander_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(552, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 18);
            this.label21.TabIndex = 109;
            this.label21.Text = "Type Aliment :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(108, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 32);
            this.label20.TabIndex = 108;
            this.label20.Text = "Menu";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(55)))));
            this.bunifuCards1.Controls.Add(this.imagealiment);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.prix);
            this.bunifuCards1.Controls.Add(this.qte);
            this.bunifuCards1.Controls.Add(this.linkLabel3);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.total);
            this.bunifuCards1.Controls.Add(this.label7);
            this.bunifuCards1.Controls.Add(this.imgtxt);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(415, 89);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(217, 388);
            this.bunifuCards1.TabIndex = 101;
            // 
            // imagealiment
            // 
            this.imagealiment.Location = new System.Drawing.Point(12, 37);
            this.imagealiment.Name = "imagealiment";
            this.imagealiment.Size = new System.Drawing.Size(193, 138);
            this.imagealiment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagealiment.TabIndex = 96;
            this.imagealiment.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 93;
            this.label4.Text = "Nom Aliment";
            // 
            // prix
            // 
            this.prix.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(43)))));
            this.prix.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.prix.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(43)))));
            this.prix.BorderThickness = 3;
            this.prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix.Enabled = false;
            this.prix.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prix.isPassword = false;
            this.prix.Location = new System.Drawing.Point(80, 178);
            this.prix.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(125, 43);
            this.prix.TabIndex = 92;
            this.prix.Text = "30.00 DH";
            this.prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prix.OnValueChanged += new System.EventHandler(this.prix_OnValueChanged);
            // 
            // qte
            // 
            this.qte.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(43)))));
            this.qte.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.qte.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(43)))));
            this.qte.BorderThickness = 3;
            this.qte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qte.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qte.isPassword = false;
            this.qte.Location = new System.Drawing.Point(125, 248);
            this.qte.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(68, 44);
            this.qte.TabIndex = 90;
            this.qte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qte.OnValueChanged += new System.EventHandler(this.qte_OnValueChanged);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel3.Location = new System.Drawing.Point(134, 217);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(73, 28);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 32);
            this.label5.TabIndex = 91;
            this.label5.Text = "Prix :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(31, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "Quantité :";
            // 
            // total
            // 
            this.total.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(43)))));
            this.total.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.total.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(43)))));
            this.total.BorderThickness = 3;
            this.total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.total.Enabled = false;
            this.total.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.total.isPassword = false;
            this.total.Location = new System.Drawing.Point(35, 334);
            this.total.Margin = new System.Windows.Forms.Padding(4);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(158, 45);
            this.total.TabIndex = 94;
            this.total.Tag = "";
            this.total.Text = "00 DH";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.label7.Location = new System.Drawing.Point(40, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 29);
            this.label7.TabIndex = 93;
            this.label7.Text = "Prix Total :";
            // 
            // imgtxt
            // 
            this.imgtxt.Location = new System.Drawing.Point(80, 72);
            this.imgtxt.Name = "imgtxt";
            this.imgtxt.Size = new System.Drawing.Size(39, 29);
            this.imgtxt.TabIndex = 114;
            this.imgtxt.TextChanged += new System.EventHandler(this.imgtxt_TextChanged);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.bunifuCards3.Controls.Add(this.bunifuImageButton6);
            this.bunifuCards3.Controls.Add(this.idaliment);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(3, 2);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(99, 93);
            this.bunifuCards3.TabIndex = 95;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.Image = global::Projet.Properties.Resources.menu__1_;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(93, 86);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton6.TabIndex = 108;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            // 
            // idaliment
            // 
            this.idaliment.Location = new System.Drawing.Point(30, 37);
            this.idaliment.Name = "idaliment";
            this.idaliment.Size = new System.Drawing.Size(28, 29);
            this.idaliment.TabIndex = 114;
            // 
            // typealiment
            // 
            this.typealiment.FormattingEnabled = true;
            this.typealiment.Location = new System.Drawing.Point(701, 39);
            this.typealiment.Name = "typealiment";
            this.typealiment.Size = new System.Drawing.Size(155, 29);
            this.typealiment.TabIndex = 93;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bunifuImageButton4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 31);
            this.panel1.TabIndex = 134;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = global::Projet.Properties.Resources._002_delete_button;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(626, 2);
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
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 31);
            this.panel5.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ma Commande";
            // 
            // modifierlacommande
            // 
            this.modifierlacommande.ActiveBorderThickness = 1;
            this.modifierlacommande.ActiveCornerRadius = 20;
            this.modifierlacommande.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.modifierlacommande.ActiveForecolor = System.Drawing.Color.White;
            this.modifierlacommande.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.modifierlacommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.modifierlacommande.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modifierlacommande.BackgroundImage")));
            this.modifierlacommande.ButtonText = "Modifier la commande ";
            this.modifierlacommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifierlacommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierlacommande.ForeColor = System.Drawing.Color.SeaGreen;
            this.modifierlacommande.IdleBorderThickness = 1;
            this.modifierlacommande.IdleCornerRadius = 20;
            this.modifierlacommande.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.modifierlacommande.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.modifierlacommande.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.modifierlacommande.Location = new System.Drawing.Point(658, 250);
            this.modifierlacommande.Margin = new System.Windows.Forms.Padding(5);
            this.modifierlacommande.Name = "modifierlacommande";
            this.modifierlacommande.Size = new System.Drawing.Size(217, 84);
            this.modifierlacommande.TabIndex = 115;
            this.modifierlacommande.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modifierlacommande.Visible = false;
            this.modifierlacommande.Click += new System.EventHandler(this.modifierlacommande_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 518);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.Restaurant_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.viewcommande.ResumeLayout(false);
            this.viewcommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lignecmd)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagealiment)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox typealiment;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox prix;
        private Bunifu.Framework.UI.BunifuMetroTextbox qte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuThinButton2 commander;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.PictureBox imagealiment;
        private System.Windows.Forms.TextBox imgtxt;
        private System.Windows.Forms.TextBox idaliment;
        private System.Windows.Forms.ListBox aliments;
        private Bunifu.Framework.UI.BunifuThinButton2 voirlacommande;
        private System.Windows.Forms.Panel viewcommande;
        private Bunifu.Framework.UI.BunifuCustomDataGrid lignecmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuFlatButton modifier;
        private Bunifu.Framework.UI.BunifuFlatButton supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton valider;
        private Bunifu.Framework.UI.BunifuFlatButton annuler;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdautrealiments;
        private System.Windows.Forms.Label ttctxt;
        private System.Windows.Forms.Label ht;
        private System.Windows.Forms.Label tvatxt;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 modifierlacommande;
    }
}