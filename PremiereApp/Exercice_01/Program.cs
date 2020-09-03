using System;

namespace Exercice_01
{
    public enum OpenDays { lundi, mardi, mercredi, jeudi, vendredi }
    public enum Days
    {
        None        = 0b_0000_0000,  // 0
        Monday      = 0b_0000_0001,  // 1
        Tuesday     = 0b_0000_0010,  // 2
        Wednesday   = 0b_0000_0100,  // 4
        Thursday    = 0b_0000_1000,  // 8
        Friday      = 0b_0001_0000,  // 16
        Saturday    = 0b_0010_0000,  // 32
        Sunday      = 0b_0100_0000,  // 64
        Weekend     = Saturday | Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Exo01 - int.parse
            int number_A, number_B;

            Console.WriteLine("Premier nombre : ");
            int.TryParse(Console.ReadLine(), out number_A);

            Console.WriteLine("Deuxième nombre : ");
            int.TryParse(Console.ReadLine(), out number_B);

            Console.WriteLine($"{number_A} + {number_B} = {number_A + number_B}"); 
            #endregion

            Console.WriteLine("-----------------------------------------------------");

            #region Exo01 - int.tryParse
            Console.WriteLine("Premier nombre : ");
            number_A = int.Parse(Console.ReadLine());

            Console.WriteLine("Deuxième nombre : ");
            number_B = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number_A} + {number_B} = {number_A + number_B}"); 
            #endregion

        }

        static void ex01_completed() {
            int number_A, number_B;

            Console.WriteLine("Premier nombre : ");
            if (!int.TryParse(Console.ReadLine(), out number_A))
            {
                Console.WriteLine("le nombre sera mis à la valeur par defaut (0)");
            }

            Console.WriteLine("Deuxième nombre : ");
            if (!int.TryParse(Console.ReadLine(), out number_B))
            {
                Console.WriteLine("le nombre sera mis à la valeur par defaut (0)");
            }

            Console.WriteLine($"{number_A} + {number_B} = {number_A + number_B}");

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Premier nombre : ");
            try
            {
                number_A = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException --> la valeur par defaut sera mise");
                number_A = 0;
            }
            Console.WriteLine("Deuxième nombre : ");
            try
            {
                number_B = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException --> la valeur par defaut sera mise");
                number_B = 0;
            }
            Console.WriteLine($"{number_A} + {number_B} = {number_A + number_B}");
        }

        static void test() {
            Days day = Days.Monday;

            // switch + tab,tab , var , ->

            switch (day)
            {
                case Days.None:
                    break;
                case Days.Monday:
                    break;
                case Days.Tuesday:
                    break;
                case Days.Wednesday:
                    break;
                case Days.Thursday:
                    break;
                case Days.Friday:
                    break;
                case Days.Saturday:
                    break;
                case Days.Sunday:
                    break;
                case Days.Weekend:
                    break;
                default:
                    break;
            }



        }
    }
}
