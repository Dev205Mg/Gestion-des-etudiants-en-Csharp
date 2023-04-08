using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    abstract class Gestion : Etudiant
    {
        public Gestion(string nom, string niveau)
        {
            this.nom = nom;
            this.niveau = niveau;
            filiere = "Gestion";
        }
    }
}
