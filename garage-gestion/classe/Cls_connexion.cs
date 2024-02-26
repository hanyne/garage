using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage_gestion.classe
{
    internal class Cls_connexion
    {
        public bool ConnexionValide(dbGarage db, string Nom, string Mot_de_passe)
        {
            Utilisateurs U = new Utilisateurs();
            U.NomUtilisateur = Nom;
            U.MotDePasse = Mot_de_passe;
            if (db.Utilisateurs.SingleOrDefault(s => s.NomUtilisateur == Nom && s.MotDePasse == Mot_de_passe) != null)

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
