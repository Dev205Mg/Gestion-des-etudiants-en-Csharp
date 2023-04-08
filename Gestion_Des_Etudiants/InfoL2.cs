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

        public override void GetMention()
        {
            throw new NotImplementedException();
        }

        public override void GetMoyenne()
        {
            throw new NotImplementedException();
        }

        public override void GetNotes()
        {
            throw new NotImplementedException();
        }
    }
}
