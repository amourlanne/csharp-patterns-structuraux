using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraitementDeTexte
{
    class Program
    {
        static void Main(string[] args)
        {
            CaractereFactory cf = new CaractereFactory();

            int taille = 12;
            String arial = "Arial";
            String noir = "Noir";

            Caractere b = cf.Creer(taille, "b", arial, noir);
            Caractere o = cf.Creer(taille, "o", arial, noir);
            Caractere n = cf.Creer(taille, "n", arial, noir);
            Caractere j = cf.Creer(taille, "j", arial, "Rouge");
            Caractere u = cf.Creer(taille, "u", arial, noir);
            Caractere r = cf.Creer(taille, "r", arial, noir);

            b.Afficher(1, true, false, false, true);
            o.Afficher(2, false, false, false, false);
            n.Afficher(3, false, false, false, false);
            j.Afficher(4, false, false, false, false);
            o.Afficher(5, false, false, false, false);
            u.Afficher(6, false, false, false, false);
            r.Afficher(7, false, false, false, false);
         
        }
    }
}
