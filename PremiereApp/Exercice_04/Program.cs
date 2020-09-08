using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Exercice_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //  fibbo(25);
            //  facto();
            //  nbPremier();
            // nbPremierOpti();
            // multi20();
            //  additionDouble();
              racine2();
        }

        #region ex3A
        /**
         *  1. Calculer les 25 premiers nombres de la suite de Fibonacci
         */
        static void fibbo(int n) {
            int nbA, nbB, nbC;
            nbA = 0;
            nbB = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nbA);
                nbC = nbA + nbB;
                nbA = nbB;
                nbB = nbC;
            }
        }
        #endregion
        #region ex3B
        /**
         *  2. Calculer le factoriel d’un nombre entré au clavier.
         */
        static void facto() {
            int n = 0, result = 1;

            do
            {
                Console.WriteLine("factorielle de  : ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            if (n < 0)
                Console.WriteLine("factorielle negative - erreur");
            else
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
            Console.WriteLine(result);
        }
        #endregion
        #region ex3C
        /**
         *  3. Grâce à une boucle « for », calculez les x premiers nombre premier.
         */
        static void nbPremier() {
            int n = 2 ;
            bool is_np;
            Console.WriteLine(" nombre premiers ? ");
            int.TryParse(Console.ReadLine(), out int x);
            for (int i = 0; i < x; n++)
            {
                is_np = true;
                for (int d = 2; d < n; d++)
                {
                    if (n % d == 0)
                    {
                        is_np = false;
                        break;
                    }
                }
                if (is_np)
                {
                    Console.WriteLine(n + " ");
                    i++;
                }
            }
        }

        static void nbPremierOpti()
        {
            int n = 2;
            bool is_np;
            ArrayList list = new ArrayList();

            Console.WriteLine(" nombre premiers ? ");
            int.TryParse(Console.ReadLine(), out int x);
            for (int i = 0; i < x; n++)
            {
                is_np = true;

                foreach (int item in list)
                {
                    Console.WriteLine("pour " + n + " - test de diviseur : " + item);
                    if (item > Math.Sqrt(n)) { break; }
                    if (n % item == 0) {
                        is_np = false;
                        break;
                    }
                }

                if (is_np)
                {
                    list.Add(n);
                    Console.WriteLine("j'ajoute " + n + " a ma liste ");
                    i++;
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
        }


        #endregion
        #region ex3D
        /**
         *  4. A l’aide de boucles « for » afficher les 5 premières tables de multiplication en allant jusque « x20 ».
         *  1x1 = 1 ; 2x1 = 2 ; ……
         *  2x1 = 2 ; 2x2 = 4 ; ……
         */
        static void multi20() {
            Console.WriteLine("\ntable de multiplication : ");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    Console.Write( $"{i}x{j} = {i * j} ; ");
                }
                Console.WriteLine();
            }
        }
        #endregion
        #region ex3E
        /**
         *  5. À l’aide d’une boucle « for » comptez de 0, à 20,0 en augmentant de 0,1, en utilisant des doubles, 
         *  et afficher la valeur à chaque itération.
         *  Remarquez vous quelque chose de particulier ?
         */
        
        static void additionDouble() {
            for (double i = 0; i <= 20; i += 0.1)
            {
                Console.WriteLine(i);
            }
            for (decimal i = 0; i <= 20; i += 0.1M)
            {
                Console.WriteLine(i);
            }
        }
        #endregion
        #region ex3F
        /**
         *  6. Bonus : Calculer la racine carré d’un nombre avec maximum 10 décimales
         *  (Math.Sqrt (x) ne peut être utilisée que pour vérifier la reponse)
         */
        static void racine2() {

            Console.WriteLine("entrez un nombre : ");
            int.TryParse(Console.ReadLine(), out int nb);

            decimal fa, a = 1, e = 1;

            while (e > 0.00000000001M) {
                fa = (a + nb / a) / 2;
                if (fa > a)
                {
                    e = fa - a;
                }
                else {
                    e = a - fa;
                }
                a = fa;
            }

            Console.WriteLine("racine2 carre : " + Math.Round(a,10));
            Console.WriteLine("solution (sqrt ) : " + Math.Sqrt(nb));

        }
        static void racine2correction()
        {

            Console.WriteLine("entrez un nombre : ");
            int.TryParse(Console.ReadLine(), out int nb);



            Console.WriteLine("racine2 carre : " );
            Console.WriteLine("solution (sqrt ) : " + Math.Round(Math.Sqrt(nb),10));

        }

        #endregion





    }
}
