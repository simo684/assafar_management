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
    public partial class FRM_connexion : Form
    {
        private DbStockContext db ;
        private Form frm_menu;
        BL.class_connexion con = new BL.class_connexion();

        public FRM_connexion(Form menu)
        {
            InitializeComponent();
            db = new DbStockContext();
            this.frm_menu = menu;
        }
        // TEST OBLIGATOIRE
        string test_oblig()
        {
            if (txtnom.Text == "" || txtnom.Text == "NOM UTILISATEUR")
            {
                return "entrer your name plaese";
            }
            if (txtpassword.Text=="" || txtpassword.Text == "MOT DE PASS")
            {
                return "entrer your PASS WORD plaese";
            }
            else
            {
                return null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text== "NOM UTILISATEUR")
            {
                txtnom.Text = "";
                txtnom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "MOT DE PASS")
            {
                txtpassword.Text = "";
                txtpassword.UseSystemPasswordChar = false;
                txtpassword.PasswordChar = '*';
                txtpassword.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "NOM UTILISATEUR";
                txtnom.ForeColor = Color.Silver;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "MOT DE PASS";
                txtpassword.UseSystemPasswordChar = true;
                txtpassword.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (test_oblig()==null)
            {
               
                if (con.connexion_valid(db, txtnom.Text, txtpassword.Text) == true)
                {
                    // MessageBox.Show("connexion valid", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frm_menu as FRM_menu).activer();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("nom or pass invalid", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(test_oblig(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FRM_connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
