using Gestion_Des_Etudiants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outils
{
    static class Assets
    {
        public static void GetNotes(int nbrNotes, Dictionary<string, float> notes)
        {
            for (int i = 0; i < nbrNotes; i++)
            {
                notes.Add("Note " + (i + 1),GetFloat(20, "Rentrer la note n°" + (i + 1) + " : "));
            }
        }

        public static float GetFloat(int max, string subject)
        {
            float number;
            while (true)
            {
                Console.Write(subject);
                var num = Console.ReadLine();
                try
                {
                    number = float.Parse(num);
                    if (number >= 0 && number <= max)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez rentrer un nombre entre 0 et  " + max);
                        Console.WriteLine();
                    }

                }
                catch
                {
                    Console.WriteLine("ERREUR ! Rentrer un nombre s'il vous plaît \n");
                }
            }
            return number;
        }

        public static int GetNombre(int max, string subject)
        {
            int number;
            while (true)
            {
                Console.Write(subject);
                var num = Console.ReadLine();
                try
                {
                    number = int.Parse(num);
                    if ( number > 0 && number <= max)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez rentrer un nombre entre 1 et  " + max);
                        Console.WriteLine();
                    }
                    
                }
                catch
                {
                    Console.WriteLine("ERREUR ! Rentrer un nombre s'il vous plaît \n");
                }
            }
            return number;
        }

        public static string GetNom(string question)
        {
            Console.Write(question);
            string nom = Console.ReadLine();
            return nom;
        }

        public static Etudiant ClasseChoisi(int f, int n, string nom)
        {
            if(f == 1 && n == 1)
            {
                var etudiant = new GestL1(nom);
                return etudiant;
            }
            else if(f == 1 && n == 2)
            {
                var etudiant = new GestL2(nom);
                return etudiant;
            }
            else if (f == 2 && n == 1)
            {
                var etudiant = new InfoL1(nom);
                return etudiant;
            }
            else
            {
                var etudiant = new InfoL2(nom);
                return etudiant;
            }
        }

        public static void AppelMethodeEtudiant(Etudiant etudiant)
        {
            etudiant.GetNotes();
            etudiant.GetMoyenne();
            etudiant.GetMention();
            etudiant.ImprimBulletin();
        }
    }
}
