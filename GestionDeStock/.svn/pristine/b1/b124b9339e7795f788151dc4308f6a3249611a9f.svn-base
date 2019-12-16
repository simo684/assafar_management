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
    public partial class FRM_client_vente : Form
    {
        private DbStockContext db;

        public FRM_client_vente()
        {
            InitializeComponent();
            db = new DbStockContext();
        }

        private void FRM_client_vente_Load(object sender, EventArgs e)
        {
            db = new DbStockContext();
            foreach (var c in db.clients)
            {
                dgvclient.Rows.Add(c.id_client, c.name, c.prenom, c.adress, c.ville, c.tel, c.Email);
            }

        }

        private void txtnomPROD_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var list_serc = db.clients.ToList();
            list_serc = list_serc.Where(x => x.name.IndexOf(txtserch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dgvclient.Rows.Clear();
            foreach (var item in list_serc)
            {
                dgvclient.Rows.Add(item.id_client, item.name, item.prenom, item.adress,item.ville,item.tel,item.Email);
            }
        }

        private void txtserch_Enter(object sender, EventArgs e)
        {
            if (txtserch.Text == "RECHERCHE")
            {
                txtserch.Text = "";
            }
        }

        private void dgvclient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //quitter
            Close();
        }
    }
}
