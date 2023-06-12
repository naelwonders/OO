namespace OO
{
    internal class Program
    {
        //TEST EXO 1 (sans les nations)
        //random number generator ("zuluter la rng" est un mot de gamer)
        public static Random RNG = new Random(); //fait partie de system donc pas besoin d'ajouter
        static void Main(string[] args)
        {
            Console.Clear();
            /*
                Soldat s1 = new Soldat();
                s1.Nom = "Valkyrie";
                s1.Puissance = 4;
                s1.Defense = 2;
                //on ajoute un s a soldat si on en a plusieurs avec une opération ternaire
                Console.WriteLine($"{s1.Nom} a {s1.NbUnite} soldate{((s1.NbUnite > 1) ? "s" : "")} et niveau {s1.Puissance} de puissance");

                Soldat s2 = new Soldat();
                s2.Nom = "Amazon";
                s2.Puissance = 5;
                s2.Defense = 1;
                Console.WriteLine($"{s2.Nom} a {s2.NbUnite} soldate{((s2.NbUnite > 1) ? "s" : "")} et niveau {s2.Puissance} de puissance");

                int random_result = RNG.Next(2); // max value entre les parentheses non inclue
                Soldat attaquant = s1;
                Soldat defenseur = s2;
                if (random_result == 1) attaquant = s2; defenseur = s1;

                while (s1.Vie > 0 && s2.Vie > 0) 
                {
                    Console.WriteLine($"{attaquant.Nom} attaque");
                    attaquant.Piew_piew(defenseur);
                    Console.WriteLine($"il nous reste {defenseur.NbUnite} soldat{((defenseur.NbUnite > 1) ? "s" : "")} dans le bataillon {defenseur.Nom}...;");

                    //inversion
                    Soldat temp = attaquant;
                    attaquant = defenseur;
                    defenseur = temp;
                }
                */

            //TEST EXO 2 (avec les nations)
            Nation rouge = new Nation();
            rouge.Nom = "rouge";
            rouge.Enroller("Charlie");
            rouge.Enroller("Delta");
            rouge.Enroller("Echo");

            Nation bleu = new Nation();
            bleu.Nom = "bleu";
            bleu.Enroller("Alpha");
            bleu.Enroller("Beta");
            bleu.Enroller("Omega");

            ; // je recupare

            int random_result = RNG.Next(2); // max value entre les parentheses non inclue
            Soldat attaquant = rouge["Charlie"];
            Soldat defenseur = rouge["Omega"];
            if (random_result == 1) attaquant = rouge["Omega"]; defenseur = rouge["Charlie"];

            while (attaquant.Vie > 0 && defenseur.Vie > 0)
            {
                Console.WriteLine($"{attaquant.Nom} de la nation {attaquant.nation.Nom} attaque");
                attaquant.Piew_piew(defenseur);
                Console.WriteLine($"il nous reste {defenseur.NbUnite} soldat{((defenseur.NbUnite > 1) ? "s" : "")} dans le bataillon {defenseur.Nom}...;");

                //inversion
                Soldat temp = attaquant;
                attaquant = defenseur;
                defenseur = temp;

            }
        }
    }
}