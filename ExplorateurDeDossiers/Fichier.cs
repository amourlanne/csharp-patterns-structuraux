using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExplorateurDeDossiers
{
    public class Fichier : IFichier
    {
        private String Chemin;

        public Fichier(string chemin)
        {
            Chemin = chemin;
        }

        public void Contenu()
        {
            Console.WriteLine(Chemin);
        }
    }
}