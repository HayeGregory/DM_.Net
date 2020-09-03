using System;

namespace Exercice_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Entrez un nombre : ");
            int.TryParse(Console.ReadLine(), out number);

            if (number / 2 + number / 2 == number) // if (number / 2 * 2 == number)
            {
                Console.WriteLine("Le nombre est pair");
            }
            else {
                Console.WriteLine("Le nombre est impair");
            }

            Console.WriteLine("le nombre est {0}", number/2*2 == number ? "pair" : "impair" );



        }
    }
}
