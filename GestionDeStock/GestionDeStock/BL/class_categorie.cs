using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class class_categorie
    {
      private  DbStockContext db = new DbStockContext();
      private  categorie cat;

        // ajout
        public bool ajou_cat(string nom)
        {
            cat = new categorie();
            cat.nom_cat = nom;

            if (db.categories.SingleOrDefault(x=>x.nom_cat==nom)==null)
            {
                db.categories.Add(cat);
                db.SaveChanges();
                return true;
            }
           
            else return false;
        }
        // update
        public void modif_cat (int id , string nom_ca)
        {
            cat = new categorie();
            cat = db.categories.SingleOrDefault(x => x.id_cat == id);
            if (cat!=null)
            {
                cat.nom_cat = nom_ca;
                db.SaveChanges();
            }
        }
        public void supprim_cat(int id)
        {
            cat = new categorie();
            cat = db.categories.SingleOrDefault(x => x.id_cat == id);
            if (cat != null)
            {
                db.categories.Remove(cat);
                db.SaveChanges();
            }
        }

    }
}
