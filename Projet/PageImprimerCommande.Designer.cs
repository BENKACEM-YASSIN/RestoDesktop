namespace Projet
{
    partial class PageImprimerCommande
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
            this.projetKBv2DataSet = new Projet.projetKBv2DataSet();
            this.ligneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligneTableAdapter = new Projet.projetKBv2DataSetTableAdapters.ligneTableAdapter();
            this.tableAdapterManager = new Projet.projetKBv2DataSetTableAdapters.TableAdapterManager();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.projetKBv2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projetKBv2DataSet
            // 
            this.projetKBv2DataSet.DataSetName = "projetKBv2DataSet";
            this.projetKBv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ligneBindingSource
            // 
            this.ligneBindingSource.DataMember = "ligne";
            this.ligneBindingSource.DataSource = this.projetKBv2DataSet;
            // 
            // ligneTableAdapter
            // 
            this.ligneTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alimentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.commandeTableAdapter = null;
            this.tableAdapterManager.ligneTableAdapter = this.ligneTableAdapter;
            this.tableAdapterManager.typealimentTableAdapter = null;
            this.tableAdapterManager.typeutilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet.projetKBv2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(780, 459);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // PageImprimerCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 459);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "PageImprimerCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageImprimerCommande";
            this.Load += new System.EventHandler(this.PageImprimerCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetKBv2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private projetKBv2DataSet projetKBv2DataSet;
        private System.Windows.Forms.BindingSource ligneBindingSource;
        private projetKBv2DataSetTableAdapters.ligneTableAdapter ligneTableAdapter;
        private projetKBv2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}