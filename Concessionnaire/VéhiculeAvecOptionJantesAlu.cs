using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concessionnaire
{

    public class VéhiculeAvecOptionJantesAlu : VéhiculeAvecOption
    {
        private static String LibelléOption = "Jantes Alu";
        public VéhiculeAvecOptionJantesAlu(Véhicule véhicule, float prixOption) : base(véhicule, prixOption, LibelléOption)
        {
        }
    }
}