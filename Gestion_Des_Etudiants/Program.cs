using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outils;

namespace Gestion_Des_Etudiants
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumFiliere = Assets.GetNombre(2, "Votre filiere : \n    1:Gestion\n    2:Informatique\n    choix : ");
            int NumNiveau = Assets.GetNombre(2, "Votre niveau : \n    1:L1\n    2:L2\n    choix : ");
            string nom = Assets.GetNom("Votre nom s'il vous plait : ");
            var etudiant = Assets.ClasseChoisi(NumFiliere, NumNiveau, nom);
            Assets.AppelMethodeEtudiant(etudiant);

            
            Console.ReadKey();
        }
    }
}
