using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class class_commande_detail_commande
    {
        private DbStockContext db = new DbStockContext();

        private vente clsvent;
        private vente_detail clsdet_vent;
        public int id_vent;

        // premiere chose c'est sauvegarder vente
        public void ajouter_vente(DateTime dv ,int id_cli , string totalht,string tva,string totalttc)
        {
            clsvent = new vente();
            clsvent.date_vente = dv;
            clsvent.id_client = id_cli;
            clsvent.TotalHT = totalht;
            clsvent.Tva = tva;
            clsvent.TTC = totalttc;

            db.ventes.Add(clsvent);
            db.SaveChanges();

            id_vent = clsvent.id_vente;  // id_vente automatique
        }
        // puis on ajoute detail vente
        public void ajouter_detail_vente(int id_prod,string nomprod,int qte,string prix,string rem,string tot)
        {
            clsdet_vent = new vente_detail();

            clsdet_vent.id_vente = id_vent;  // id_vente

            clsdet_vent.id_produit = id_prod;
            clsdet_vent.nom_produit = nomprod;
            clsdet_vent.quantity = qte;
            clsdet_vent.prix = prix;
            clsdet_vent.remise = rem;
            clsdet_vent.total = tot;

            db.vente_detail.Add(clsdet_vent);
            db.SaveChanges();
        }

    }
}
