using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionsMathematiques
{
    class Program
    {
        static void Main(string[] args)
        {
            OperateurFactory soustraction = new OperateurMoinsFactory();
            OperateurFactory addition = new OperateurPlusFactory();
            OperateurFactory multiplication = new OperateurMultFactory();

            OperandeXFactory operandex = new OperandeXFactory();
            OperandeConstanteFactory constante = new OperandeConstanteFactory();

            OperandeX x = operandex.Construire();
            OperandeConstante deux = constante.Construire(2);

            INoeud deuxMoinsX = soustraction.Construire(deux, x);
            INoeud xPlusDeux = addition.Construire(x, deux);

            INoeud n1MultN2 = multiplication.Construire(deuxMoinsX, xPlusDeux);

            Console.WriteLine(n1MultN2.Afficher());

            INoeud n1MultN2Prime = n1MultN2.Deriver();

            Console.WriteLine(n1MultN2Prime.Afficher());
        }
    }
}
