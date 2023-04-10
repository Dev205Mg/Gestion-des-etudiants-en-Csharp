using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    class InfoL2 : Informatique
    {
        public float note1;
        public float note2;
        public float note3;
        public float note4;

        public InfoL2(string nom) : base(nom, null)
        {
            this.nom = nom;
            this.niveau = "L2";
        }

        public override void GetNotes()
        {
            Console.WriteLine("Vous matieres sont : HTML/CSS, PHP, C# et PYTHON");
            notes.Add("Html", note1);
            notes.Add("Php", note2);
            notes.Add("C sharp", note3);
            notes.Add("Python", note4);
        }
    }
}
