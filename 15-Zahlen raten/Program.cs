using System;
using System.Diagnostics.Eventing.Reader;
using static System.Net.Mime.MediaTypeNames;

namespace _15_Zahlen_raten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gameReset();
        }

        static void gameReset()
        {
            //Hier wird eine Random Zahl definiert
            Random rndNum = new Random();
            int RandomNum = rndNum.Next(1, 101); // Sie soll zwischen 1 und 100 sein
            int guessnumber = 0;
            int Try = 0;

            Console.WriteLine("Zahlen raten: ");


            while (guessnumber != RandomNum) // Diese Schleife wird so lange durchgeführt bis der User auf das richtige Ergebniss kommt, falls nicht wird sie immer wieder wiederholt
            {
                Console.Write("Gib eine Zahl zwischen 1 und 100 ein: ");
                Console.WriteLine(RandomNum);
                string user = Console.ReadLine();


                if (int.TryParse(user, out guessnumber))
                {
                    if (guessnumber != RandomNum)
                    {
                        Try++;
                    }

                    Console.WriteLine(); // Zeilenumbruch vor jedem Durchgang

                    // Falls die zahl zu gross ist sollte der Benutzer eine Mitteilung bekommen
                    if (guessnumber > RandomNum && guessnumber <= 100)
                    {
                        Console.WriteLine("Deine Zahl ist zu gross! Versuche es nochmals.");
                    }

                    // Falls die Zahl zu klein ist sollte der User eine Mitteilung bekommen
                    if (guessnumber < RandomNum)
                    {
                        Console.WriteLine("Deine Zahl ist zu klein! Versuche es nochmals.");
                    }

                    // Falls der Benutzer +- 10 an der Zahl dran ist sollte er diese Mitteilung bekommen
                    if ((RandomNum - 10 < guessnumber && guessnumber < RandomNum) ||
                       (RandomNum < guessnumber && guessnumber < RandomNum + 10))
                    {
                        Console.WriteLine("\n Dein Versuch war sehr knapp!");
                    }

                }
                if (guessnumber > 100)
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein."); // Im Falle einer ungültigen Zahl
                }
                else
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein.");
                }
                Console.WriteLine();



                if (guessnumber == RandomNum)
                {
                    // Wenn die Schleife endet, hat der Benutzer die random Number erraten
                    Console.WriteLine($"¨Die Zahl stimmt! Du hast total {Try} benötigt. Noch einmal spielen [ y/n ]");
                    string newGame = Console.ReadLine();

                    if (newGame.ToLower() == "y")
                    {
                        Console.WriteLine("New Game is starting...");
                        gameReset();
                    }
                    if (newGame.ToLower() == "n")
                    {
                        Console.WriteLine("Game ended! Program is closing...");
                        break;
                    }
                }
            }
        }
    }
}

