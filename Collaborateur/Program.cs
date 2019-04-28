using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaborateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Collaborateur collaborateur1 = new Collaborateur("Collaborateur", "1", 1000);
            Collaborateur collaborateur2 = new Collaborateur("Collaborateur", "2", 1000);
            Collaborateur collaborateur3 = new Collaborateur("Collaborateur", "3", 1000);

            Directeur directeur = new Directeur("Directeur", "1", 3000, "Informatique");

            directeur.AjouterCollaborateur(collaborateur1);
            directeur.AjouterCollaborateur(collaborateur2);
            directeur.AjouterCollaborateur(collaborateur3);

            directeur.Afficher();
        }
    }
}
