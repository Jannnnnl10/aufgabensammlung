using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _08_Binär_darstellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ganzzahlige Dezimalzahl (q to quit)");
            int zahl = 10;
            string bin = Convert.ToString(zahl, 2); // Konvertieren in binäre Darstellung
            Console.WriteLine("Die binäre Darstellung von " + zahl + " ist: " + bin);
            
            Console.WriteLine("Ganzzahlige Dezimalzahl (q to quit)"); 



            while (true)
            {
                // Warten auf Benutzereingabe
                var key = Console.ReadKey(true);

                // Überprüft, ob die Taste Q gedrückt wurde
                if (key.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Anwendung wird beendet..."); //Wenn Q gedrückt wurde wird dieser Text ausgegeben.
                    Thread.Sleep(2000); // Macht die Konsole für 2 Sekunden / 2000 Milisekunden stumm bevor sie dann durch die Q Taste beendet wird.
                    break; // Schleife verlassen und Anwendung beenden

                    Console.ReadKey();
                }
            }
        }
    }
}
