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
    public partial class User_liste_commande : UserControl
    {
        private static User_liste_commande user_comm;
        private DbStockContext db;

        // creer instance pour user control
        public static User_liste_commande instance
        { get
            {
                if (user_comm == null)
                {
                    user_comm = new User_liste_commande();
                }
                return user_comm;
            }
             }

        public User_liste_commande()
        {
            InitializeComponent();
            db = new DbStockContext();
        }

        // remplir datagridv
        public void remplir_dgv()
        {
            client c = new client();
            string nom_prenom;
            dgv_commande.Rows.Clear();
            foreach (var item in db.ventes)
            {
               
                c = db.clients.Single(s => s.id_client == item.id_client);
                nom_prenom = c.name + " " + c.prenom;
                
                dgv_commande.Rows.Add(item.id_vente, item.date_vente, nom_prenom, item.Tva, item.TTC);
            }
        } 
        private void User_liste_commande_Load(object sender, EventArgs e)
        {
            remplir_dgv();
        }

        private void btnajouter_commande_Click(object sender, EventArgs e)
        {
            PL.FRM_detail_vente dv = new FRM_detail_vente(this);
            dv.ShowDialog();

        }
    }
}
