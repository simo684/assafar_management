using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class User_liste_client : UserControl
    {
        private static User_liste_client user_client;
        private DbStockContext db;

        // creer instance pour usercontrol
        public static User_liste_client instance
        {
            get
            {
                if (user_client==null)
                {
                    user_client = new User_liste_client();
                }
                return user_client;
            }
        }
        public User_liste_client()
        {
            InitializeComponent();
            db = new DbStockContext();
            // desactiver txtbox rechereche
            txtserch.Enabled = false;
        }

        public void actualiser_datagriv()
        {
            
            dgvclient.Rows.Clear();
            db = new DbStockContext();
            foreach (var s in db.clients)
            {
                dgvclient.Rows.Add(false, s.id_client, s.name, s.prenom, s.adress, s.ville, s.tel, s.Email);
            }
        }
        // verifier combien de ligne selectionne
        public string  select_verif()
        {
            int nbr_selec = 0;
            for (int i = 0; i < dgvclient.Rows.Count; i++)
            {
                if ((bool)dgvclient.Rows[i].Cells[0].Value==true)
                {
                    nbr_selec++;
                }
            }
            if (nbr_selec==0)
            {
                return "selectionner  client a  modifier";
            }
            if (nbr_selec > 1)
            {
                return "selectionner un seul client a  modifier";
            }
            else
                return null;
        }
        private void User_liste_client_Load(object sender, EventArgs e)
        {
            actualiser_datagriv();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtserch.Text=="Rechercher")
            {
                txtserch.Text = "";
                txtserch.ForeColor = Color.Black;
            }
        }

        private void btnajouter_client_Click(object sender, EventArgs e)
        {
            FRM_ajouter_modifier_client fr = new FRM_ajouter_modifier_client(this);
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (select_verif()==null)
            {
                PL.FRM_ajouter_modifier_client fr = new FRM_ajouter_modifier_client(this);

                for (int i = 0; i < dgvclient.Rows.Count; i++) //  chercher ligne selectionne
                {
                    if ((bool)dgvclient.Rows[i].Cells[0].Value==true) //  chercher ligne selectionne
                    {
                       fr.id_select = (int)dgvclient.Rows[i].Cells[1].Value;

                        fr.txtnomclient.Text = dgvclient.Rows[i].Cells[2].Value.ToString();
                        fr.txtprenom.Text = dgvclient.Rows[i].Cells[3].Value.ToString();
                        fr.txtadress.Text = dgvclient.Rows[i].Cells[4].Value.ToString();
                        fr.txtville.Text = dgvclient.Rows[i].Cells[5].Value.ToString();
                        fr.txttel.Text = dgvclient.Rows[i].Cells[6].Value.ToString();
                        fr.txtemail.Text = dgvclient.Rows[i].Cells[7].Value.ToString();
                    }
                }
                
                    
                

               
                fr.label1.Text = "modifier client";
                fr.btnactualiser.Visible = false;
                fr.ShowDialog();

            }
            else
            {
                MessageBox.Show(select_verif(), "modification",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (select_verif()==null)
            {
                for (int i = 0; i < dgvclient.Rows.Count; i++)
                {
                    if ((bool)dgvclient.Rows[i].Cells[0].Value== true)
                    {
                        DialogResult r = MessageBox.Show("tu veux supprimer ce client", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r== DialogResult.Yes)
                        {
                            BL.class_client cl = new BL.class_client();
                            cl.delete_client((int)dgvclient.Rows[i].Cells[1].Value);
                            MessageBox.Show("deleted success");
                            actualiser_datagriv();
                        }
                        else
                        {
                            MessageBox.Show("deleted annule");
                        }
                       
                    }
                }
            }
            else
            {
                MessageBox.Show(select_verif(), "modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbserch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // activer txt box serch et vider
            txtserch.Enabled = true;
            txtserch.Text = "";

         }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var list_serch = db.clients.ToList(); // list_serch = list client

            if (txtserch.Text != "")  // pas vide
            {
                switch (cmbserch.Text)
                {
                    case "nom":
                        list_serch = list_serch.Where(x => x.name.IndexOf(txtserch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // stringcomparison : maj ou min  
                        // != -1 veut dire existe dans database
                        break;

                    case "prenom":
                        list_serch = list_serch.Where(x => x.prenom.IndexOf(txtserch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;

                    case "ville":
                        list_serch = list_serch.Where(x => x.ville.IndexOf(txtserch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    
                }
            }
            // charger  datagridview par liste crere par la recherche
            dgvclient.Rows.Clear();
            foreach (var i in list_serch)
            {
                dgvclient.Rows.Add(false, i.id_client, i.name, i.prenom, i.adress, i.ville, i.Email);
            }
        }
    }
}
