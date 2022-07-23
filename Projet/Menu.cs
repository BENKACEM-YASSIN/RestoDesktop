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
    public partial class Menu : Form
    {
        string username;
        SqlCommand com = new SqlCommand();
        SqlCommand comalim = new SqlCommand();
        SqlCommand comatyplim = new SqlCommand();
        SqlDataAdapter sdaalim = new SqlDataAdapter();
        DataTable dtaalim = new DataTable();
        DataTable dttypeaalim = new DataTable();
        SqlDataAdapter sdatyplealim = new SqlDataAdapter();
        BindingSource bsalim = new BindingSource();
        BindingSource bstyp = new BindingSource();
        public Menu(string username)
        {
            this.username = username;
            InitializeComponent();
        }

      
        private void Restaurant_Load(object sender, EventArgs e)
        {
            viewcommande.Visible = false;
            Connexion.fermerConnection();
            Connexion.ouvrirConnection();

           
            comalim.CommandText = "select * from aliments";
            comalim.Connection = Connexion.cn;

            
            comatyplim.CommandText = "select * from typealiment";
            comatyplim.Connection = Connexion.cn;

            sdaalim = new SqlDataAdapter(comalim);
            if (!Connexion.ds.Tables.Contains("aliments"))
                sdaalim.Fill(Connexion.ds, "aliments");


            sdatyplealim = new SqlDataAdapter(comatyplim);
            if (!Connexion.ds.Tables.Contains("typealiment"))
                sdatyplealim.Fill(Connexion.ds, "typealiment");


            dttypeaalim = Connexion.ds.Tables["typealiment"];
            dtaalim = Connexion.ds.Tables["aliments"];

            Connexion.fermerConnection();

            DataColumn c1 = dttypeaalim.Columns["typealim"];
            DataColumn c2 = dtaalim.Columns["typealim"];

            DataRelation RelAlimType = new DataRelation("rel_alim_type", c1, c2);
            if (!Connexion.ds.Relations.Contains("rel_alim_type"))
                Connexion.ds.Relations.Add(RelAlimType);

            bstyp.DataSource = Connexion.ds;
            bstyp.DataMember = "typealiment";
            typealiment.DataSource = bstyp;
            typealiment.ValueMember = "typealim";
            typealiment.DisplayMember = "typealim";

            bsalim.DataSource = bstyp;
            bsalim.DataMember = "rel_alim_type";
            aliments.DataSource = bsalim;
            aliments.ValueMember = "alimentid";
            aliments.DisplayMember = "libaliment";
            imgtxt.DataBindings.Add("Text", bsalim, "img");
            imagealiment.Load("imagealiment/" + imgtxt.Text);
            prix.DataBindings.Add("Text", bsalim, "prix");
            idaliment.DataBindings.Add("Text", bsalim, "alimentid");
            aliments.Update();
            aliments.Refresh();

           

        }

        private void commander_Click(object sender, EventArgs e)
        {

            if (qte.Text == "0")
            {
                MessageBox.Show("il faut remplir la quantité", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tot = total.Text;
                tot = tot.Remove(tot.LastIndexOf("DH"));
                MessageBox.Show("l'aliment a été bien ajouter à la commande");
                lignecmd.Rows.Add(aliments.Text, prix.Text, qte.Text, tot.ToString());
                float pr = float.Parse(prix.Text);
                float qt = float.Parse(qte.Text);
                float somme = (pr * qt);
                for (int i = 0; i < lignecmd.Rows.Count - 1; i++)
                {
                    float var = float.Parse(lignecmd.Rows[i].Cells[3].Value.ToString());
                    somme += var;
                }
                double tva = somme * 0.2;
                double ttc = tva + somme;
                ht.Text = "le Prix Hors Tax : " + somme.ToString() + " DH";
                tvatxt.Text = "La TVA 20% : " + tva.ToString() + " DH";
                ttctxt.Text = "La toute Tax Comprise : " + ttc.ToString() + " DH";
            }

        }

        private void qte_OnValueChanged(object sender, EventArgs e)
        {
            float cr = 0;
            
            if (qte.Text == "")
            {
                qte.Text += cr.ToString();
            }
            else
            {
                
            float pr = float.Parse(prix.Text);
            int qt = int.Parse(qte.Text);
            total.Text = (qt * pr).ToString() + " DH";
            }
           
        }

        private void imgtxt_TextChanged(object sender, EventArgs e)
        {
            if (imgtxt.Text == "")
            {
                imgtxt.Text = "aliment.png";
                imagealiment.Load("imagealiment/" + imgtxt.Text);
            }
            else
            {
                imagealiment.Load("imagealiment/" + imgtxt.Text);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void valider_Click(object sender, EventArgs e)
        {
            Connexion.ouvrirConnection();
            if (qte.Text == "")
            {
                MessageBox.Show("Il faut remplir la quantité ! ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Confirmez-vous votre commande ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string chaine = "insert into commande values('" + DateTime.Now + "','" + username + "')";
                    com.Connection = Connexion.cn;
                    com.CommandText = chaine;
                    com.ExecuteNonQuery();

                    chaine = "select max(idcommande) from commande";
                    com.CommandText = chaine;
                    string idcommande = com.ExecuteScalar().ToString();
                    chaine = "insert into ligne values(" + idaliment.Text + "," + idcommande + "," + qte.Text + ")";
                    com.CommandText = chaine;
                    com.ExecuteNonQuery();
                    lignecmd.Rows.Clear();
                    Connexion.fermerConnection();
                }
                else
                {
                    MessageBox.Show("Vous Pouvez faire une autre commande :D");
                }
            }
        }

        private void cmdautrealiments_Click(object sender, EventArgs e)
        {
            viewcommande.Visible = false;
        }

        private void voirlacommande_Click(object sender, EventArgs e)
        {
            viewcommande.Visible = true;
        }

        private void prix_OnValueChanged(object sender, EventArgs e)
        {
            qte_OnValueChanged(sender,e);
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            
            lignecmd.Rows.RemoveAt(lignecmd.CurrentRow.Index);
            if (lignecmd.Rows.Count == 1)
            {
                supprimer.Enabled = false;
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            lignecmd.Rows.Clear();
            ht.Text = "le Prix Hors Tax :";
            tvatxt.Text = "La TVA 20% :";
            ttctxt.Text = "La toute Tax Comprise : ";
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            voirlacommande.Visible = false;

            string alimamodifier = lignecmd.CurrentRow.Cells[0].Value.ToString();
            Connexion.ouvrirConnection();
            com.Connection = Connexion.cn;
            string chaine = "select typealim from aliments where libaliment ='" + alimamodifier + "'";
            com.CommandText = chaine;
            
            string typalim = com.ExecuteScalar().ToString();
            Connexion.fermerConnection();
            string qteamodifier = lignecmd.CurrentRow.Cells[2].Value.ToString();
            aliments.SelectedItem = alimamodifier;
            qte.Text = qteamodifier;
            typealiment.SelectedItem = typalim;

            viewcommande.Visible = false;
            modifierlacommande.Visible = true;
            lignecmd.Rows.RemoveAt(lignecmd.CurrentRow.Index);
            if (lignecmd.Rows.Count == 1)
            {
                supprimer.Enabled = false;
            }
        }

        private void modifierlacommande_Click(object sender, EventArgs e)
        {

            commander_Click(sender, e);
            voirlacommande.Visible = true;
            viewcommande.Visible = true;
            modifierlacommande.Visible = false;
            

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            voirlacommande.Visible = true;
            viewcommande.Visible = false;
            modifierlacommande.Visible = false;

        }


    }
}
