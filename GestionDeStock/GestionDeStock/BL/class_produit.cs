using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class class_produit
    {
        private DbStockContext db = new DbStockContext();
        private produit prod;

        // fonction pour ajouter un produit
        public bool ajout_produit(string nom,int qte,string prix,int id_cat)
        {
            prod = new produit();
            prod.nom_produit = nom;
            prod.quantite = qte;
            prod.prix_vente = prix;
            prod.id_categorie = id_cat;

            // verifier si produit existe 
            if (db.produits.SingleOrDefault(x => x.nom_produit == nom) == null)// si n existepas
            {
                db.produits.Add(prod);
                db.SaveChanges();
                return true;
            }
            else return false;
        }
        // funct update produit
        public void modifier_produit(int id , string nom, int qte, string prix, int id_cat)
        {
            prod = new produit();
            prod = db.produits.SingleOrDefault(x => x.id_produit == id);
            if (prod!=null)
            {
                prod.nom_produit = nom;
                prod.quantite = qte;
                prod.prix_vente = prix;
                prod.id_categorie = id_cat;
                db.SaveChanges();
            }
           
            
        }
        // func delete product
        public void supprim_prod(int id)
        {
            prod = new produit();
            prod = db.produits.SingleOrDefault(x => x.id_produit == id);
            if (prod!=null)
            {
                db.produits.Remove(prod);
                db.SaveChanges();
            }
        }

    }
}
