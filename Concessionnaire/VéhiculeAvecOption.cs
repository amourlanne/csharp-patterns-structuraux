using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concessionnaire
{
    public abstract class VéhiculeAvecOption : Véhicule
    {
        private Véhicule Véhicule;

        private String Libellé;

        private float Prix;


        public VéhiculeAvecOption( Véhicule véhicule, float prixOption, String libelléOption )
        {
            Véhicule = véhicule;
            Libellé = véhicule.GetLibellé() + libelléOption + " ";
            Prix = véhicule.GetPrix() + prixOption;
        }

        public override String GetLibellé() => Libellé;
        public override float GetPrix() => Prix;
       
    }
}