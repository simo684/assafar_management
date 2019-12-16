using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GestionDeStock.PL
{
    public partial class User_liste_fournisseur : UserControl
    {
        private static User_liste_fournisseur userfourn;
        private DbStockContext db;

        // crer instance user fourn
        public static User_liste_fournisseur instance
        {
            get
            {
                if (userfourn == null)
                {
                    userfourn = new User_liste_fournisseur();
                }
                return userfourn ;

            }
        }

        public User_liste_fournisseur()
        {
            InitializeComponent();
            db = new DbStockContext();
        }

        private void User_liste_fournisseur_Load(object sender, EventArgs e)
        {
           
        }

        private void btnajouter_fournsii_Click(object sender, EventArgs e)
        {
            PL.FRM_ajouter_modifier_fournisseur fr = new FRM_ajouter_modifier_fournisseur();
            fr.ShowDialog();
        }
    }
}
