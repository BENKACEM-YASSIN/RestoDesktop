namespace Projet
{
    partial class PageImprimeAliment
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
            this.alimentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alimentsTableAdapter = new Projet.projetKBv2DataSetTableAdapters.alimentsTableAdapter();
            this.tableAdapterManager = new Projet.projetKBv2DataSetTableAdapters.TableAdapterManager();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.projetKBv2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projetKBv2DataSet
            // 
            this.projetKBv2DataSet.DataSetName = "projetKBv2DataSet";
            this.projetKBv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alimentsBindingSource
            // 
            this.alimentsBindingSource.DataMember = "aliments";
            this.alimentsBindingSource.DataSource = this.projetKBv2DataSet;
            // 
            // alimentsTableAdapter
            // 
            this.alimentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alimentsTableAdapter = this.alimentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.commandeTableAdapter = null;
            this.tableAdapterManager.ligneTableAdapter = null;
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
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // PageImprimeAliment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 459);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "PageImprimeAliment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImprimerAliment";
            this.Load += new System.EventHandler(this.ImprimerAliment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetKBv2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private projetKBv2DataSet projetKBv2DataSet;
        private System.Windows.Forms.BindingSource alimentsBindingSource;
        private projetKBv2DataSetTableAdapters.alimentsTableAdapter alimentsTableAdapter;
        private projetKBv2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

    }
}