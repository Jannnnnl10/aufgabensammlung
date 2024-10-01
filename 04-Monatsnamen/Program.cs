using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Monatsnamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forderung für eine Benutzereingabe + Benutzereingabe
            Console.Write("Zahl eingeben: ");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Ungültige Eingabe! Bitte eine Zahl zwischen 1 und 12 eingeben.");
            }
            else
            {
             
             // Array mit Monatsnamen
                string[] monate = { "Januar", "Februar", "März", "April", "Mai", "Juni",
                                "Juli", "August", "September", "Oktober", "November", "Dezember" };

             // Ausgabe des entsprechenden Monats
                Console.WriteLine("Monat: " + monate[month - 1]);             
            }
             Console.ReadKey();
        }
    }
}
