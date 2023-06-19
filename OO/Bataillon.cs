using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    // bc de repetition entre tank et soldat donc on va faire une classe generalisée 

    internal class Bataillon
    {
        private int _vie;
        public Nation nation;

        public string Nom { get; set; }
        // Vie et _vie max ont besoin d'abstraction/ constructeur
        /*public int Vie
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

        public int VieMax { get; private set; }*/

        /*public int NBUnite
        {
            get { return _vie / 40; }
        }*/
        public int Puissance { get; set; }
        public int Defense { get; set; }
    // parametres de mauvais type (seBlesser
    public void SeBlesser(int degat)
    {

        int degatReduit = degat - Defense;
        //if (degatReduit > 0) Vie -= degatReduit;
    }

    }
}
