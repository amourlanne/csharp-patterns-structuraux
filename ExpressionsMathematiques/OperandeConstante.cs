using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public class OperandeConstante : INoeud
    {
        private int Value;

        private static List<OperandeConstante> Operandes;

        private OperandeConstante(int value)
        {
            Value = value;
        }

        public static OperandeConstante getInstance(int value)
        {
            if(Operandes == null)
            {
                Operandes = new List<OperandeConstante>();
            }

            OperandeConstante operandeConstante = Operandes.FirstOrDefault(operande => operande.getValue().Equals(value));

            if(operandeConstante == null)
            {
                operandeConstante = new OperandeConstante(value);
                Operandes.Add(operandeConstante);
            }

            return operandeConstante;
        }

        public int getValue() => Value;

        public String Afficher() => Value.ToString();

        public INoeud Deriver()
        {
            return OperandeConstante.getInstance(0);
        }
    }
}