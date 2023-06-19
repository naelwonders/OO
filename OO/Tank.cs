using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    internal class Tank
    {
        public Nation nation;
        private int _vie = 400;
        public string Nom { get; set; }
        public int Vie
        {
            get
            {
                return _vie;
            }
            private set
            {
                if (value < 0) _vie = 0;
                else if (value > VieMax) _vie = VieMax;
                else _vie = value;
            }
        }

        public int VieMax { get; private set; } = 400;
        public int NBUnite
        {
            get { return _vie / 40; }
        }
        public int Puissance { get; set; }
        public int Defense { get; set; }
        public void SeBlesser(int degat)
        {
            
            int degatReduit = degat - Defense;
            if (degatReduit > 0) Vie -= degatReduit;
        }
        public void Tirer(Tank adversaire)
        {
            if (adversaire == null) return;
            if (adversaire.nation == nation) return; // si dans la meme nation, on fait r
            int degat = Puissance * NBUnite;
            adversaire.SeBlesser(degat);
        }
    }

}
