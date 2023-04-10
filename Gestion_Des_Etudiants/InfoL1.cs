using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    class InfoL1 : Informatique
    {
        public float note1;
        public float note2;

        public InfoL1(string nom) : base(nom, null)
        {
            this.nom = nom;
            this.niveau = "L1";
        }

        public override void GetNotes()
        {
            Console.WriteLine("Vous matieres sont : ALGORITHME et LANGAGE PASCAL");
            notes.Add("Algo", note1);
            notes.Add("Pascal", note2);
        }
    }
}
