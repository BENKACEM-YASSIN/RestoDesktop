using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Projet
{
    public partial class utilisateur : Form
    {
        SqlCommand comclient = new SqlCommand();
        SqlDataAdapter daclient;
        DataTable dtclient = new DataTable();
        BindingSource bsclient = new BindingSource();
        SqlCommandBuilder cmbclient;
        string user;

        public utilisateur(string username,string usertype)
        {
            InitializeComponent();
            type.Text = usertype;
            user = username;
            
        }
        private void activer(bool v)
        {
            bunifuCards2.Enabled = v;
            bunifuCards3.Enabled = v;
            ajouter.Enabled = !v;
            modifier.Enabled = !v;
            supprimer.Enabled = !v;
            annuler.Enabled = v;
            valider.Enabled = v;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void client_Load(object sender, EventArgs e)
        {

            
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;

            //usernifo.Text = Login.usname.ToString();
            Connexion.fermerConnection();
            Connexion.ouvrirConnection();

            if (type.Text.Equals("admin"))
            {

                comclient.Connection = Connexion.cn;
                comclient.CommandText = "select * from utilisateur";
                cmbclient = new SqlCommandBuilder(daclient);
                daclient = new SqlDataAdapter(comclient);

                daclient.Fill(Connexion.ds, "utilisateur");


                Connexion.fermerConnection();
                dtclient = Connexion.ds.Tables["utilisateur"];
                bsclient.DataSource = dtclient;

                username.DataBindings.Add("Text", bsclient, "username");
                mdp.DataBindings.Add("Text", bsclient, "motdepasse");
                nom.DataBindings.Add("Text", bsclient, "nom");
                prenom.DataBindings.Add("Text", bsclient, "prenom");
                email.DataBindings.Add("Text", bsclient, "email");
                type.DataBindings.Add("Text", bsclient, "usertype");
                listBox1.DataSource = bsclient;
                listBox1.ValueMember = "username";
                listBox1.DisplayMember = "nom";
            }
            else
            {
                if (type.Text.Equals("client"))
                {
                    comclient = new SqlCommand("select * from utilisateur where username = '" + user + "'", Connexion.cn);
                    SqlDataReader dr = comclient.ExecuteReader();
                    if (dr.Read())
                    {
                        username.Text = dr["username"].ToString();
                        mdp.Text = dr["motdepasse"].ToString();
                        nom.Text = dr["nom"].ToString();
                        prenom.Text = dr["prenom"].ToString();
                        email.Text = dr["email"].ToString();
                    }
                    dr.Close();
                    comclient = null;
                    Connexion.fermerConnection();
                    dr = null;
                    ajouter.Visible = false;
                    supprimer.Visible = false;
                    bunifuCards6.Visible = false;
                    bunifuCards2.Location = new Point(125, 24);
                    bunifuCards3.Location = new Point(500, 24);
                    users.Visible = false;
                    label7.Visible = false;
                }
                activer(false);


            }
        }

      

      

      

      
        private void valider_Click(object sender, EventArgs e)
        {
            /*comboBox1.Text = type.Text;
            if (type.Text.Equals("admin"))
            {
                bsclient.EndEdit();
                cmbclient = new SqlCommandBuilder(daclient);
                daclient.Update(Connexion.ds, "utilisateur");
            }
            else
            {
                if (type.Text.Equals("client"))
                {
                    Connexion.ouvrirConnection();
                    comclient = new SqlCommand("Update utilisateur set nom ='" + nom.Text + "',prenom='" + prenom.Text + "',motdepasse='" + mdp.Text + "',email='" + email.Text + "' where username='" + user.ToString() + "'",Connexion.cn);

                    comclient.ExecuteNonQuery();

                    Connexion.fermerConnection();
                }

            }
            activer(false);*/
        }

        private void ajouter_Click(object sender, EventArgs e)
        {

            bsclient.AddNew();
            activer(true);
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            activer(true);
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous supprimer cet élément ?", "supprimer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bsclient.RemoveCurrent();
                cmbclient = new SqlCommandBuilder(daclient);
                daclient.Update(Connexion.ds, "utilisateur");
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            bsclient.CancelEdit();
            activer(false);
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
           
            typeuser frmtyp = new typeuser();
            frmtyp.ShowDialog();
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            activer(false);
        }

      
        private void bunifuTileButton2_Click_1(object sender, EventArgs e)
        {
            PrintUtilisateur prut = new PrintUtilisateur();
            prut.ShowDialog();
        }
    }
}
