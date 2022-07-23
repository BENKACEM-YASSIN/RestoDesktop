using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class PageImprimerCommande : Form
    {
        public PageImprimerCommande()
        {
            InitializeComponent();
        }

 

        private void PageImprimerCommande_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetKBv2DataSet.ligne' table. You can move, or remove it, as needed.
            this.ligneTableAdapter.Fill(this.projetKBv2DataSet.ligne);
            // TODO: This line of code loads data into the 'projetKBv2DataSet.commande' table. You can move, or remove it, as needed.
            commanedrpt rpcmd = new commanedrpt();
            rpcmd.SetDataSource(projetKBv2DataSet.Tables["ligne"]);
            crystalReportViewer1.ReportSource = rpcmd;

        }

        private void ligneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ligneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetKBv2DataSet);

        }
    }
}
