using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public class OperateurDiv : Operateur
    {
        public OperateurDiv(INoeud operande1, INoeud operande2) : base(operande1, operande2)
        {
        }

        public override INoeud Deriver()
        {
            return new OperateurDiv(Operande1.Deriver(), Operande2.Deriver());
        }

        public override string GetOperateur()
        {
            return "/";
        }
    }
}