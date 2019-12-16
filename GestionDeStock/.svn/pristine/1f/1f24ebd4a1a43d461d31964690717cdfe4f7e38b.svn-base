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
    public partial class FRM_menu : Form
    {
        public FRM_menu()
        {
            InitializeComponent();
            panel1.Size = new Size(229, 499);
            panelparameter.Visible = false;
        }
        // desactiver menu principal
        void desactiver()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncat.Enabled = false;
            btnuser.Enabled = false;
            btnvente.Enabled = false;
            btnfournisseur.Enabled = false;
            
            btncopie.Enabled = false;
            btnrestaurer.Enabled = false;
            btndeconnecter.Enabled = false;
            btnconnecter.Enabled = true;
            panelbut.Enabled = false;
        }
      public  void activer()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncat.Enabled = true;
            btnuser.Enabled = true;
            btnvente.Enabled = true;
            btnfournisseur.Enabled = true;

            btncopie.Enabled = true;
            btnrestaurer.Enabled = true;
            btndeconnecter.Enabled = true;
            panelbut.Enabled = true;
            btnconnecter.Enabled = false;
            panelparameter.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Width==229)
            {
                panel1.Size = new Size(67, 499);
            }
            else
            {
                panel1.Size = new Size(229, 499);
            }
        }

        private void FRM_menu_Load(object sender, EventArgs e)
        {
            desactiver();
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            panelbut.Top = btnproduit.Top;
            if (!panelist_client.Controls.Contains(User_liste_produit.instancep))
            {
                panelist_client.Controls.Add(User_liste_produit.instancep);
                User_liste_produit.instancep.Dock = DockStyle.Fill;
                User_liste_produit.instancep.BringToFront();
            }
            else
                User_liste_produit.instancep.BringToFront();
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            panelbut.Top = btnclient.Top;
            if (!panelist_client.Controls.Contains(User_liste_client.instance))
            {
                panelist_client.Controls.Add(User_liste_client.instance);
                User_liste_client.instance.Dock = DockStyle.Fill;
                User_liste_client.instance.BringToFront();
            }
            else
                User_liste_client.instance.BringToFront();


        }

        private void btncat_Click(object sender, EventArgs e)
        {
            panelbut.Top = btncat.Top;
            if (!panelist_client.Controls.Contains(User_liste_categorie.instance ))
            {
                panelist_client.Controls.Add(User_liste_categorie.instance);
                User_liste_categorie.instance.Dock = DockStyle.Fill;
                User_liste_categorie.instance.BringToFront();
            }
            else
            {
                User_liste_categorie.instance.BringToFront();
            }

        }

        private void btnvente_Click(object sender, EventArgs e)
        {
            panelbut.Top = btnvente.Top;
            if (!panelist_client.Controls.Contains(User_liste_commande.instance))
            {
                panelist_client.Controls.Add(User_liste_commande.instance);
                User_liste_commande.instance.Dock = DockStyle.Fill;
                User_liste_commande.instance.BringToFront();
            }
            else User_liste_commande.instance.BringToFront();

        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            panelbut.Top = btnuser.Top;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (panelparameter.Visible == false)
            //{
            //    panelparameter.Visible = true;
            //}
            //else
            //{
            //    panelparameter.Visible = false;
            //}
           


        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnconnecter_Click(object sender, EventArgs e)
        {
            FRM_connexion frc = new FRM_connexion(this);
            frc.ShowDialog();
        }

        private void panelist_client_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndeconnecter_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnconnecter_Click_1(object sender, EventArgs e)
        {

        }

        private void btndeconnecter_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnparameter_Click(object sender, EventArgs e)
        {
            panelparameter.Size = new Size(232, 151);
            panelparameter.Visible = !panelparameter.Visible;
        }

        private void btnconnecter_Click_2(object sender, EventArgs e)
        {
            FRM_connexion fc = new FRM_connexion(this);
            fc.ShowDialog();
        }

        private void btndeconnecter_Click_3(object sender, EventArgs e)
        {
            desactiver();
        }

        private void btnfournisseur_Click(object sender, EventArgs e)
        {
            panelbut.Top = btnfournisseur.Top;
            if (!panelist_client.Controls.Contains(User_liste_fournisseur.instance))
            {
                panelist_client.Controls.Add(User_liste_fournisseur.instance);
                User_liste_fournisseur.instance.Dock = DockStyle.Fill;
                User_liste_fournisseur.instance.BringToFront();
            }
            else
            {
                User_liste_fournisseur.instance.BringToFront();
            }
        }
    }
}
