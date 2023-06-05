using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    internal class Soldat
    {
        #region fields (espace memoire)
        private string nom;
        private int _vie = 100; // ca indique un champs privé sans fouiller dans les fichiers
        private int nbUnite;
        // pas besoin de champs pour vieMax, puissance et defence
        
        #endregion

        #region properties (control des acces aux fields)
        public string Nom { get; private set; }
        
        public int Vie
        {
            get
            {
                return _vie;
            }
            private set //seul le soldat peut controller sa vie
            {
                if (value > 0)
                {
                    _vie = 0;
                }
                else
                {
                    _vie = value;
                }
            }
        }

        //autopropriété, pas de conditions donc on peut faire un racourcis (pas besoin de champs)
        public int VieMax {get; private set;} = 100;

        public int NbUnite
        {
            get
            {
                nbUnite = _vie / 10;
                return nbUnite;
            }
        }
        public int Puissance { get; set; }
        public int Defense { get; set; }

        #endregion

        #region Methods
        public void Aie(int degat)
        {
            //faire les degats
            _vie = _vie - degat;
        }

        public void Piew_piew(Soldat adversaire) 
        {
            //tirer sur un autre
            int degat = Puissance * NbUnite;
            adversaire.Aie(degat);
        }
        #endregion
    }
}
