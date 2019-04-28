using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TraitementDeTexte
{
    public interface ICaractere
    {
        void Afficher( int position, bool gras, bool italique, bool souligne, bool majuscule);
    }
}