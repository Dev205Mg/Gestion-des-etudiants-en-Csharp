using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    abstract class Etudiant
    {
        protected string nom;
        protected string filiere;
        protected string niveau;
        protected Dictionary<string, float> notes = new Dictionary<string, float>();
        protected string mention;
        protected float moy;

        public void ImprimBulletin()
        {
            Console.WriteLine("**************************************************");
            AfficherInformation();
            Console.WriteLine("**************************************************");
        }

        private void AfficherInformation()
        {
            Console.WriteLine("FILIERE   : " + filiere);
            Console.WriteLine("  NIVEAU  : " + niveau);
            Console.WriteLine("  NOM     : " + nom);
            Console.WriteLine("  MOYENNE : " + moy);
            Console.WriteLine("  MENTION : " + mention);
        }

        public abstract void GetNotes();

        public void GetMoyenne()
        {
            foreach (var note in notes)
            {
                moy += note.Value;
            }

            moy /= notes.Count;
        }

        public void GetMention()
        {
            if (moy < 10)
            {
                mention = "INSUFFISANTE";
            }
            else if (moy <= 14)
            {
                mention = "ASSEZ BIEN";
            }
            else if (moy <= 16)
            {
                mention = "BIEN";
            }
            else if (moy <= 18)
            {
                mention = "TRES BIEN";
            }
            else
            {
                mention = "EXELLENT";
            }
        }
    }
}
