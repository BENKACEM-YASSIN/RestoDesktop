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
using System.IO;

namespace Projet
{
    public partial class Aliments : Form
    {
        bool cls=true;
        SqlCommand comalim=new SqlCommand();
        SqlCommand comatyplim = new SqlCommand();
        SqlDataAdapter sdaalim=new SqlDataAdapter();
        DataTable dtaalim = new DataTable();
        DataTable dttypeaalim = new DataTable();
        SqlDataAdapter sdatyplealim = new SqlDataAdapter();
        BindingSource bstyp;
        BindingSource bsalim;
        BindingSource typ;
        SqlCommandBuilder cmbd;

        private void activer(bool v)
        {
            
            nomaliment.Enabled = v;
            comboBox1.Enabled = v;
            description.Enabled = v;
            prix.Enabled = v;
            chargephoto.Enabled = v;
            nomaliment.Enabled = v;
            comboBox1.Enabled = v;
            ajouter.Enabled = !v;
            modifier.Enabled = !v;
            supprimer.Enabled = !v;
            annuler.Enabled = v;
            valider.Enabled = v;
            dataGridView1.Refresh();
            dataGridView1.Update();

        }
        
        public Aliments()
        {
            InitializeComponent();
        }

  

        private void Aliments_Load(object sender, EventArgs e)
        {


            openFileDialog1.Filter = "fichiers jpg|*.jpg|Tous les fichiers|*.*";
            openFileDialog1.FileName = "";
            
            
            Connexion.fermerConnection();
            Connexion.ouvrirConnection();

            comalim = new SqlCommand();
            comalim.CommandText = "select * from aliments";
            comalim.Connection = Connexion.cn;

            comatyplim = new SqlCommand();
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

            Connexion.fermerConnection();



            //afficher les types d'aliments
            typ = new BindingSource();

            typ.DataSource = Connexion.ds;
            typ.DataMember = "typealiment";
            comboBox1.DataSource = typ;
            comboBox1.ValueMember = "typealim";
            comboBox1.DisplayMember = "typealim";

            //affichier les alimment par type
            bstyp = new BindingSource();
            bstyp.DataSource = Connexion.ds;
            bstyp.DataMember = "typealiment";

            comborel.DataSource = bstyp;
            comborel.ValueMember = "typealim";
            comborel.DisplayMember = "typealim";

            //afficher les aliments
            bsalim = new BindingSource();
            bsalim.DataSource = bstyp;
            bsalim.DataMember = "rel_alim_type";

            alimentid.DataBindings.Add("text", bsalim, "alimentid");
            nomaliment.DataBindings.Add("text", bsalim, "libaliment");
            prix.DataBindings.Add("text", bsalim, "prix");
            phototext.DataBindings.Add("text", bsalim, "img");
            description.DataBindings.Add("text", bsalim, "descriptionaliment");
            typea.DataBindings.Add("text", bsalim, "typealim");
            dataGridView1.DataSource = bsalim;

            alimentid.Enabled = false;
            activer(false);
            chargephoto.Enabled = false;
            
     

          
     
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Aliments_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (!cls)
            {
                if (MessageBox.Show("Voulez-vous enregistrer les données dans le serveur ?", "Enregiistrer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        cmbd = new SqlCommandBuilder(sdaalim);
                        sdaalim.Update(Connexion.ds, "aliments");
                        MessageBox.Show("Enregistrement est terminer");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            }

      

      
     

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rech_Click_1(object sender, EventArgs e)
        {
            if (textrech.text == "" || textrech.text == "Recherch par le nom")
                MessageBox.Show("sisair le nom qui rechercher");

            else
                bsalim.Filter = "libaliment like '%" + textrech.text + "%'";
        }

        private void textrech_OnTextChange(object sender, EventArgs e)
        {
            if (textrech.text == "" || textrech.text == "Recherch par le nom")
                bsalim.Filter = "libaliment like '%'";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void ajouter_Click(object sender, EventArgs e)
        {
            bsalim.AddNew();
            paneltyp.Enabled = false;
            activer(true);
            cls = false;
        }

        private void valider_Click(object sender, EventArgs e)
        {
            typea.Text = comboBox1.Text;
            bsalim.EndEdit();
            activer(false);
            paneltyp.Enabled = true;
            
            dataGridView1.Update();
            dataGridView1.Refresh();
            cls = false;
            try
            {
                cmbd = new SqlCommandBuilder(sdaalim);
                sdaalim.Update(Connexion.ds, "aliments");
                MessageBox.Show("Enregistrement est terminer");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            cls = false;
            activer(true);
            paneltyp.Enabled = false;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            bsalim.CancelEdit();
            activer(false);
            paneltyp.Enabled = true;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous supprimer cet élément ?", "supprimer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bsalim.RemoveCurrent();
                cls = false;
            }
        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            TypeAliment tl = new TypeAliment();
            tl.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string ch = openFileDialog1.FileName;
            string n = Path.GetFileName(ch);
            string ext = Path.GetExtension(ch);
            
            Random r = new Random();
            string alea = r.Next().ToString();
            string nn = alea + ext;

            File.Copy(openFileDialog1.FileName, "imagealiment/" + nn);
            phototext.Text = nn;
        }

        private void phototext_TextChanged(object sender, EventArgs e)
        {
            if (phototext.Text == "")
            {
                phototext.Text = "aliment.png";
                photoaliment.Load("imagealiment/" + phototext.Text);
            }
            else
            {
                photoaliment.Load("imagealiment/" + phototext.Text);
            }
        }

        private void chargephoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            PrintAliment prali = new PrintAliment();
            prali.ShowDialog();
        }
    }
}
