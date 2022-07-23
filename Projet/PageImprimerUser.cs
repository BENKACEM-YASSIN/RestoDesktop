using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Projet
{
    public partial class PageImprimerUser : Form
    {
        string filtrer;
        ReportClass l;
        public PageImprimerUser(string filtrer,ReportClass l)
        {
            this.filtrer = filtrer;
            this.l = l;
            InitializeComponent();
        }


        private void PageImprimerUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetKBv2DataSet.utilisateur' table. You can move, or remove it, as needed.
            this.utilisateurTableAdapter.Fill(this.projetKBv2DataSet.utilisateur);
          
           
            if (filtrer!= "")
            {
                
                 crystalReportViewer1.SelectionFormula = filtrer;
            }
            
                crystalReportViewer1.ReportSource = l;
        }

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetKBv2DataSet);

        }
    }
}
