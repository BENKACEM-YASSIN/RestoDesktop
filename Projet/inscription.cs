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
    public partial class inscription : MetroFramework.Forms.MetroForm
    {
        SqlCommand com = new SqlCommand();
        SqlDataAdapter dauser = new SqlDataAdapter();
        DataTable dtuser = new DataTable();
        SqlCommandBuilder cb;
        BindingSource bnuser = new BindingSource();
        public inscription()
        {
            InitializeComponent();
        }

        private void inscription_Load(object sender, EventArgs e)
        {
            check.Visible = false;
            Connexion.ouvrirConnection();

            com.Connection = Connexion.cn;
            com.CommandText = "select * from utilisateur";
            dauser = new SqlDataAdapter(com);
            cb = new SqlCommandBuilder(dauser);
            if (!Connexion.ds.Tables.Contains("utilisateur"))
                dauser.Fill(Connexion.ds, "utilisateur");

            Connexion.fermerConnection();
            dtuser = Connexion.ds.Tables["utilisateur"];
            bnuser.DataSource = dtuser;
            username.DataBindings.Add("Text", bnuser, "username");
            mdp.DataBindings.Add("Text", bnuser, "motdepasse");
            nom.DataBindings.Add("Text", bnuser, "nom");
            prenom.DataBindings.Add("Text", bnuser, "prenom");
            email.DataBindings.Add("Text", bnuser, "email");
            client.DataBindings.Add("Text", bnuser, "usertype");
        }

        private void signup_Click(object sender, EventArgs e)
        {
            bnuser.AddNew();
            client.Text = "client";
            signup.Visible = false;
            check.Visible = true;
        }

        private void check_Click(object sender, EventArgs e)
        {
            bnuser.EndEdit();
            this.Close();
        }

        private void inscription_FormClosing(object sender, FormClosingEventArgs e)
        {
            dauser.Update(dtuser);
        }
    }
}
