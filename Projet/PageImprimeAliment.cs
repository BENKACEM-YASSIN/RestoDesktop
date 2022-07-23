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
    public partial class PageImprimeAliment : Form
    {
        public PageImprimeAliment()
        {
            InitializeComponent();
        }

        private void ImprimerAliment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetKBv2DataSet.aliments' table. You can move, or remove it, as needed.
            this.alimentsTableAdapter.Fill(this.projetKBv2DataSet.aliments);
            alimentrpt rapalim = new alimentrpt();
            rapalim.SetDataSource(projetKBv2DataSet.Tables["aliments"]);
            crystalReportViewer1.ReportSource = rapalim;
        }

        private void alimentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alimentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetKBv2DataSet);

        }
    }
}
