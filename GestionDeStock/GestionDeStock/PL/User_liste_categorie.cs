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
    public partial class User_liste_categorie : UserControl
    {
        private static User_liste_categorie usercat;
        private DbStockContext db;

        // crere instance user_lis_cat
        public static User_liste_categorie instance
        { get
            {
                if (usercat == null)
                {
                    usercat = new User_liste_categorie();
                }  ;
                return usercat;
            }
                

         }


        public User_liste_categorie()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        public void remplir_datagrid()
        {
            dgvcat.Rows.Clear();
            db = new DbStockContext();
            foreach (var item in db.categories)
            {
                dgvcat.Rows.Add(false, item.id_cat, item.nom_cat);
            }
        } 

        private void User_liste_categorie_Load(object sender, EventArgs e)
        {
            remplir_datagrid();
        }

        private void txtserchcat_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var list_serc = db.categories.ToList();
            list_serc = list_serc.Where(x => x.nom_cat.IndexOf(txtserchcat.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dgvcat.Rows.Clear();
            foreach (var item in list_serc)
            {
                dgvcat.Rows.Add(false, item.id_cat,item.nom_cat);
            }
        }

        private void txtserchcat_Enter(object sender, EventArgs e)
        {
            if (txtserchcat.Text=="Rechercher")
            {
                txtserchcat.Text = "";
            }
        }

        private void btnajouter_cat_Click(object sender, EventArgs e)
        {
            PL.FRM_ajouter_modifier_categorie cat = new FRM_ajouter_modifier_categorie(this);
            cat.ShowDialog();
        }

        private void dgvcat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FRM_ajouter_modifier_categorie cat = new FRM_ajouter_modifier_categorie(this);
            if (dgvcat.Columns[e.ColumnIndex].Name== "Modifier")//si clic sur btn modif
            {
                cat.lbltitre.Text = "modifier categorie";
                cat.id_sele = (int)dgvcat.Rows[e.RowIndex].Cells[1].Value;
                cat.txtnomCAT.Text = dgvcat.Rows[e.RowIndex].Cells[2].Value.ToString();
                cat.ShowDialog();
            }
            if (dgvcat.Columns[e.ColumnIndex].Name=="supprimer")// si clic su supprimer
            {
                int id =(int) dgvcat.Rows[e.RowIndex].Cells[1].Value;
                BL.class_categorie cc = new BL.class_categorie();
                DialogResult dr = MessageBox.Show("tu veux supprimer categ", "suppression",MessageBoxButtons.YesNo);
                if (dr==DialogResult.Yes)
                {
                    // verifier combien de produit dans cette categ
                    int p = db.produits.Count(x => x.id_categorie == id);
                    
                    if (p==0)
                    {
                        MessageBox.Show("cette categ est vide");
                        cc.supprim_cat(id);
                        remplir_datagrid();
                    }
                    else
                    {
                     DialogResult rd=   MessageBox.Show("attension " + p + " produits vont etre suuprim ","suppression",MessageBoxButtons.YesNo);
                        if (rd == DialogResult.Yes)
                        {
                            cc.supprim_cat(id);
                            remplir_datagrid();
                        }
                        else MessageBox.Show("supresion annule", "suppression");


                    }
                    
                }
               
                
            }
        }

        private void btnexcell_Click(object sender, EventArgs e)
        {

        }
    }
}
