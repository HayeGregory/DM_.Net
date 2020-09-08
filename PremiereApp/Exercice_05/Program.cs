using System;
using System.Collections;

namespace Exercice_05
{
    class Program
    {
        /**
         * exercices de la page 164 
         * */
        static void Main(string[] args)
        {
            
            PremierOptiUnder();
            nbPremierOpti();
            // addnombreString();
        }
        #region Exercice 05 - 1
        /**
         * Grâce à une boucle « while » et à l’aide d’une collection, 
         * calculez les nombres premiers inférieur à un nombre entier entré au clavier.
         * */
        static void PremierOptiUnder()
        {
            int n = 2;
            bool is_np;
            ArrayList list = new ArrayList();

            Console.WriteLine(" nombre premiers inférieur à ? ");
            int.TryParse(Console.ReadLine(), out int x);
            for (int i = 0; n < x; n++)
            {
                is_np = true;

                foreach (int item in list)
                {
                    if (item > Math.Sqrt(n)) { break; }
                    if (n % item == 0)
                    {
                        is_np = false;
                        break;
                    }
                }

                if (is_np)
                {
                    list.Add(n);
                    i++;
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
        }
        #endregion
        #region Exercice 05 - 2
        /**
         * Grâce à une boucle « for » et à l’aide d’une collection générique, 
         * calculez les x premiers nombres premiers (version optimisée).
         * */
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
                    if (item > Math.Sqrt(n)) { break; }
                    if (n % item == 0)
                    {
                        is_np = false;
                        break;
                    }
                }

                if (is_np)
                {
                    list.Add(n);
                    i++;
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
        }
        #endregion
        #region Exercice 05 - 3
        /**
        * Demandez à l’utilisateur d’introduire deux nombres au clavier et faite l’addition de 
        * ces deux nombres en ne convertissant que ca ractère par caractère. 
        * (Méthode « ToCharArray » de la classe « string »).
        **/
        static void addnombreString()
        {
            Console.WriteLine("Nombre A : ");
            string nbA = Console.ReadLine();
            Console.WriteLine("Nomber B : ");
            string nbB = Console.ReadLine();

            Console.WriteLine(convertir(nbA) + " + " + conv(nbB) + " = " +
                (convertir(nbA) + conv(nbB)));

        }
        static int conv(string number) {
            Char[] num = number.ToCharArray();
            int n = 0;

            foreach (char c in num)
            {
                Console.WriteLine("C : " + c);
                n = (n * 10) + (c - 48);
            }
            return n;
        }
        static int convertir(string number)
        {
            int n = 0;
            for (int i = 0; i < number.Length; i++)
            {
                n = (n * 10) + (number[i] - 48);
            }
            return n;
        } 
        #endregion
    }
}
