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
    public partial class TypeAliment : Form
    {
        bool cls = true;
        SqlCommand comatypal = new SqlCommand();
        SqlDataAdapter sdatypal;
        DataTable dtypal = new DataTable();
        SqlCommandBuilder cmbd;
        DataView dvtypal = new DataView();
        BindingSource bstypal = new BindingSource();

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

        public TypeAliment()
        {
            InitializeComponent();
        }

        private void TypeAliment_Load(object sender, EventArgs e)
        {
            Connexion.ouvrirConnection();
            comatypal.Connection = Connexion.cn;
            comatypal.CommandText = "select * from typealiment";

            sdatypal = new SqlDataAdapter(comatypal);
            if (!Connexion.ds.Tables.Contains("typealiment"))
                sdatypal.Fill(Connexion.ds, "typealiment");

            Connexion.fermerConnection();
            dtypal = Connexion.ds.Tables["typealiment"];
            dvtypal = dtypal.DefaultView;
            bstypal.DataSource = dtypal;
            listBox1.DataSource = bstypal;
            listBox1.ValueMember = "typealim";
            listBox1.DisplayMember = "typealim";

            typealimet.DataBindings.Add("text", bstypal, "typealim");

            annuler.Enabled = false;
            valider.Enabled = false;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            bstypal.AddNew();
            typealimet.Text = "";
            activer(true);
            cls = false;

        }

        private void valider_Click(object sender, EventArgs e)
        {
            bstypal.EndEdit();
            activer(false);
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
                bstypal.RemoveCurrent();
                cls = false;

            }

        }

        private void annuler_Click(object sender, EventArgs e)
        {
            bstypal.CancelEdit();
            activer(false);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                dvtypal.RowFilter = "typealim like '%" + textrech.text + "%'";

        }

        private void TypeAliment_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!cls)
            {
                if (MessageBox.Show("Voulez-vous enregistrer les données dans le serveur ?", "Enregiistrer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        cmbd = new SqlCommandBuilder(sdatypal);
                        sdatypal.Update(Connexion.ds, "typealiment");
                        MessageBox.Show("Enregistrement est terminer");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void textrech_OnTextChange(object sender, EventArgs e)
        {
            if (textrech.text == "" || textrech.text == "Recherch par le nom")
                dvtypal.RowFilter = "typealim like '%'";
        }

        private void typealimet_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
