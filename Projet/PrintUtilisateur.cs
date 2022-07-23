using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet
{
    public partial class PrintUtilisateur : Form
    {
        SqlCommand comclient = new SqlCommand();
        SqlDataAdapter daclient;
        DataTable dtclient = new DataTable();
        BindingSource bsclient;

        public PrintUtilisateur()
        {
            InitializeComponent();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PrintUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetKBv2DataSet.utilisateur' table. You can move, or remove it, as needed.
            this.utilisateurTableAdapter.Fill(this.projetKBv2DataSet.utilisateur);
            Connexion.ouvrirConnection();
            comclient.Connection = Connexion.cn;
            comclient.CommandText = "select * from utilisateur";
            daclient = new SqlDataAdapter(comclient);
            if (!Connexion.ds.Tables.Contains("utilisateur"))
                daclient.Fill(Connexion.ds, "utilisateur");

            dtclient = Connexion.ds.Tables["utilisateur"];

            Connexion.fermerConnection();
            bsclient = new BindingSource();
            bsclient.DataSource = Connexion.ds; ;
            bsclient.DataMember = "utilisateur";
            users.DataSource = bsclient;

           
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            utilisateursrpt rapuser = new utilisateursrpt();
            rapuser.SetDataSource(projetKBv2DataSet.Tables["utilisateur"]);
            PageImprimerUser pu = new PageImprimerUser("",rapuser);
            pu.ShowDialog();
        }

        private void imprimer1user_Click(object sender, EventArgs e)
        {
            string filtrer = "{utilisateur.username} = " + users.CurrentRow.Cells[0].Value.ToString();
            userrpt u = new userrpt();
            u.SetDataSource(projetKBv2DataSet.Tables["utilisateur"]);
            PageImprimerUser pu = new PageImprimerUser(filtrer,u);
            pu.ShowDialog();
        }

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetKBv2DataSet);

        }
    }
}
