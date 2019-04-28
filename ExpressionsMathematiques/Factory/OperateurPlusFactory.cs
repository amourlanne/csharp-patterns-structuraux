using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public class OperateurPlusFactory : OperateurFactory
    {
        public override Operateur Construire(INoeud operande1, INoeud operande2)
        {
            return new OperateurPlus(operande1, operande2);
        }
    }
}