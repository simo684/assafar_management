using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel;

namespace GestionDeStock.PL
{
    public partial class User_liste_produit : UserControl
    {
        private static User_liste_produit usepro;
        private DbStockContext db;

        // creer propertie pour usercontrol
        public static User_liste_produit instancep
        { get
            {
                if (usepro==null)
                {
                    usepro = new User_liste_produit();
                }
                return usepro;
                ;
            }
            
                  

        }
        // verifier combien de ligne selectionne
        public string select_verif()
        {
            int nbr_selec = 0;
            for (int i = 0; i < dgvproduit.Rows.Count; i++)
            {
                if ((bool) dgvproduit.Rows[i].Cells[0].Value==true)
                {
                    nbr_selec++;
                }
            }
            if (nbr_selec==0)
            {
                return "selectioner une ligne svp";
            }
            if (nbr_selec > 1)
            {
                return "selectioner une seule ligne svp";
            }
            else return null;
        }
        //  actualise datagridview
        public void datagridactuazlis()
        {
            db = new DbStockContext();
            dgvproduit.Rows.Clear();
            categorie cat = new categorie();
            foreach (var p in db.produits)
            {

                cat = db.categories.SingleOrDefault(x => x.id_cat == p.id_categorie); // si id_ca(produit) egal id_categ(categ)
                if (cat != null) // si existe
                {
                    dgvproduit.Rows.Add(false, p.id_produit, p.nom_produit, p.quantite, p.prix_vente, cat.nom_cat);
                }


            }
            // colorer stock null en rouge
            for (int i = 0; i < dgvproduit.Rows.Count; i++)
            {
                if ((int)dgvproduit.Rows[i].Cells[3].Value==0)
                {
                    dgvproduit.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    dgvproduit.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
            }

        }
        public User_liste_produit()
        {
            InitializeComponent();
            db = new DbStockContext();
            txtserchprod.Enabled = false;
            
        }

        private void User_liste_produit_Load(object sender, EventArgs e)
        {
            datagridactuazlis();
        }

        private void txtserchprod_Enter(object sender, EventArgs e)
        {
            if (txtserchprod.Text == "Rechercher")
            {
                txtserchprod.Text = "";
                txtserchprod.ForeColor = Color.Black;
            }
        }

        private void cmbserchprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtserchprod.Enabled = true;
            txtserchprod.Text = "";
            datagridactuazlis();
        }

        private void btnajouter_prod_Click(object sender, EventArgs e)
        {
            PL.FRM_ajouter_modifier_produit fr = new FRM_ajouter_modifier_produit(this);
            fr.ShowDialog();
        }

        private void btnmodifier_prod_Click(object sender, EventArgs e)
        {
            PL.FRM_ajouter_modifier_produit fp = new FRM_ajouter_modifier_produit(this);
            if (select_verif()==null)
            {
                for (int i = 0; i < dgvproduit.Rows.Count; i++) // cherche ligne selectionne
                {
                    if ((bool) dgvproduit.Rows[i].Cells[0].Value==true)
                    {
                        fp.id_select =(int) dgvproduit.Rows[i].Cells[1].Value;
                        fp.txtPRIX.Text = dgvproduit.Rows[i].Cells[4].Value.ToString();
                        fp.txtQUANTITE.Text = dgvproduit.Rows[i].Cells[3].Value.ToString();
                        fp.txtnomPROD.Text = dgvproduit.Rows[i].Cells[2].Value.ToString();
                        fp.cmbprod.Text = dgvproduit.Rows[i].Cells[5].Value.ToString();

                    }
                }
                fp.lbltitre.Text = "modifier produit";
                fp.btnactualiser.Visible = false;
                fp.ShowDialog();
            }
            else
            {
                MessageBox.Show(select_verif());
            }


            
        }

