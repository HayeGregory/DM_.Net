using System;

namespace ExerciceSUPP
{
    class Program
    {
        static void Main(string[] args)
        {
            // bissextile();
            convertiseur();
        }

        #region Exercice Bonus 01
        /**
         * Exo bonus pour ceux qui ont fini : 
         * Réaliser un petit algorithme qui sur base d’une année donnée va déterminer s’il s’agit d’une année bissextile. 
         * Une année est bissextile si elle est divisible par 4, mais non divisible par 100. 
         * Ou si elle est divisible par 400. 
         */
        static void bissextile() {
            Console.WriteLine("entrez une année : ");
            int.TryParse(Console.ReadLine(), out int annee);

            Console.WriteLine($"{annee} est une année " + (estBissextile(annee) ? "bissextile" : "non bissextile"));

        }
        static bool estBissextile(int annee) {
            return (annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0;
        }

        #endregion

        #region Exercice Bonus 02
        /**
         * Réaliser un algorithme convertisseur de seconde. Ce dernier reçoit un nombre de secondes et 
         * détermine le nombre de jours, heures, minutes et secondes auquel elles correspondent.
         */
        static void convertiseur()
        {
            Console.WriteLine("entrez un nombre de secondes : ");
            int.TryParse(Console.ReadLine(), out int secondes);

            Console.WriteLine($"{convertisseurSeconde(secondes)}");

        }
        static string convertisseurSeconde(int secondes) {
            int jj, hh, mm, ss;

            jj = (int)secondes / 86400;
            hh = (int)secondes % 86400 / 3600;
            mm = (int)secondes % 86400 % 3600 / 60;
            ss = (int)secondes % 86400 % 3600 % 60;

            return $"{jj:D3}::{hh:D2}:{mm:D2}:{ss:D2}";
        }

        #endregion
    }
}
