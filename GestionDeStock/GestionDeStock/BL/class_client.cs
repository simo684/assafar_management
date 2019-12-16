using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class class_client
    {
        private DbStockContext db = new DbStockContext();
        private client cl;

        // fonction pour ajouter un client
        public bool ajouter_clien(string nom, string prenome, string adre, string vill, string telep
                                          , string emai)
        {
            cl = new client();
            cl.name = nom;
            cl.prenom = prenome;
            cl.adress = adre;
            cl.ville = vill;
            cl.tel = telep;
            cl.Email = emai;
            // verifier si nom existe et prenom existe
            if (db.clients.SingleOrDefault(x => x.name == nom && x.prenom == prenome) == null)// si n'existe pas
            {
                db.clients.Add(cl);  // ajout table client
                db.SaveChanges();     // enregistre  dans database 
                return true; 
            }
            else return false;
        }
        // function update client
        public void modifier_client(int id , string nom, string prenome, string adre, string vill, string telep,string emai)
        {
            cl = new client();
           cl= db.clients.SingleOrDefault(x => x.id_client == id); // verifier si id client exist
            if (cl!=null)  // exist
            {
                cl.name = nom;        // nouveau nom
                cl.prenom = prenome;
                cl.adress = adre;
                cl.ville = vill;
                cl.tel = telep;
                cl.Email = emai;

                db.SaveChanges();      // // enregistre  dans database 
            }
        }

        // function delete client
        public void delete_client(int id)
        {
            cl = new client();
         cl=   db.clients.SingleOrDefault(x => x.id_client == id);

            if (cl!=null)
            {
                db.clients.Remove(cl);
                db.SaveChanges();
            }

        }
    }
}
