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
    public partial class Home : Form
    {
        String openform = "acc";

        string usertype;
        public Home(string utilisateur, string usertype)
        {
            InitializeComponent();
            username.Text = utilisateur;
            this.usertype = usertype;
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panac.Visible = false;
            pancom.Visible = false;
            panmen.Visible = true;
            panalim.Visible = false;
            pancli.Visible = false;
            forms.Controls.Clear();
            Menu frmmenu = new Menu(username.Text);
            frmmenu.TopLevel = false;
            forms.Controls.Add(frmmenu);
            frmmenu.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
          
            
            if (usertype.Equals("client"))
            {
                commande.Visible = false;
                pancom.Visible = false;
                Aliment.Visible = false;
                panalim.Visible = false;
                Client.Location = new Point(21,274);
                pancli.Location=new Point(0,274);
            }
                accueil1.Visible = false;
                panac.Visible = true;
                pancom.Visible = false;
                panmen.Visible = false;
                panalim.Visible = false;
                pancli.Visible = false;

                forms.Controls.Clear();
                forms.Controls.Add(accueil1);
                accueil1.Visible = true;

            openform = "accueil";
        }

        

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if (openform == "accueil")
            {
            }
            else
            {
                panac.Visible = true;
                pancom.Visible = false;
                panmen.Visible = false;
                panalim.Visible = false;
                pancli.Visible = false;
                forms.Controls.Clear();
                forms.Controls.Add(accueil1);
                accueil1.Visible = Enabled;

                openform = "accueil";
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (openform == "menu")
                {
                }
            else
                {
                    panac.Visible = false;
                    pancom.Visible = false;
                    panmen.Visible = true;
                    panalim.Visible = false;
                    pancli.Visible = false;
                    forms.Controls.Clear();
                    Menu frmmenu = new Menu(username.Text);
                    frmmenu.TopLevel = false;
                    forms.Controls.Add(frmmenu);
                    frmmenu.Show();

                    openform = "menu";
                }
        }

        private void Aliment_Click(object sender, EventArgs e)
        {
            if (openform == "aliments")
                {
                }
            else
                {
                    accueil1.Visible = false;
                    panac.Visible = false;
                    pancom.Visible = false;
                    panmen.Visible = false;
                    panalim.Visible = true;
                    pancli.Visible = false;

                    forms.Controls.Clear();
                    Aliments frmali = new Aliments();
                    frmali.TopLevel = false;
                    forms.Controls.Add(frmali);
                    frmali.Show();

                    openform = "aliments";
                }

        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            if (openform == "commande")
                {
                }
            else
                {
                    accueil1.Visible = false;
                    panac.Visible = false;
                    pancom.Visible = true;
                    panmen.Visible = false;
                    panalim.Visible = false;
                    pancli.Visible = false;

                    forms.Controls.Clear();
                    Commande frmcom = new Commande(usertype);
                    frmcom.TopLevel = false;
                    forms.Controls.Add(frmcom);
                    frmcom.Show();

                    openform = "commande";
                }
        }

        private void Client_Click(object sender, EventArgs e)
        {
             if (openform == "client")
                {
                }
            else
                {
                    accueil1.Visible = false;
                    panac.Visible = false;
                    pancom.Visible = false;
                    panmen.Visible = false;
                    panalim.Visible = false;
                    pancli.Visible = true;

                    forms.Controls.Clear();
                    utilisateur frmuser = new utilisateur(username.Text,usertype);
                    frmuser.TopLevel = false;
                    forms.Controls.Add(frmuser);
                    frmuser.Show();
                    openform = "client";
                }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez Vous Quitter l'application", "Quiter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


        private void moncompte_Click(object sender, EventArgs e)
        {
            if (openform == "client")
            {
            }
            else
            {
                accueil1.Visible = false;
                panac.Visible = false;
                pancom.Visible = false;
                panmen.Visible = false;
                panalim.Visible = false;
                pancli.Visible = true;

                forms.Controls.Clear();
                utilisateur frmuser = new utilisateur(username.Text, usertype);
                frmuser.TopLevel = false;
                forms.Controls.Add(frmuser);
                frmuser.Show();
                openform = "client";
            }
        }

        private void commander_Click(object sender, EventArgs e)
        {
            if (openform == "menu")
            {
            }
            else
            {
                panac.Visible = false;
                pancom.Visible = false;
                panmen.Visible = true;
                panalim.Visible = false;
                pancli.Visible = false;
                forms.Controls.Clear();
                Menu frmmenu = new Menu(username.Text);
                frmmenu.TopLevel = false;
                forms.Controls.Add(frmmenu);
                frmmenu.Show();

                openform = "menu";
            }
        }

    }
}
