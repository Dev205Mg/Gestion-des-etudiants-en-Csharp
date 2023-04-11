using Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    class GestL1 : Gestion
    {
        public GestL1(string nom) : base(nom, null)
        {
            this.nom = nom;
            this.niveau = "L1";
        }

        public override void GetNotes()
        {
            Console.WriteLine("Vous matieres sont : COMPTABILITE et MATHS FI");
            Assets.GetNotes(2, notes);
        }

    }
}
