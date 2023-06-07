using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    internal class Nation
    {
        #region champs
        private Dictionary<string, Soldat> _armee = new Dictionary<string, Soldat>();

        
        #endregion

        #region proprietes
        public string Nom { get; set; }
        public int Credit { get; private set; } = 10_000;
        public Soldat[] Armee {
            get
            {
                //return _armee.Values.ToArray();
                List<Soldat> result = new List<Soldat>();
                foreach (Soldat soldat in _armee.Values) {
                    if (soldat.NbUnite > 0) result.Add(soldat);
                }
                return result.ToArray(); //transphormer en tableau (taille fixe)
            }
        }
        //pas de control donc pas besoin de champs
        #endregion

        #region indexeur
        //on recuperer une valeur grace a un index (de l'element passé en argument)
        //les crochets on besoin de savoir de quoi il s'agit,
        //va chercher l'index du soldat qui a ce nom ?
        public Soldat this[string nom_soldat]
        {
            get
            {
                Soldat soldat = null; //on ne connait pas encore le soldat correspondant, si le nom est faux
                _armee.TryGetValue(Nom, out soldat); //vache qui rit xD
                return soldat;
            }
            set
            {
                if (value is null) return; //ne fait rien si c null
                if (nom_soldat != value.Nom) return; // si le mauvais nom est entré en argument, rien ne se passe
                _armee[nom_soldat] = value;
            }
        }

        #endregion

        #region methodes

        public void Enroller (string nom)
        {
            if (_armee.ContainsKey(nom)) return; // si le soldat existe deja, on ne fait r
            if (Credit < 1000) return; // si j'ai assez d'argent
            Credit -= 1000; // pas besoin de this car il n'y a aucune autre variable credits
            Soldat s = new Soldat(); // generer un soldat
            s.Nom = nom;
            s.Puissance = 4;
            s.Defense = 3;
            s.nation = this; //la nation qui vient d'enroller la nation, qui est la sienne
            _armee.Add(nom, s); //key: le nom du soldat; value: une instance le l'instance de Soldat
            // pas de console.writelines dans nos classes car on ne pourra pas les utiliser dans unity (pas une console)
        }

        #endregion
    }
}
