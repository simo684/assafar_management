using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestionDeStock.PL
{
    public partial class FRM_ajouter_modifier_client : Form
    {
        private UserControl uc;

        public FRM_ajouter_modifier_client(UserControl uclient)
        {
            InitializeComponent();
            uc = uclient;
        }

        //test 
        string test_oblig()
        {
            if (txtnomclient.Text == "NOM CLIENT" || txtnomclient.Text == "")
            {
                return "entrer nom client";
            }
            if (txtprenom.Text == "PRENOM CLIENT" || txtprenom.Text == "")
            {
                return "entrer prenom client";
            }
            if (txtadress.Text == "ADRESS CLIENT" || txtadress.Text == "")
            {
                return "entrer ADRESS client";
            }
            if (txttel.Text == "TELEPHONE CLIENT" || txttel.Text == "")
            {
                return "entrer TELEPHONE client";
            }
            if (txtville.Text == "VILLE CLIENT" || txtville.Text == "")
            {
                return "entrer VILLE client";
            }
            if (txtemail.Text !="" || txtemail.Text != "EMAIL CLIENT")
            {
                try
                {
                    new MailAddress(txtemail.Text);
                }
                catch (Exception e)
                {

                    return "email invalid";
                }
            }
            
                return null;
        }
        private void FRM_ajouter_modifier_client_Load(object sender, EventArgs e)
        {

        }

        private void txtnomclient_Enter(object sender, EventArgs e)
        {
            if (txtnomclient.Text=="NOM CLIENT")
            {
                txtnomclient.Text = "";
                txtnomclient.ForeColor = Color.White;
            }
        }

        private void txtnomclient_Leave(object sender, EventArgs e)
        {
            if (txtnomclient.Text == "")
            {
                txtnomclient.Text = "NOM CLIENT";
                txtnomclient.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtadress_Enter(object sender, EventArgs e)
        {
            if (txtadress.Text=="ADRESS CLIENT")
            {
                txtadress.Text = "";
                txtadress.ForeColor = Color.White;
            }
        }

        private void txtadress_Leave(object sender, EventArgs e)
        {
            if (txtadress.Text == "")
            {
                txtadress.Text = "ADRESS CLIENT";
                txtadress.ForeColor = Color.Silver;
            }
        }

        private void txtville_Leave(object sender, EventArgs e)
        {
            if (txtville.Text=="")
            {
                txtville.Text = "VILLE CLIENT";
                txtville.ForeColor = Color.Silver;
            }
        }

        private void txtville_Enter(object sender, EventArgs e)
        {
            if (txtville.Text == "VILLE CLIENT")
            {
                txtville.Text = "";
                txtville.ForeColor = Color.White;
            }
        }

        private void txtprenom_Enter(object sender, EventArgs e)
        {
            if (txtprenom.Text == "PRENOM CLIENT")
            {
                txtprenom.Text = "";
                txtprenom.ForeColor = Color.White;
            }
        }

        private void txtprenom_Leave(object sender, EventArgs e)
        {
            if (txtprenom.Text == "")
            {
                txtprenom.Text = "PRENOM CLIENT";
                txtprenom.ForeColor = Color.Silver;
            }
        }

        private void txttel_Enter(object sender, EventArgs e)
        {
            if (txttel.Text == "TELEPHONE CLIENT")
            {
                txttel.Text = "";
                txttel.ForeColor = Color.White;
            }
        }

        private void txttel_Leave(object sender, EventArgs e)
        {
            if (txttel.Text == "")
            {
                txttel.Text = "TELEPHONE CLIENT";
                txttel.ForeColor = Color.Silver;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "EMAIL CLIENT")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.White;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "EMAIL CLIENT";
                txtemail.ForeColor = Color.Silver;
            }
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<48 || e.KeyChar>57)
            {
                e.Handled = true;
            }
            if (e.KeyChar==8)
            {
                e.Handled = false;
            }
        }
        public int id_select;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (test_oblig()!= null)
            {
                MessageBox.Show(test_oblig());
                
            }
            else
            {
                if (label1.Text== "AJOUTER CLIENT")
                {
                    BL.class_client c = new BL.class_client();
                    if (c.ajouter_clien(txtnomclient.Text, txtprenom.Text, txtadress.Text, txtville.Text, txttel.Text, txtemail.Text) == true)
                    {
                        MessageBox.Show(" bien ajouter avex succed");
                        (uc as User_liste_client).actualiser_datagriv();
                    }
                    else
                        MessageBox.Show(" deja exist ");
                }
                else
                {
                    BL.class_client c = new BL.class_client();
                 

                    DialogResult re = MessageBox.Show("tu veux modifier ce client","modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (re== DialogResult.Yes)
                    {
                        c.modifier_client(id_select, txtnomclient.Text, txtprenom.Text, txtadress.Text, txtville.Text, txttel.Text, txtemail.Text);

                        (uc as User_liste_client).actualiser_datagriv();

                        MessageBox.Show(" bien modifier avex succed");
                    }
                    else
                        MessageBox.Show(" modification annulee");


                }
               
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            txtnomclient.Text = "NOM CLIENT";
            txtprenom.Text = "PRENOM CLIENT";
            txttel.Text = "TELEPHONE CLIENT";
            txtadress.Text = "ADRESS CLIENT";
            txtville.Text = "VILLE CLIENT";
            txtemail.Text = "EMAIL CLIENT";
                
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
