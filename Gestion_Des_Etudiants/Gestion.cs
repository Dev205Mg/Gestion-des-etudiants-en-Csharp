namespace Gestion_Des_Etudiants
{
    abstract class Gestion : Etudiant
    {
        public Gestion(string nom, string niveau)
        {
            this.nom = nom;
            this.niveau = niveau;
            filiere = "Gestion";
        }
    }
}
