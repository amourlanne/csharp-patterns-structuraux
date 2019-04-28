using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public class OperandeConstanteFactory
    {
        public OperandeConstante Construire(int value) => OperandeConstante.getInstance(value);
    }
}