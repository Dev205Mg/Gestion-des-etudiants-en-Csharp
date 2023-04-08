using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    abstract class Informatique : Etudiant
    {
        public Informatique(string nom, string niveau)
        {
            this.nom = nom;
            filiere = "Informatique";
            this.niveau = niveau;
        }
    }
    
}
