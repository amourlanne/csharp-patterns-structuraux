using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concessionnaire
{
    public class VéhiculeAvecOptionPeintureMétalisée : VéhiculeAvecOption
    {
        private static String LibelléOption = "Peinture Métalisée";

        public VéhiculeAvecOptionPeintureMétalisée(Véhicule véhicule, float prixOption) : base(véhicule, prixOption, LibelléOption)
        {
        }
    }
}