using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExplorateurDeDossiers
{
    public class DossierProxy : IDossier, IFichier
    {
        private DossierReel Dossier;

        private String Chemin;

        public DossierProxy(String chemin)
        {
            Chemin = chemin;
        }

        public void Charger()
        {
            Dossier = new DossierReel(Chemin);
            Console.WriteLine("-- Chargement du dossier {0} --", Chemin);
        }
    
        public void Contenu()
        {
            if(Dossier == null)
            {
                Console.WriteLine(Chemin + "(Non chargé)");
            } else {
                Console.WriteLine(Chemin + ":");
                Dossier.Contenu();
            }
        }

        public IDossier GetElement()
        {
            if (Dossier == null)
            {
                return this;
            }
            else
            {
                return Dossier.GetElement(); ;
            }
        }
    }
}