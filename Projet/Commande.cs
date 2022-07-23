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
    public partial class Commande : Form
    {

        SqlCommand com;


        private void activer(bool v)
        {

            // utilisateur.Enabled = v;

            // utilisateur.Enabled = v;
            ajouter.Enabled = !v;
            annuler.Enabled = v;
            valider.Enabled = v;
            lignecmd.Refresh();
            lignecmd.Update();

        }
        string usertype;
        public Commande(string usertype)
        {
            this.usertype= usertype;
            InitializeComponent();
        }

        private void Commande_Load(object sender, EventArgs e)
        {
         
            Connexion.fermerConnection();
            ht.Text = "le Prix Hors Tax :";
            tvatxt.Text = "La TVA 20% :";
            ttctxt.Text = "La toute Tax Comprise : ";
            //table commande
            com = new SqlCommand("", Connexion.cn);
            Connexion.ouvrirConnection();
            aliments.Items.Clear();
            string chaine = "select libaliment from aliments";
            com.CommandText = chaine;
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                aliments.Items.Add(dr["libaliment"].ToString());
            }
            dr.Close();

            utilisateur.Items.Clear();
            chaine = "select nom,prenom,usertype from utilisateur";
            com.CommandText = chaine;
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (dr["usertype"].ToString().Equals("client"))
                    utilisateur.Items.Add(dr["nom"].ToString() + " " + dr["prenom"].ToString());
            }
            if (lignecmd.Rows.Count == 1)
            {
                supprimer.Enabled = false;
            }
            dr.Close();
            Connexion.fermerConnection();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textrech_OnTextChange(object sender, EventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            lignecmd.ReadOnly = false;
           
        }


        private void valider_Click_1(object sender, EventArgs e)
        {
            string[] vals = utilisateur.Text.Split(' ');
            Connexion.ouvrirConnection();
            string chaine = "select username from utilisateur where nom='" + vals[0] + "' and prenom='" + vals[1] + "'";
            com.CommandText = chaine;
            string username = com.ExecuteScalar().ToString();

            chaine = "insert into commande values('" + DateTime.Now + "','" + username + "')";
            com.CommandText = chaine;
            com.ExecuteNonQuery();

            chaine = "select max(idcommande) from commande ";
            com.CommandText = chaine;
            string idcommande = com.ExecuteScalar().ToString();

            for (int i = 0; i < lignecmd.Rows.Count; i++)
            {
                chaine = "select alimentid from aliments where libaliment='" + lignecmd.Rows[i].Cells[0].Value.ToString() + "'";
                com.CommandText = chaine;
                string ida = com.ExecuteScalar().ToString();

                chaine = "insert into ligne values(" + ida + "," + idcommande + "," + lignecmd.Rows[i].Cells[2].Value.ToString() + ")";
                com.CommandText = chaine;
                com.ExecuteNonQuery();
            }
            Connexion.fermerConnection();
            aliments.Text = "";
            float cr = 0;
            qte.Text += cr.ToString();
            lignecmd.Rows.Clear();
            utilisateur.Enabled = true;
            ht.Text = "le Prix Hors Tax :";
            tvatxt.Text = "La TVA 20% :";
            ttctxt.Text = "La toute Tax Comprise : ";
            lignecmd.ReadOnly = true;
        }

        private void annuler_Click_1(object sender, EventArgs e)
        {
            aliments.Text = "";
            float cr = 0;
            qte.Text += cr.ToString();
            lignecmd.Rows.Clear();
            utilisateur.Enabled = true;
            ht.Text = "le Prix Hors Tax :";
            tvatxt.Text = "La TVA 20% :";
            ttctxt.Text = "La toute Tax Comprise : ";
            
        }

        private void ajouter_Click_1(object sender, EventArgs e)
        {
            Connexion.ouvrirConnection();
            string chaine = "select prix from aliments where libaliment='" + aliments.Text + "'";
            com.CommandText = chaine;
            float prix = float.Parse(com.ExecuteScalar().ToString());
            int qt = int.Parse(qte.Text);
            string total = (qt * prix).ToString();
            lignecmd.Rows.Add(aliments.Text, prix.ToString(), qt.ToString(), (qt * prix).ToString());
            float somme = float.Parse(total.ToString());
            for (int i = 0; i < lignecmd.Rows.Count ; i++)
            {
                somme += float.Parse(lignecmd.Rows[i].Cells[3].Value.ToString());
            }
            double tva = somme * 0.2;
            double ttc = tva + somme;
            ht.Text = "le Prix Hors Tax : " + somme.ToString() + " DH";
            tvatxt.Text = "La TVA 20% : " + tva.ToString() + " DH";
            ttctxt.Text = "La toute Tax Comprise : " + ttc.ToString() + " DH";

            Connexion.fermerConnection();
            if (lignecmd.Rows.Count == 1)
            {
                supprimer.Enabled = false;
            }
            else
            {
                supprimer.Enabled = true;
            }
            
        }

        private void aliments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connexion.ouvrirConnection();
            utilisateur.Enabled = false;
            string chaine = "select prix from aliments where libaliment='" + aliments.Text + "'";
            com.CommandText = chaine;
            String prix = com.ExecuteScalar().ToString();
            pu.Text = "Prix unitaire = " + prix + " Dh";
            Connexion.fermerConnection();
        }

        private void qte_TextChanged(object sender, EventArgs e)
        {
            float cr = 0;
            if (aliments.Text == "")
            {
                MessageBox.Show("Veuillez choisir l'aliment s'il vous plaît");
                qte.Clear();
            }
            else
            {
                Connexion.ouvrirConnection();
                string chaine = "select prix from aliments where libaliment='" + aliments.Text + "'";
                com.CommandText = chaine;
                if (qte.Text == "")
                {
                    qte.Text += cr.ToString();
                }
                float prix = float.Parse(com.ExecuteScalar().ToString());
                int qt = int.Parse(qte.Text);
                tot.Text = "Total ligne = " + (qt * prix).ToString() + " Dh";



            }
        }

        private void utilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] vals = utilisateur.Text.Split(' ');
            Connexion.ouvrirConnection();
            string chaine = "select username from utilisateur where nom='" + vals[0] + "' and prenom='" + vals[1] + "'";
            com.CommandText = chaine;
            string username = com.ExecuteScalar().ToString();
            Connexion.fermerConnection();
        }

        private void modifier_Click_1(object sender, EventArgs e)
        {
            lignecmd.ReadOnly = false;
            

        }

        private void supprimer_Click(object sender, EventArgs e)
        {

            lignecmd.Rows.RemoveAt(lignecmd.CurrentRow.Index);
            if (lignecmd.Rows.Count == 1)
            {
                supprimer.Enabled = false;
            }
            
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            PrintCommande pcom = new PrintCommande(usertype);
            pcom.ShowDialog();
        }
    }
}
