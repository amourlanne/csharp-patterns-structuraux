using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public class OperandeX : INoeud
    {
        private static OperandeX Operande;

        private OperandeX()
        {
        }

        public static OperandeX GetInstance()
        {
            if(Operande == null)
            {
                Operande = new OperandeX();
            }

            return Operande;
        }
        public String Afficher() => "x";

        public INoeud Deriver()
        {
            return OperandeConstante.getInstance(1);
        }
    }
}