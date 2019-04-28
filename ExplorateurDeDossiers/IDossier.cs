using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExplorateurDeDossiers
{
    public interface IDossier
    {
        void Contenu();
        IDossier GetElement();
    }
}