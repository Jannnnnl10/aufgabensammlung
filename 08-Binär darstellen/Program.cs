using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _08_Binär_darstellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "";

            while (inputString.ToLower() != "q")// Q soll der Buchstabe sein der das Programm beendet
            {
                string bin = "";

                Console.WriteLine("Ganzzahlige Dezimalzahl (Q to Quit):");
                inputString = Console.ReadLine();

                if (inputString.ToLower() == "q")
                {
                    Console.WriteLine("Programm wurde erfolgreich beendet.");
                    break;
                }

                if (int.TryParse(inputString, out int input)) //Hier wird überprüft, ob die Benutzereingabe in einen INT umgewandelt werden kann. Kann wie ein Boolean nur true oder false sein
                {
                    do
                    {
                        int rest = input % 2;
                        bin = rest + bin;
                        input /= 2;
                    }
                    while (input != 0);
                    Console.WriteLine(bin);
                }
                else
                {
                    Console.WriteLine("Fehler!!! Bitte gib eine Ganzzahl ein.");
                }
            }
        }
    }
}

          
        
    
