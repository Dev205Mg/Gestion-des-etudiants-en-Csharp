using Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    class InfoL2 : Informatique
    {
        public InfoL2(string nom) : base(nom, null)
        {
            this.nom = nom;
            this.niveau = "L2";
        }

        public override void GetNotes()
        {
            Console.WriteLine("Vous matieres sont : HTML/CSS, PHP, C# et PYTHON");
            Assets.GetNotes(4, notes);
        }
    }
}
