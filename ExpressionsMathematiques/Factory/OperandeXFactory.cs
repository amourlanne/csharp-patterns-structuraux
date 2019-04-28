using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public class OperandeXFactory
    {
        public OperandeX Construire() => OperandeX.GetInstance();
    }
}