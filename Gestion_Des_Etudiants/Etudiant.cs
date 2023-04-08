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
        protected List<float> notes;
        protected string mention;
        protected float moy;

        public void ImprimBulletin()
        {
            Console.WriteLine("**************************************************");
            AfficherNom();
            Console.WriteLine("**************************************************");
        }

        private void AfficherNom()
        {
            Console.WriteLine("FILIERE : " + filiere);
            Console.WriteLine(" NIVEAU : " + niveau);
            Console.WriteLine(" NOM : " + nom);
            Console.WriteLine(" MOYENNE : " + moy);
            Console.WriteLine(" MENTION : " + mention);
        }

        public abstract void GetNotes();
        public abstract void GetMoyenne();
        public abstract void GetMention();
    }
}
