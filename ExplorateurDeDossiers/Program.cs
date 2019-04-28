using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurDeDossiers
{
    class Program
    {
        static void Main(string[] args)
        {
            DossierProxy racine = new DossierProxy("/Utilisateurs/Alexis");

            racine.Contenu();

            racine.Charger();

            racine.Contenu();
        }
    }
}
