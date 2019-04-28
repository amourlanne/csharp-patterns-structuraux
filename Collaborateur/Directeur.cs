using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collaborateur
{
    public class Directeur : Collaborateur
    {

        private String Service;
        private List<Collaborateur> Collaborateurs = new List<Collaborateur>();

        public Directeur(string nom, string prenom, float salaire, string service) : base ( nom, prenom, salaire)
        {
            Service = service;
        }

        public void AjouterCollaborateur(Collaborateur collaborateur)
        {
            Collaborateurs.Add(collaborateur);
        }

        public void SupprimerCollaborateur(string nom)
        {
            Collaborateurs.Remove(Collaborateurs.FirstOrDefault(collaborateur => collaborateur.GetNom().Equals(nom)));
        }

        public override void Afficher() => Console.WriteLine("{0} {1}: service {2} ({3} collaborateur(s))", Nom, Prenom, Service, Collaborateurs.Count);

        public override float CalculerMS() {
            float MSCollaborateurs = 0;

            Collaborateurs.ForEach(collaborateur => MSCollaborateurs += collaborateur.CalculerMS());
            return Salaire + MSCollaborateurs;
        }
    }
}