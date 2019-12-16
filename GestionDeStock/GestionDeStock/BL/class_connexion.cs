using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class class_connexion
    {
        // method pour verifier connexion
        public bool connexion_valid(DbStockContext db , string nom , string pass)
        {

           // utilisateur u = new utilisateur();
            //u.nom_user = nom;
            //u.pass_word = pass;
            if (db.utilisateurs.SingleOrDefault(x=>x.nom_user==nom && x.pass_word==pass)!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
