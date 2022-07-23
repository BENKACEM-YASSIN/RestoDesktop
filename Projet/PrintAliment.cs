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
    public partial class PrintAliment : Form
    {
        SqlCommand comalim = new SqlCommand();
        SqlDataAdapter sdaalim = new SqlDataAdapter();
        DataTable dtaalim = new DataTable();
        SqlDataAdapter sdatyplealim = new SqlDataAdapter();
        BindingSource bsalim;
        
       
        public PrintAliment()
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

        private void PrintAliment_Load(object sender, EventArgs e)
        {
            Connexion.ouvrirConnection();
            comalim = new SqlCommand();
            comalim.CommandText = "select * from aliments";
            comalim.Connection = Connexion.cn;
            sdaalim = new SqlDataAdapter(comalim);
            if (!Connexion.ds.Tables.Contains("aliments"))
                sdaalim.Fill(Connexion.ds, "aliments");
            dtaalim = Connexion.ds.Tables["aliments"];
            Connexion.fermerConnection();

            bsalim = new BindingSource();
            bsalim.DataSource = Connexion.ds;
            bsalim.DataMember = "aliments";
            dataGridView1.DataSource = bsalim;
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            PageImprimeAliment imal = new PageImprimeAliment();
            imal.ShowDialog();
        }
    }
}
