using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public abstract class OperateurFactory
    {
        public abstract Operateur Construire( INoeud operande1, INoeud operande2);
    }
}