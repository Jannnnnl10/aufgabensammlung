using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabe11test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lange soll die Linie sein?");
            Console.WriteLine("Deine Eingabe");
            int userEingabe = Convert.ToInt32(Console.ReadLine());
            ZeichnenDiago(userEingabe);
            Console.ReadKey();
        }
        static void ZeichnenDiago(int userAusgabe)
        {
            for (int zeile = 1; zeile <= userAusgabe; zeile++)
            {
                for (int spalte = 1; spalte <= userAusgabe; spalte++)
                {
                    if (zeile == spalte)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
