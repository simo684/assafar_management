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
    public partial class FRM_ajouter_modifier_categorie : Form
    {
        UserControl uc;
        public FRM_ajouter_modifier_categorie(User_liste_categorie user)
        {
            InitializeComponent();
            uc = user;
        }
        // test
        string test_obli()
        {
            if (txtnomCAT.Text == "")
            {
                return "entrer une categ";
            }
            else return null;

        }
        private void txtnomCAT_Enter(object sender, EventArgs e)
        {
            if (txtnomCAT.Text=="NOM CATEGORIE")
            {
                txtnomCAT.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public int id_sele;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (test_obli()!=null)
            {
                MessageBox.Show(test_obli());
            }
            else
            {
                if (lbltitre.Text=="AJOUTER CATEGORIE")
                {
                    BL.class_categorie cat = new BL.class_categorie();
                    if (cat.ajou_cat(txtnomCAT.Text)==true)
                    {
                        MessageBox.Show(" bien ajouter avex succed");
                        (uc as User_liste_categorie).remplir_datagrid();
                    }
                    else
                    {
                        MessageBox.Show(" cat deja existante");
                    }
                    
                   
                }
                else
                {
                    DialogResult re = MessageBox.Show("tu veux modifier ce client", "modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re== DialogResult.Yes)
                    {
                        BL.class_categorie categ = new BL.class_categorie();
                        categ.modif_cat(id_sele, txtnomCAT.Text);
                        (uc as User_liste_categorie).remplir_datagrid();
                    }
                  
                }
            }
        }

        private void FRM_ajouter_modifier_categorie_Load(object sender, EventArgs e)
        {

        }
    }
}
