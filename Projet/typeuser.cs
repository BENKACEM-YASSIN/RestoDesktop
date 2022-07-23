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
    public partial class typeuser : Form
    {
        bool cls = true;
        SqlCommand comtypuser = new SqlCommand();
        SqlDataAdapter sdatypuser;
        DataTable dtypuser = new DataTable();
        SqlCommandBuilder cmbd;
        DataView dvtypuser = new DataView();
        BindingSource bstypuser = new BindingSource();
        private void activer(bool v)
        {
            panel1.Enabled = !v;
            typealimet.Enabled = v;
            ajouter.Enabled = !v;
            modifier.Enabled = !v;
            supprimer.Enabled = !v;
            annuler.Enabled = v;
            valider.Enabled = v;

        }
        public typeuser()
        {
            InitializeComponent();
        }

        private void typeuser_Load(object sender, EventArgs e)
        {
            Connexion.ouvrirConnection();
            comtypuser.Connection = Connexion.cn;
            comtypuser.CommandText = "select * from typeutilisateur";

            sdatypuser = new SqlDataAdapter(comtypuser);
            if (!Connexion.ds.Tables.Contains("typeutilisateur"))
                sdatypuser.Fill(Connexion.ds, "typeutilisateur");

            Connexion.fermerConnection();
            dtypuser = Connexion.ds.Tables["typeutilisateur"];
            dvtypuser = dtypuser.DefaultView;
            bstypuser.DataSource = dtypuser;
            listBox1.DataSource = bstypuser;
            listBox1.ValueMember = "usertype";
            listBox1.DisplayMember = "usertype";

            typealimet.DataBindings.Add("text", bstypuser, "usertype");

            annuler.Enabled = false;
            valider.Enabled = false;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            bstypuser.AddNew();
            activer(true);
            cls = false;
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            activer(true);
            cls = false;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous supprimer cet élément ?", "supprimer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bstypuser.RemoveCurrent();
                cls = false;

            }
        }

        private void valider_Click(object sender, EventArgs e)
        {
            bstypuser.CancelEdit();
            activer(false);
        }

        private void annuler_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rech_Click(object sender, EventArgs e)
        {
            if (textrech.text == "" || textrech.text == "Recherch par le nom")
                MessageBox.Show("sisair le nom qui rechercher");

            else
                dvtypuser.RowFilter = "usertype like '%" + textrech.text + "%'";
        }

        private void textrech_OnTextChange(object sender, EventArgs e)
        {
            if (textrech.text == "" || textrech.text == "Recherch par le nom")
                dvtypuser.RowFilter = "usertype like '%'";
        }

        private void typeuser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cls)
            {
                if (MessageBox.Show("Voulez-vous enregistrer les données dans le serveur ?", "Enregiistrer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        cmbd = new SqlCommandBuilder(sdatypuser);
                        sdatypuser.Update(Connexion.ds, "typeutilisateur");
                        MessageBox.Show("Enregistrement est terminer");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
