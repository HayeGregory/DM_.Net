using System;

namespace Exercice_06
{
    public struct Point
    {
        public int x, y;
    }

    public struct Celsius {
        public double Temperature;
    }
    public struct Fahrenheit {
        public int Temperature;
    }
    class Program
    {
        /*
         * ercercice 06 - page 172
         */


        static void Main(string[] args)
        {
            tabPoint();
            temperatureCelsiusFahrenheit();
        }

        #region Exercice 06 - 1 structure point x y
        /**
         * Ecrire une structure pour définir un point possédant deux entier X, Y et 
         * créer un tableau deux dimensions de 5 sur 5 de type « P oint » ( nullable )
         * et remplir une des diagonales, ensuite à l’aide de deux boucles à l’aide de deux boucles 
         * afficher les valeurs dans la console co mme suit :
         * « X : 1 Y : 1 »
         *              « X : 2 Y : 2 »
         *                              « X : 3 Y : 3 »
         * */
        public static void tabPoint() {

            Point?[,] tab = new Point?[5,5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Point p;
                    p.x = i+1;
                    p.y = j+1;

                    if (i == j ) tab[i,j] = p;
                }
            }

            int n = 0;
            foreach (Point ?p in tab)
            {
                Console.Write( p.HasValue ? $"x : {p.Value.x} - y : {p.Value.y}" : "\t\t");
                if (++n % tab.GetLength(0) == 0) Console.WriteLine();
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(tab[i,j].x == tab[i, j].y ? $"X : {tab[i, j].x} - Y : {tab[i, j].y}" : "\t\t");
            //    }
            //    Console.WriteLine();
            //}

        }

        #endregion

        #region Exercice 06 - 2 temperature
        /**
         * Ecrire deux structures Celsius et Fahrenheit toutes deux ayant une variable 
         * de type double appelée « Temperature ».
         * */
        public static void temperatureCelsiusFahrenheit() {
            Celsius tempCelsius;
            tempCelsius.Temperature = 10.2d;
            Fahrenheit tempFahrenheit;
            tempFahrenheit.Temperature = 10;
            return;
        }

        #endregion


    }
}
