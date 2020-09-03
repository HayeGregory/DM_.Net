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
            const int SECONDES_JOUR = 86_400;
            const int SECONDES_HEURE = 3_600;
            const int SECONDES_MINUTE = 60;

            int jj, hh, mm, ss;


            jj = secondes / SECONDES_JOUR;
            secondes = secondes % SECONDES_JOUR;
            hh = secondes / SECONDES_HEURE;
            secondes = secondes % SECONDES_HEURE;
            mm = secondes / SECONDES_MINUTE;
            ss = secondes % SECONDES_MINUTE;

            return $"{jj:D3}::{hh:D2}:{mm:D2}:{ss:D2}";
        }

        #endregion
    }
}
