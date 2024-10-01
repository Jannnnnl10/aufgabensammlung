using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Durch_3_5_teilbar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwischen 1 und 30, die durch 3 und/oder 5 ohne Rest teilbar sind:");
            string ergebnis = "";

            // Schleife von 1 bis 30
            for (int i = 1; i <= 30; i++)
            {
                // Prüfen, ob die Zahl durch 3 oder 5 teilbar ist
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (ergebnis != "")
                    {
                        ergebnis += " , ";
                    }

                    ergebnis += i;


                }
            }      
                    // Ausgabe der Zahlen
                    Console.WriteLine(ergebnis);
                    Console.ReadKey();
        }
    }
}
