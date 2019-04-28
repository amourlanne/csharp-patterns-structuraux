using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concessionnaire
{
    public class VehiculeAvecOptionToitOuvrant : VéhiculeAvecOption
    {
        private static String LibelléOption = "Toit Ouvrant";

        public VehiculeAvecOptionToitOuvrant(Véhicule véhicule, float prixOption) : base(véhicule, prixOption, LibelléOption)
        {
        }
    }
}