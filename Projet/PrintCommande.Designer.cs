namespace Projet
{
    partial class PrintCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintCommande));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.commandeparclient = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.imprimer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.clients = new MetroFramework.Controls.MetroComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tscmd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.touslecommandes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.chqclient = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandeparclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touslecommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.bunifuImageButton3);
            this.panel4.Controls.Add(this.bunifuImageButton4);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(713, 31);
            this.panel4.TabIndex = 114;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = global::Projet.Properties.Resources._001_remove;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(623, -1);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(41, 28);
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
            this.bunifuImageButton4.Location = new System.Drawing.Point(670, 0);
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
            this.label8.Size = new System.Drawing.Size(144, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "imprimer les Commande";
            // 
            // commandeparclient
            // 
            this.commandeparclient.AllowUserToAddRows = false;
            this.commandeparclient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.commandeparclient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.commandeparclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.commandeparclient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.commandeparclient.BackgroundColor = System.Drawing.Color.White;
            this.commandeparclient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commandeparclient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commandeparclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.commandeparclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commandeparclient.DoubleBuffered = true;
            this.commandeparclient.EnableHeadersVisualStyles = false;
            this.commandeparclient.GridColor = System.Drawing.Color.White;
            this.commandeparclient.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.commandeparclient.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.commandeparclient.Location = new System.Drawing.Point(5, 99);
            this.commandeparclient.Name = "commandeparclient";
            this.commandeparclient.ReadOnly = true;
            this.commandeparclient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commandeparclient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.commandeparclient.RowHeadersVisible = false;
            this.commandeparclient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandeparclient.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.commandeparclient.Size = new System.Drawing.Size(696, 222);
            this.commandeparclient.TabIndex = 116;
            // 
            // imprimer
            // 
            this.imprimer.ActiveBorderThickness = 1;
            this.imprimer.ActiveCornerRadius = 20;
            this.imprimer.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.imprimer.ActiveForecolor = System.Drawing.Color.White;
            this.imprimer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.imprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.imprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imprimer.BackgroundImage")));
            this.imprimer.ButtonText = "Imprimer";
            this.imprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimer.ForeColor = System.Drawing.Color.SeaGreen;
            this.imprimer.IdleBorderThickness = 1;
            this.imprimer.IdleCornerRadius = 20;
            this.imprimer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.imprimer.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.imprimer.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.imprimer.Location = new System.Drawing.Point(284, 392);
            this.imprimer.Margin = new System.Windows.Forms.Padding(5);
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(217, 49);
            this.imprimer.TabIndex = 113;
            this.imprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // clients
            // 
            this.clients.FormattingEnabled = true;
            this.clients.ItemHeight = 23;
            this.clients.Location = new System.Drawing.Point(227, 64);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(217, 29);
            this.clients.TabIndex = 117;
            this.clients.UseSelectable = true;
            this.clients.SelectedIndexChanged += new System.EventHandler(this.clients_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(131, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 18);
            this.label21.TabIndex = 118;
            this.label21.Text = "Client :";
            // 
            // tscmd
            // 
            this.tscmd.ActiveBorderThickness = 1;
            this.tscmd.ActiveCornerRadius = 20;
            this.tscmd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.tscmd.ActiveForecolor = System.Drawing.Color.White;
            this.tscmd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.tscmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.tscmd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tscmd.BackgroundImage")));
            this.tscmd.ButtonText = "Tous les clients";
            this.tscmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tscmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tscmd.ForeColor = System.Drawing.Color.SeaGreen;
            this.tscmd.IdleBorderThickness = 1;
            this.tscmd.IdleCornerRadius = 20;
            this.tscmd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.tscmd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.tscmd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.tscmd.Location = new System.Drawing.Point(284, 342);
            this.tscmd.Margin = new System.Windows.Forms.Padding(5);
            this.tscmd.Name = "tscmd";
            this.tscmd.Size = new System.Drawing.Size(217, 49);
            this.tscmd.TabIndex = 119;
            this.tscmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tscmd.Click += new System.EventHandler(this.tscmd_Click);
            // 
            // touslecommandes
            // 
            this.touslecommandes.AllowUserToAddRows = false;
            this.touslecommandes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.touslecommandes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.touslecommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.touslecommandes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.touslecommandes.BackgroundColor = System.Drawing.Color.White;
            this.touslecommandes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.touslecommandes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.touslecommandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.touslecommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.touslecommandes.DoubleBuffered = true;
            this.touslecommandes.EnableHeadersVisualStyles = false;
            this.touslecommandes.GridColor = System.Drawing.Color.White;
            this.touslecommandes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.touslecommandes.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.touslecommandes.Location = new System.Drawing.Point(5, 99);
            this.touslecommandes.Name = "touslecommandes";
            this.touslecommandes.ReadOnly = true;
            this.touslecommandes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.touslecommandes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.touslecommandes.RowHeadersVisible = false;
            this.touslecommandes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touslecommandes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.touslecommandes.Size = new System.Drawing.Size(696, 222);
            this.touslecommandes.TabIndex = 120;
            // 
            // chqclient
            // 
            this.chqclient.ActiveBorderThickness = 1;
            this.chqclient.ActiveCornerRadius = 20;
            this.chqclient.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.chqclient.ActiveForecolor = System.Drawing.Color.White;
            this.chqclient.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.chqclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.chqclient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chqclient.BackgroundImage")));
            this.chqclient.ButtonText = "Chaque client";
            this.chqclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chqclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chqclient.ForeColor = System.Drawing.Color.SeaGreen;
            this.chqclient.IdleBorderThickness = 1;
            this.chqclient.IdleCornerRadius = 20;
            this.chqclient.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.chqclient.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.chqclient.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.chqclient.Location = new System.Drawing.Point(284, 342);
            this.chqclient.Margin = new System.Windows.Forms.Padding(5);
            this.chqclient.Name = "chqclient";
            this.chqclient.Size = new System.Drawing.Size(217, 49);
            this.chqclient.TabIndex = 121;
            this.chqclient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chqclient.Click += new System.EventHandler(this.chqclient_Click);
            // 
            // PrintCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(713, 442);
            this.Controls.Add(this.chqclient);
            this.Controls.Add(this.touslecommandes);
            this.Controls.Add(this.tscmd);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.commandeparclient);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.imprimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintCommande";
            this.Load += new System.EventHandler(this.PrintCommande_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandeparclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touslecommandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid commandeparclient;
        private Bunifu.Framework.UI.BunifuThinButton2 imprimer;
        private MetroFramework.Controls.MetroComboBox clients;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuThinButton2 tscmd;
        private Bunifu.Framework.UI.BunifuCustomDataGrid touslecommandes;
        private Bunifu.Framework.UI.BunifuThinButton2 chqclient;
    }
}