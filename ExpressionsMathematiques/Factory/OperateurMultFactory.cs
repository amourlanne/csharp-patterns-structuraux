﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public class OperateurMultFactory : OperateurFactory
    {
        public override Operateur Construire(INoeud operande1, INoeud operande2)
        {
            return new OperateurMult(operande1, operande2);
        }
    }
}