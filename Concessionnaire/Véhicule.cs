using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concessionnaire
{
    public abstract class Véhicule
    {
        public abstract String GetLibellé();
        public abstract float GetPrix();
        public override string ToString()
        {
            return GetLibellé() + "à " + GetPrix() + "€";
        }
    }
}