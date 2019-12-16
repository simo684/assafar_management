using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_ajouter_modifier_produit : Form
    {
        private UserControl up;
        private DbStockContext db;

        public FRM_ajouter_modifier_produit(UserControl uproduit)
        {

            InitializeComponent();
            db = new DbStockContext();
            // afficher table categorie
            cmbprod.DataSource = db.categories.ToList();
            // afficher uniquement  nom categorie
            cmbprod.DisplayMember = "nom_cat";
            cmbprod.ValueMember = "id_cat";

            up = uproduit;
            
        }

        // champs obligatoire

        string test_oblig()
        {
            if (txtnomPROD.Text == "NOM PRODUIT" || txtnomPROD.Text == "")
            {
                return "entre nom produit";
            }
            if (txtQUANTITE.Text == "QUANTITE" || txtnomPROD.Text == "")
            {
                return "entre quantite produit";
            }
            if (txtPRIX.Text == "PRIX" || txtnomPROD.Text == "")
            {
                return "entre prix produit";
            }
            if (cmbprod.Text ==  "")
            {
                return "entre cat produit";
            }
            else
                return null;
        }

        private void txtnomPROD_Enter(object sender, EventArgs e)
        {
            if (txtnomPROD.Text =="NOM PRODUIT")
            {
                txtnomPROD.Text = "";
            }
        }

        private void txtnomPROD_Leave(object sender, EventArgs e)
        {
            if (txtnomPROD.Text == "")
            {
                txtnomPROD.Text = "NOM PRODUIT";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQUANTITE_Enter(object sender, EventArgs e)
        {
            if (txtQUANTITE.Text== "QUANTITE")
            {
                txtQUANTITE.Text = "";
            }
        }

        private void txtQUANTITE_Leave(object sender, EventArgs e)
        {
            if (txtQUANTITE.Text == "")
            {
                txtQUANTITE.Text = "QUANTITE";
            }
        }

        private void txtPRIX_Enter(object sender, EventArgs e)
        {
            if (txtPRIX.Text=="PRIX")
            {
                txtPRIX.Text = "";
            }
        }

        private void txtPRIX_Leave(object sender, EventArgs e)
        {
            if (txtPRIX.Text == "")
            {
                txtPRIX.Text = "PRIX";
            }
        }

        private void txtPRIX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<48 ||  e.KeyChar>57)
            {
                e.Handled = true;
            }
            if (e.KeyChar==8 || e.KeyChar==46)
            {
                e.Handled = false;
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            txtnomPROD.Text = "NOM PRODUIT";
            txtQUANTITE.Text = "QUANTITE";
            txtPRIX.Text = "PRIX";
            cmbprod.Text = "";
            }

        private void txtPRIX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQUANTITE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void FRM_ajouter_modifier_produit_Load(object sender, EventArgs e)
        {

        }
        public int id_select;

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (test_oblig()==null)
            {
                if (lbltitre.Text =="AJOUTER PRODUIT")  //  AJOUT
                {
                    BL.class_produit p = new BL.class_produit();
                    if (p.ajout_produit(txtnomPROD.Text,int.Parse( txtQUANTITE.Text), txtPRIX.Text,Convert.ToInt32 ( cmbprod.SelectedValue)) == true)
                    {
                        MessageBox.Show("bien ajouter");
                        (up as User_liste_produit).datagridactuazlis();
                        
                    }
                    else
                        MessageBox.Show("produit deja exist");
                }
                else  //    MODIFICATION
                {
                    BL.class_produit p = new BL.class_produit();
                    DialogResult dg = MessageBox.Show("tu veux modifier", "modification",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg==DialogResult.Yes)
                    {
                        p.modifier_produit(id_select, txtnomPROD.Text, int.Parse(txtQUANTITE.Text), txtPRIX.Text, Convert.ToInt32(cmbprod.SelectedValue));
                        (up as User_liste_produit).datagridactuazlis();
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(test_oblig());
            }
        }
    }
}
