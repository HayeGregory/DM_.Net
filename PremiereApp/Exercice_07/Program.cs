using System;

namespace Exercice_07
{
    public struct Celsius
    {
        public int Temperature;
        public double toFahrenheit() {
            return (Temperature * 1.8D + 32);
        }
    }
    public struct Fahrenheit
    {
        public double Temperature;
        public int toCelsius() {
            return (int)Math.Round((Temperature - 32) / 1.8D);
        }
    }

    public struct Equation2degre {
        public double A, B, C;
        public bool Resoudre(out double? X1, out double? X2) {
            X1 = X2 = null; // pour les valeur nullable ^^' reference de valeurs non initialisee

            Console.WriteLine("delta : " + delta());

            if (A == 0D || delta() < 0D) {
                return false;
            }

            X1 = ((-B - Math.Sqrt(delta() / (2 * A)))); // - B - math.sqrt(delta)
            X2 = ((-B + Math.Sqrt(delta() / (2 * A))));
            return true;
        }
        private double delta() {
            return (B * B) - (4 * A * C);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            convCelsiusFahrenheit();
            resoudreEquation();

        }

        #region convertisseur Celsieur - Fahrenheit
        /**
        * Dans les structures Celsius et Fahrenheit, écrire la fonction de conversion de l’une vers l’autre.
        * */
        public static void convCelsiusFahrenheit()
        {
            Celsius TC;
            Fahrenheit TF;

            TC.Temperature = 30;
            TF.Temperature = 86.00D;

            Console.WriteLine($"{TC.Temperature} °C => {TC.toFahrenheit()} °F");
            Console.WriteLine($"{TF.Temperature} °F => {TF.toCelsius()} °C");
        }
        #endregion

        #region Equation
        /*
         * Ecrire une structure pour résoudre une équation du second degré.
         * La structure devra contenir :
         *  Trois variables membres publiques A, B et C de type double.
         *  Une méthode publique « Resoudre » retournant une valeur de type « bool » 
         *   stipulant si une réponse a été trouvée et devra retourner également les
         *   valeurs de X1 et de X2 de type double.
         *  Si aucune solution n’a été trouvée, les valeurs de X1 et de X2 doivent être égale à « null ».
         */
        public static void resoudreEquation() {

            Equation2degre e = new Equation2degre();
            e.A = 1;
            e.B = 3;
            e.C = 2;

            Console.WriteLine($"{e.A} x² + {e.B} {e.C}");

            if (e.Resoudre(out double? X1, out double? X2))
            {
                Console.WriteLine($"x1 : {X1.Value} x2 :{X2.Value}");
            }
            else 
            {
                Console.WriteLine( "pas de resultat");
            }
        }
        #endregion
    }



}
