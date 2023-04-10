using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Des_Etudiants
{
    class Program
    {
        static void Afficher(string f, string n, string nom, float[] notes)
        {
            Console.WriteLine("filiere : " + f);
            Console.WriteLine("niveau : " + n);
            Console.WriteLine("nom : " + nom);
            foreach(var note in notes)
            {
                Console.WriteLine("Note : " + note);
            }
            
        }
        static void Main(string[] args)
        {/*
            Console.Write("Entrez votre filiere : ");
            string filiere = Console.ReadLine();

            Console.Write("Entrez votre niveau : ");
            string niveau = Console.ReadLine();

            Console.Write("Entrez votre nom : ");
            string nom = Console.ReadLine();

            Console.Write("Entrez vos notes :\n Note1 : ");
            var notes = new float[3];
            notes[0] = float.Parse(Console.ReadLine());
            Console.Write(" Note2 : ");
            notes[1] = float.Parse(Console.ReadLine());
            Console.Write(" Note3 : ");
            notes[2] = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Afficher(filiere, niveau, nom, notes);
            */
            var julie = new GestL1("julie");
            julie.note1 = 14.5f;
            julie.note2 = 18.5f;
            julie.GetNotes();
            julie.GetMoyenne();
            julie.GetMention();
            julie.ImprimBulletin();

            var dolph = new InfoL1("dolph");
            dolph.note1 = 18;
            dolph.note2 = 19.75f;
            dolph.GetNotes();
            dolph.GetMoyenne();
            dolph.GetMention();
            dolph.ImprimBulletin();

            var claire = new GestL2("claire");
            claire.note1 = 10.5f;
            claire.note2 = 11f;
            claire.note3 = 10f;
            claire.GetNotes();
            claire.GetMoyenne();
            claire.GetMention();
            claire.ImprimBulletin();

            var jimmy = new InfoL2("jimmy");
            jimmy.note1 = 18.75f;
            jimmy.note2 = 7.5f;
            jimmy.note3 = 10;
            jimmy.note4 = 15f;
            jimmy.GetNotes();
            jimmy.GetMoyenne();
            jimmy.GetMention();
            jimmy.ImprimBulletin();

            Console.ReadKey();
        }
    }
}
