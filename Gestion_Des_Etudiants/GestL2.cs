using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    class GestL2 : Gestion
    {
        public float note1;
        public float note2;
        public float note3;

        public GestL2(string nom) : base(nom, null)
        {
            this.nom = nom;
            this.niveau = "L2";
        }

        public override void GetNotes()
        {
            Console.WriteLine("Vous matieres sont : COMPTABILITE 2, DROIT DES AFFAIRES et MATHS FI 2");
            notes.Add("Compta2", note1);
            notes.Add("Droit", note2);
            notes.Add("MathsFi2", note3);
        }
    }
}
