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
    public partial class PrintCommande : Form
    {

        
        SqlCommand comclient = new SqlCommand();
        string usertype;
        public PrintCommande(string usertype)
        {
            this.usertype = usertype;
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

        private void PrintCommande_Load(object sender, EventArgs e)
        {
            chqclient.Visible = false;
            imprimer.Visible = false;
            Connexion.ouvrirConnection();

            comclient.Connection = Connexion.cn;
            comclient = new SqlCommand("select * from utilisateur  where usertype ='client'", Connexion.cn);
            DataTable dt = new DataTable();
            SqlDataReader dr = comclient.ExecuteReader();
            dt.Load(dr);
            clients.DataSource = dt;
            clients.ValueMember = "username";
            clients.DisplayMember = "username";
            touslecommandes.Visible = false;
            Connexion.ouvrirConnection();
            SqlCommand com = new SqlCommand("prmcommande", Connexion.cn);
            com.CommandType = CommandType.StoredProcedure;
            DataTable dtt = new DataTable();
            SqlDataReader drr = com.ExecuteReader();
            dtt.Load(drr);
            touslecommandes.DataSource = dtt;
            touslecommandes.Update();
            touslecommandes.Refresh();
            Connexion.fermerConnection();
            

            //            dataGridView1.DataSource = bscom;
            //          dataGridView1.Update();
            //        dataGridView1.Refresh();
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            PageImprimerCommande pc = new PageImprimerCommande();
            pc.ShowDialog();
        }

        private void clients_SelectedIndexChanged(object sender, EventArgs e)
        {
           Connexion.ouvrirConnection();
            SqlCommand com = new SqlCommand("prcmd",Connexion.cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@username", SqlDbType.VarChar, 20);
            com.Parameters["@username"].Direction = ParameterDirection.Input;
            com.Parameters["@username"].Value = clients.Text;
            DataTable dt = new DataTable();
            SqlDataReader dr = com.ExecuteReader();
            dt.Load(dr);
            commandeparclient.DataSource = dt;
            commandeparclient.Update();
            commandeparclient.Refresh();
            Connexion.fermerConnection();
        }

        private void tscmd_Click(object sender, EventArgs e)
        {
            chqclient.Visible = true;
            touslecommandes.Visible = true;
            clients.Enabled = false;
        }

        private void chqclient_Click(object sender, EventArgs e)
        {
            touslecommandes.Visible = false;
            chqclient.Visible = false;
            clients.Enabled = true;
        }
    }
}
