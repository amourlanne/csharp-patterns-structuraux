using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public abstract class Operateur : INoeud
    {
        protected INoeud Operande1;
        protected INoeud Operande2;

        protected Operateur(INoeud operande1, INoeud operande2)
        {
            Operande1 = operande1;
            Operande2 = operande2;
        }

        public String Afficher() => Operande1.Afficher() + " " + GetOperateur() + " " + Operande2.Afficher();

        public abstract INoeud Deriver();

        public abstract String GetOperateur();
    }
}