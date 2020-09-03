using System;
using System.Globalization;

namespace Exercice_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // division();
            Console.WriteLine("Entrez un numero de compte ( BBAN ) : ");
            string BBAN = Console.ReadLine();
            string IBAN = makeIBAN( checkBBAN(BBAN) ? BBAN : "" ); // 377052488656 - 979797979700 - 979797979797 - 732038207644
            Console.WriteLine($"Numero IBAN : {IBAN}");
        }

        #region Exercice 03-A
        /**
         * Calcule de la division entière, du modulo et de la division de deux entiers.
         * Résultat attendu pour 5 et 2  Division entière : 2, Modulo : 1, Division : 2,5. 
         **/
        static void division()
        {
            Console.WriteLine("Opérande A :");
            int.TryParse(Console.ReadLine(), out int A);
            Console.WriteLine("Opérande B :");
            int.TryParse(Console.ReadLine(), out int B);

            Console.WriteLine($"Division entière : {A / B}, Modulo : {A % B}, Division : {((double)A / B).ToString(new CultureInfo("en-US"))}");

        }
        #endregion

        #region Exercice 03-B
        /**
         * Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.
         * Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97.
         * (utilisez la méthode « Substring » de la classe « string »).
         **/
        static bool checkBBAN(string number) {
            if (number.Length != 12) { // out _ ?????????????
                Console.WriteLine("Le numero ne contient pas 12 digits");
                return false;
            }
            
            long.TryParse(number.Substring(0, 10), out long partA);
            long.TryParse(number.Substring(10, 2), out long partB);
            Console.WriteLine($"{partA:D10}-{partB:D2}");

            if (partA % 97 == 0 && partB != 97) {
                Console.WriteLine("Numero non valide - cas : 00");
                return false;
            }
            if (partA % 97 != 0 && partA % 97 != partB) {
                Console.WriteLine("Numero non valide - cas : 97");
                return false;
            }
            Console.WriteLine("numero valide");
            return true;
        }

        #endregion

        #region Exercice 03-C
        /**
         * Transformer un compte bancaire BBAN Belge (xxx xxxxxxx xx) en IBAN ( BExx xxxx xxxx xxxx ). 
         * Trouvez la démarche via un moteur de recherche.
         **/
        static string makeIBAN(string bban) {
            const string CODE_BE = "111400";

            if (bban.Length == 0) return "Le BBAN n'est pas valide";
            long keyIBAN = 98 - (long.Parse(bban + CODE_BE) % 97);
            
            return $"BE{keyIBAN:D2}{bban}";
        }

        #endregion
    }
}
