using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TraitementDeTexte
{
    public class CaractereFactory
    {
        public Caractere Creer( int taille, String lettre, String police, String couleur)
        {
            return new Caractere(taille, lettre, police, couleur);
        }
    }
}