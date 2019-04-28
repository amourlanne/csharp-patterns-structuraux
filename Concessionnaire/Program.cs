using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Véhicule clio = new VéhiculeSansOption("Renault", "Clio", 10000);

            clio = new VéhiculeAvecOptionJantesAlu(clio, 600);
            clio = new VéhiculeAvecOptionPeintureMétalisée(clio, 800);
            clio = new VehiculeAvecOptionToitOuvrant(clio, 600);

            Console.WriteLine(clio);
        }
    }
}
