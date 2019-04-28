using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public class OperateurMoinsFactory : OperateurFactory
    {
        public override Operateur Construire(INoeud operande1, INoeud operande2)
        {
            return new OperateurMoins(operande1, operande2);
        }
    }
}