        private void btnsupprimer_prod_Click(object sender, EventArgs e)
        {
            if (select_verif()== "selectioner une ligne svp")
            {
                MessageBox.Show(select_verif());
            }
            else
            {
                DialogResult dr = MessageBox.Show("tu veux supprimer ce produit", "suppressiuon", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                for (int i = 0; i < dgvproduit.Rows.Count; i++)
                {
                    if ((bool)dgvproduit.Rows[i].Cells[0].Value == true)
                    {
                        BL.class_produit pr = new BL.class_produit();
                       
                        if (dr == DialogResult.Yes)
                        {
                            pr.supprim_prod((int)dgvproduit.Rows[i].Cells[1].Value);
                           
                        }

                        else
                            MessageBox.Show("suppression annule", "suppressiuon", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    
                }
                datagridactuazlis();
            }
        }

        private void txtserchprod_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var list_serc = db.produits.ToList();  // crere une liste de produits

            if (txtserchprod.Text !="")
            {
                switch (cmbserchprod.Text)
                {
                    case "nom" :
                        list_serc = list_serc.Where(x => x.nom_produit.IndexOf(txtserchprod.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                        break;
                    case "categorie":
                        list_serc = list_serc.Where(x => x.categorie.nom_cat.IndexOf(txtserchprod.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                        break;
                          
                }


            }
            // charger datagridv
            dgvproduit.Rows.Clear();
            foreach (var item in list_serc)
            {
                dgvproduit.Rows.Add(false, item.id_produit, item.nom_produit, item.quantite, item.prix_vente, item.categorie.nom_cat);
                
            }

        }

        private void btnajouter_client_Click(object sender, EventArgs e)
        {
            db = new DbStockContext();
            int id_select = 0;
            string nom_cat="";
            RAP.FRM_rapport fr = new RAP.FRM_rapport();
            produit pr = new produit();

            if (select_verif()!=null)
            {
                MessageBox.Show(select_verif(), "impression", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                for (int i = 0; i < dgvproduit.Rows.Count; i++)
                {
                    if ((bool) dgvproduit.Rows[i].Cells[0].Value==true)
                    {
                        id_select =(int) dgvproduit.Rows[i].Cells[1].Value;
                        nom_cat =(string) dgvproduit.Rows[i].Cells[5].Value;
                    }
                }
                /////////////////////////////////
                pr = db.produits.SingleOrDefault(x => x.id_produit == id_select);
                if (pr!=null)
                {
                    fr.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.prtproduit.rdlc";// chemin du rapport
                    ReportParameter pcategorie = new ReportParameter("rpt_cat", nom_cat);
                    ReportParameter pnom = new ReportParameter("rpt_nom", pr.nom_produit);
                    ReportParameter pquantite = new ReportParameter("rptquantite", pr.quantite.ToString());
                    ReportParameter prprix = new ReportParameter("rptprix", pr.prix_vente);
                    // sauvegarder
                    fr.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pcategorie, pnom, pquantite, prprix });
                    fr.reportViewer1.RefreshReport();
                    fr.ShowDialog();
                }
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            RAP.FRM_rapport fr = new RAP.FRM_rapport();
            db = new DbStockContext();

            try
            {
                var list = db.produits.ToList();

                fr.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.rpt_tousproduit.rdlc";// chemin du rapport
                fr.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetproduits", list));
                ReportParameter date = new ReportParameter("Date", DateTime.Now.ToString());
                fr.reportViewer1.LocalReport.SetParameters(date); // ou new ReportParameter[] { date }
                fr.reportViewer1.RefreshReport();
                fr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexcell_Click(object sender, EventArgs e)
        {
            db = new DbStockContext();
            using (SaveFileDialog sd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })

                //filtrer only fich excel
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;

                        // add line file excel
                        ws.Cells[1, 1] = "id produit";
                        ws.Cells[1, 2] = "nom produit";
                        ws.Cells[1, 3] = "quantite produit";
                        ws.Cells[1, 4] = "prix produit";

                        // add list produit to file excel
                        var listprod = db.produits.ToList();
                        int i = 2;
                        foreach (var l in listprod)
                        {
                            ws.Cells[i, 1] = l.id_produit;
                            ws.Cells[i, 2] = l.nom_produit;
                            ws.Cells[i, 3] = l.quantite;
                            ws.Cells[i, 4] = l.prix_vente;
                            i++;
                        }
                        // CHANGER  STYLE   DE FICHIER
                        ws.Range["A1:D1"].Interior.Color = Color.Teal;
                        ws.Range["A1:D1"].Font.Color = Color.White;
                        ws.Range["A1:D1"].Font.Size = 15;
                        ws.Range["A1:D1"].ColumnWidth = 16;
                        ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;

                        wb.SaveAs(sd.FileName);
                        app.Quit();
                        MessageBox.Show("sauvegarde avec succes");
                    }
                }                                                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridactuazlis();
        }
    }
}
