using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TraitementDeTexte
{
    public class Caractere : ICaractere
    {
        private String Lettre;
        private int Taille;
        private String Police;
        private String Couleur;

        public Caractere(int taille, String lettre, string police, String couleur)
        {
            Taille = taille;
            Lettre = lettre;
            Police = police;
            Couleur = couleur;
        }

        public void Afficher(int position, bool gras, bool italique, bool souligne, bool majuscule)
        {
            String writeLetter = Lettre;
            if (majuscule) writeLetter = writeLetter.ToUpper();
            // TODO: couleur, position, gras, souligne
            Console.WriteLine(writeLetter);
        }
    }
}