using Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    class InfoL1 : Informatique
    {
        public InfoL1(string nom) : base(nom, null)
        {
            this.nom = nom;
            this.niveau = "L1";
        }

        public override void GetNotes()
        {
            Console.WriteLine("Vous avez 02 matieres : ALGORITHME et LANGAGE PASCAL");
            Assets.GetNotes(2, notes);
        }
    }
}
