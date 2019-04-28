using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collaborateur
{
    public class Collaborateur : ISalarie
    {
        protected String Nom;
        protected String Prenom;

        protected float Salaire;

        public Collaborateur(string nom, string prenom, float salaire)
        {
            Nom = nom;
            Prenom = prenom;
            Salaire = salaire;
        }

        public virtual void Afficher() => Console.WriteLine("{0} {1}", Nom, Prenom);

        public virtual float CalculerMS() => Salaire;

        public String GetNom() => Nom;
        public String GetPrenom() => Prenom;

        public float GetSalaire() => Salaire;
    }
}