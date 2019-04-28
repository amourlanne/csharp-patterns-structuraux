using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionsMathematiques
{
    public interface INoeud
    {
        String Afficher();
        INoeud Deriver();
    }
}