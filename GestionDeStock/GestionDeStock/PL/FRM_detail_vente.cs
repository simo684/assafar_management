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
    public partial class FRM_detail_vente : Form
    {
        UserControl uservente;
        private DbStockContext db;

        public FRM_detail_vente(UserControl usc)
        {
            InitializeComponent();
            db = new DbStockContext();
            uservente = usc;
            
        }
        //remplir dgv commande par la liste
        public void rempldgv_commande()
        {
            // calcul total ht , tva  ,ttc
            float total_ht = 0;
            float ttc = 0 , tva = 0;
            if (txttva.Text!="")
            {
                tva = float.Parse(txttva.Text);
            }
            dgvcommand.Rows.Clear();
            foreach (var l in BL.D_Commande.list_det_comm)
            {
                dgvcommand.Rows.Add(l.id, l.nom, l.qte, l.prix, l.remise, l.total);
                total_ht = total_ht +  float.Parse(l.total);
            }
            txtht.Text = total_ht.ToString();
            txtttc.Text = (total_ht + (total_ht * tva / 100)).ToString();

        }
        // remplir dgvproduit
        public void remplirdgv()
        {
            dgvproduit.Rows.Clear();
            foreach (var item in db.produits)
            {
                dgvproduit.Rows.Add(item.id_produit, item.nom_produit, item.quantite, item.prix_vente);

            }
            for (int i = 0; i < dgvproduit.Rows.Count; i++)
            {
                if ((int)dgvproduit.Rows[i].Cells[2].Value == 0)
                {
                    dgvproduit.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
                else
                {
                    dgvproduit.Rows[i].Cells[2].Style.BackColor = Color.LightGreen;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            // vider list vente
            BL.D_Commande.list_det_comm.Clear();
        }

        private void txtnomPROD_Enter(object sender, EventArgs e)
        {
            if (txtnomPROD.Text == "RECHERCHE")
            {
                txtnomPROD.Text = "";
                txtnomPROD.ForeColor = Color.White;
            }
        }

        private void FRM_detail_vente_Load(object sender, EventArgs e)
        {
            remplirdgv();
        }

        private void txtnomPROD_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var list_serc = db.produits.ToList();
            list_serc = list_serc.Where(x => x.nom_produit.IndexOf(txtnomPROD.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dgvproduit.Rows.Clear();
            foreach (var item in list_serc)
            {
                dgvproduit.Rows.Add(item.id_produit, item.nom_produit, item.quantite,item.prix_vente);
            }
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            PL.FRM_client_vente cv = new FRM_client_vente();
            cv.ShowDialog();
            // afficher information clien
            id_clie = (int)cv.dgvclient.CurrentRow.Cells[0].Value; // remplir id client

            txtnom.Text = cv.dgvclient.CurrentRow.Cells[1].Value.ToString();
            txtprenom.Text = cv.dgvclient.CurrentRow.Cells[2].Value.ToString();
            txtel.Text = cv.dgvclient.CurrentRow.Cells[5].Value.ToString();
            txtemail.Text = cv.dgvclient.CurrentRow.Cells[6].Value.ToString();
            txtville.Text = cv.dgvclient.CurrentRow.Cells[4].Value.ToString();

        }

        private void dgvproduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_produit_commande pc = new FRM_produit_commande(this);
            if ((int)dgvproduit.CurrentRow.Cells[2].Value==0)
            {
                MessageBox.Show("stock vide", "information");
            }
            else
            {
                // afficher infor produit
                pc.Lbi.Text = dgvproduit.CurrentRow.Cells[0].Value.ToString();
                pc.lblnom.Text = dgvproduit.CurrentRow.Cells[1].Value.ToString();
                pc.lblprix.Text = dgvproduit.CurrentRow.Cells[3].Value.ToString();
                pc.lblstock.Text = dgvproduit.CurrentRow.Cells[2].Value.ToString();
             
                pc.ShowDialog();
            }  
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_produit_commande fr = new FRM_produit_commande(this);
            produit pr = new produit();
            if (dgvcommand.CurrentRow!=null)
            {
                fr.grproduits.Text = "modifier produit";
                fr.Lbi.Text = dgvcommand.CurrentRow.Cells[0].Value.ToString();
                fr.lblnom.Text = dgvcommand.CurrentRow.Cells[1].Value.ToString();
                // importer stock
                int idp = int.Parse(dgvcommand.CurrentRow.Cells[0].Value.ToString());
                pr = db.produits.Single(s => s.id_produit ==idp );
                fr.lblstock.Text = pr.quantite.ToString();
                //////////////////////////////////////////////
                fr.lblprix.Text = dgvcommand.CurrentRow.Cells[3].Value.ToString();
                fr.txtqte.Text = dgvcommand.CurrentRow.Cells[2].Value.ToString();
                fr.txtremise.Text = dgvcommand.CurrentRow.Cells[4].Value.ToString();
                fr.txttotal.Text = dgvcommand.CurrentRow.Cells[5].Value.ToString();
                fr.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvcommand.CurrentRow!=null)
            {
                // suuprimer produit dans la list
                int index = BL.D_Commande.list_det_comm.FindIndex(s => s.id == int.Parse(dgvcommand.CurrentRow.Cells[0].Value.ToString()));
                BL.D_Commande.list_det_comm.RemoveAt(index);
                rempldgv_commande();
            }
        }



        private void txttva_TextChanged(object sender, EventArgs e)
        {
            rempldgv_commande();
        }

        // id client
        public int id_clie;

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            BL.class_commande_detail_commande dc = new BL.class_commande_detail_commande();
            if (dgvcommand.Rows.Count==0)
            {
                MessageBox.Show("ajouter des produit", "enregisrement");
            }
            else
            {
                if (txtnom.Text=="")
                {
                    MessageBox.Show("ajouter des client", "enregisrement");
                }
                else
                {
                    // enregistrer vente

                    dc.ajouter_vente(dateTimePicker1.Value, id_clie, txtht.Text, txttva.Text, txtttc.Text);
                    // enregistrer detail commande dans database
                    foreach (var item in BL.D_Commande.list_det_comm)
                    {
                        dc.ajouter_detail_vente(item.id, item.nom, item.qte, item.prix, item.remise, item.total);
                    }
                    
                    (uservente as User_liste_commande).remplir_dgv();
                    dgvcommand.Rows.Clear();
                    
                    BL.D_Commande.list_det_comm.Clear();
                   // quitter form
                  //  Close();
                    MessageBox.Show("vente ajouté avec succes", "vente");

                }
            }
        }
    }
}
