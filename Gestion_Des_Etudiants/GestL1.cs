using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    class GestL1 : Gestion
    {
        public float note1;
        public float note2;

        public GestL1(string nom) : base(nom, null)
        {
            this.nom = nom;
            this.niveau = "L1";
        }

        public override void GetMention()
        {
            if (moy < 10)
            {
                mention = "INSUFFISANTE";
            } else if (moy <= 14)
            {
                mention = "ASSEZ BIEN";
            }else if (moy <= 16)
            {
                mention = "BIEN";
            }else if (moy <= 18)
            {
                mention = "TRES BIEN";
            }
            else
            {
                mention = "EXELLENT";
            }
        }

        public override void GetNotes()
        {
            Console.WriteLine("Vous matieres sont : COMPTABILITE et MATHS FI");
            notes.Add(note1);
            notes.Add(note2);
        }

        public override void GetMoyenne()
        {
            moy = ((notes[0] * 2) + (notes[1] * 2)) / notes.Count * 2;
        }
    }
}
