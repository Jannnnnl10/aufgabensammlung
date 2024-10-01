using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SekundenMonat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnng von Sekunden eines Monats in Abhängigkeit seiner Anzahl Tage");
            Console.WriteLine("----------------------------------------------------------------------");
           
            //Eingabe des Benutzers
            Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
            byte tageszahl = Convert.ToByte(Console.ReadLine());

            switch(tageszahl)
            {
                case 28:
                case 29:
                case 30:
                case 31:
                    Console.WriteLine("Ein Monat mit " + tageszahl + " Tagen hat " + (86400 * tageszahl) + " Sekunden.");
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe." + " Ein Monat mit "+ tageszahl + " Tagen gibts nicht." );
                   break;
            }
             Console.ReadKey();
            }
              
              
        }
    }
