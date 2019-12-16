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
    public partial class FRM_produit_commande : Form
    {
        public Form frmdetail;

        public FRM_produit_commande(Form frm)
        {
            InitializeComponent();
            frmdetail = frm;
        }

        private void txtqte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<48||e.KeyChar>57)
            {
                e.Handled = true;
            }
            if (e.KeyChar==8)
            {
                e.Handled = false;
            }
        }

        private void txtremise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtqte_TextChanged(object sender, EventArgs e)
        {
            if (txtqte.Text!="") // pas vide
            {
                double remi;
                if (txtremise.Text!="")
                {
                    remi = double.Parse(txtremise.Text);
                }
                else
                {
                    remi = 0;
                }

                int quantite = int.Parse(txtqte.Text);
                double prix = double.Parse(lblprix.Text);
             

                txttotal.Text = (quantite * prix ).ToString();
            }
            else
            {
                txttotal.Text = lblprix.Text;
            }
            
        }

        private void txtremise_TextChanged(object sender, EventArgs e)
        {
            if (txtremise.Text!="")
            {
                int quantite;
                if (txtqte.Text!="")
                {
                    quantite = int.Parse(txtqte.Text);
                }
                else
                {
                    quantite = 1;
                }
                
                double prix = double.Parse(lblprix.Text);
                double tot = quantite * prix;
                double rem = double.Parse(txtremise.Text);

                txttotal.Text = (tot - (tot * rem / 100)).ToString();
            }
            else
            {
                int quantite;
                if (txtqte.Text != "")
                {
                    quantite = int.Parse(txtqte.Text);
                }
                else
                {
                    quantite = 1;
                }
                
                double prix = double.Parse(lblprix.Text);
                txttotal.Text = (quantite * prix).ToString();
                
               
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // si texbox qte et remise vide
            int quantite, rem;
            if (txtqte.Text!="") // pas vide
            {
                quantite = int.Parse(txtqte.Text);
            }
            else
            {
                quantite = 1;
            }
            if (txtremise.Text!="")
            {
                rem =int.Parse( txtremise.Text);
            }
            else
            {
                rem = 0;
            }
            // ajout prod comm dan dgv_comm

            BL.D_Commande detail = new BL.D_Commande
            {
                id = int.Parse(Lbi.Text),
                nom = lblnom.Text,
                qte = quantite,
                prix = lblprix.Text,
                remise = rem.ToString(),
                total = txttotal.Text,
            };
            // ajout 
            if (grproduits.Text=="VENTE PRODUIT")
            {
                if (BL.D_Commande.list_det_comm.SingleOrDefault(s => s.id == detail.id) != null)
                {
                    MessageBox.Show("produit deja saisi", "saisie");
                }
                else
                {
                    BL.D_Commande.list_det_comm.Add(detail);
                    Close();
                }
            }
            // modification
            else
            {
                DialogResult dr = MessageBox.Show("modifier", "modification", MessageBoxButtons.YesNo);
                if (dr==DialogResult.Yes)
                {
                    // trouver index du prod modifi
                    int index = BL.D_Commande.list_det_comm.FindIndex(s => s.id == int.Parse(Lbi.Text));
                    BL.D_Commande.list_det_comm[index] = detail;
                    MessageBox.Show("ok modifier", "modif");
                    Close();
                }
                else MessageBox.Show(" modifier annule", "modif");
            }     
           

            // actualiser dgvcommand
            (frmdetail as FRM_detail_vente).rempldgv_commande();

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
