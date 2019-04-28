using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concessionnaire
{
    public class VéhiculeSansOption : Véhicule
    {
        private String Marque;
        private String Modèle;
        private float Prix;

        public VéhiculeSansOption(String marque, String modèle, float prix)
        {
            Marque = marque;
            Modèle = modèle;
            Prix = prix;
        }
   
        public override String GetLibellé() => Marque + " " + Modèle + ": ";
        public override float GetPrix() => Prix;


    }
}