using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    internal class Soldat //internal c'est accessible que pour le projet
    {
        #region fields (espace memoire)
        
        private int _vie = 100; // ca indique un champs privé sans fouiller dans les fichiers
        public Nation nation;
        // pas besoin de champs pour vieMax, puissance et defence

        #endregion

        #region properties (control des acces aux fields)
        public string Nom { get; set; }
        
        public int Vie
        {
            get
            {
                return _vie;
            }
            private set //seul le soldat peut controller sa vie
            {
                // si il n'y a qu'une instruction après le if, on ne doit pas mettre les accolades
                if (value < 0) _vie = 0;
                else if (value > VieMax) _vie = VieMax;
                else _vie = value;
            }
        }

        //autopropriété, pas de conditions donc on peut faire un racourcis (pas besoin de champs)
        public int VieMax {get; private set;} = 100;

        public int NbUnite {
            get { return Vie / 10; }
        }
        public int Puissance { get; set; }
        public int Defense { get; set; }

        #endregion

        #region Methods
        public void Aie(int degat)
        {
            //faire les degats, reduit par la defense
            int degatReduit = degat - Defense;
            // pour ne pas avoir de degats positifs
            if (degatReduit > 0) Vie -= degatReduit;
        }
        public void Piew_piew(Soldat adversaire) 
        {
            //tirer sur un autre
            if (adversaire is null) return; // gestion d'exception
            if (adversaire.nation == this.nation) return;
            int degat = Puissance * NbUnite;
            adversaire.Aie(degat);
        }
        #endregion
    }
}
