using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        
        SqlCommand com;
        String usernom;
        String userprenom;
        public static String usname;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {


          if (mdp.Text.Contains("'"))
          {
              MessageBox.Show("l'apostroph n'est pas valid dans un mot de passe");
              return;
          }
            Connexion.ouvrirConnection();
            com = new SqlCommand("select * from utilisateur where username ='" + username.Text.ToString() + "' and motdepasse ='" + mdp.Text.ToString() + "'", Connexion.cn);
          SqlDataReader dr = com.ExecuteReader();
          if (dr.Read())
          {

              usernom = dr["nom"].ToString();
              userprenom = dr["prenom"].ToString();
                usname = dr["username"].ToString();
                this.Hide();
              Home frpr = new Home(username.Text, dr["usertype"].ToString());
              frpr.ShowDialog();


          }
          else
          {
              MessageBox.Show("Username ou mot de passe incorrect");
          }
          dr.Close();
          com = null;
            Connexion.fermerConnection();
          dr = null;
        }

        private void signup_Click(object sender, EventArgs e)
        {
        inscription frins = new inscription();
            frins.ShowDialog();
        }

        private void mdp_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                loginbtn_Click(sender, e);
            }
        }
    }
}
