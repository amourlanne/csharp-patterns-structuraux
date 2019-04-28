using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public class OperateurDivFactory : OperateurFactory
    {
        public override Operateur Construire(INoeud operande1, INoeud operande2)
        {
            return new OperateurDiv(operande1, operande2);
        }
    }
}