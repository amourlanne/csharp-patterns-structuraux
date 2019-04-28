using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExplorateurDeDossiers
{
    public class DossierReel : IDossier
    {
        private string Chemin;

        private List<IFichier> Fichiers;

        public DossierReel(string chemin)
        {
            Chemin = chemin;

            Fichiers = new List<IFichier>();
            // TODO : charger dossier à partir du chemin
            Fichiers.Add(new DossierProxy("/Utilisateurs/Alexis/Documents"));
            Fichiers.Add(new Fichier("/Utilisateurs/Alexis/README.md"));
            Fichiers.Add(new Fichier("/Utilisateurs/Alexis/proxy.conf"));
        }

        public void Contenu()
        {
            Fichiers.ForEach(fichier => fichier.Contenu());
        }

        public IDossier GetElement()
        {
            return this;
        }
    }
}