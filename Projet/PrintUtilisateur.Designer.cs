namespace Projet
{
    partial class PrintUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintUtilisateur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imprimer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.users = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.imprimer1user = new Bunifu.Framework.UI.BunifuThinButton2();
            this.projetKBv2DataSet = new Projet.projetKBv2DataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new Projet.projetKBv2DataSetTableAdapters.utilisateurTableAdapter();
            this.tableAdapterManager = new Projet.projetKBv2DataSetTableAdapters.TableAdapterManager();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetKBv2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.imprimer.Location = new System.Drawing.Point(353, 325);
            this.imprimer.Margin = new System.Windows.Forms.Padding(5);
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(217, 49);
            this.imprimer.TabIndex = 113;
            this.imprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
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
            this.panel4.Size = new System.Drawing.Size(696, 32);
            this.panel4.TabIndex = 114;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = global::Projet.Properties.Resources._001_remove;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(600, 3);
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
            this.bunifuImageButton4.Location = new System.Drawing.Point(648, 5);
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
            this.panel5.Size = new System.Drawing.Size(147, 31);
            this.panel5.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "imprimer les Urilisateur";
            // 
            // users
            // 
            this.users.AllowUserToAddRows = false;
            this.users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.users.BackgroundColor = System.Drawing.Color.White;
            this.users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users.DoubleBuffered = true;
            this.users.EnableHeadersVisualStyles = false;
            this.users.GridColor = System.Drawing.Color.White;
            this.users.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.users.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.users.Location = new System.Drawing.Point(12, 116);
            this.users.Name = "users";
            this.users.ReadOnly = true;
            this.users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.users.RowHeadersVisible = false;
            this.users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.users.Size = new System.Drawing.Size(664, 190);
            this.users.TabIndex = 115;
            // 
            // imprimer1user
            // 
            this.imprimer1user.ActiveBorderThickness = 1;
            this.imprimer1user.ActiveCornerRadius = 20;
            this.imprimer1user.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.imprimer1user.ActiveForecolor = System.Drawing.Color.White;
            this.imprimer1user.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.imprimer1user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.imprimer1user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imprimer1user.BackgroundImage")));
            this.imprimer1user.ButtonText = "Un utilisateur";
            this.imprimer1user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imprimer1user.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimer1user.ForeColor = System.Drawing.Color.SeaGreen;
            this.imprimer1user.IdleBorderThickness = 1;
            this.imprimer1user.IdleCornerRadius = 20;
            this.imprimer1user.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.imprimer1user.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.imprimer1user.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.imprimer1user.Location = new System.Drawing.Point(107, 325);
            this.imprimer1user.Margin = new System.Windows.Forms.Padding(5);
            this.imprimer1user.Name = "imprimer1user";
            this.imprimer1user.Size = new System.Drawing.Size(217, 49);
            this.imprimer1user.TabIndex = 116;
            this.imprimer1user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imprimer1user.Click += new System.EventHandler(this.imprimer1user_Click);
            // 
            // projetKBv2DataSet
            // 
            this.projetKBv2DataSet.DataSetName = "projetKBv2DataSet";
            this.projetKBv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.projetKBv2DataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alimentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.commandeTableAdapter = null;
            this.tableAdapterManager.ligneTableAdapter = null;
            this.tableAdapterManager.typealimentTableAdapter = null;
            this.tableAdapterManager.typeutilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet.projetKBv2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = this.utilisateurTableAdapter;
            // 
            // PrintUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(696, 399);
            this.Controls.Add(this.imprimer1user);
            this.Controls.Add(this.users);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.imprimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintUtilisateur";
            this.Load += new System.EventHandler(this.PrintUtilisateur_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetKBv2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 imprimer;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid users;
        private Bunifu.Framework.UI.BunifuThinButton2 imprimer1user;
        private projetKBv2DataSet projetKBv2DataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private projetKBv2DataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private projetKBv2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}