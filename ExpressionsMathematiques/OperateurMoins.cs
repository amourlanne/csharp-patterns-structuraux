using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public class OperateurMoins : Operateur
    {
        public OperateurMoins(INoeud operande1, INoeud operande2) : base(operande1, operande2)
        {
        }

        public override INoeud Deriver()
        {
            return new OperateurMoins(Operande1.Deriver(), Operande2.Deriver());
        }

        public override string GetOperateur()
        {
            return "-";
        }
    }
}