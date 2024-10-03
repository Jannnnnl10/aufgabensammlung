using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Schaltjahr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
            Console.WriteLine("************************************************************");

            for (int i = 0; i <= 100000000; i++)
            {
                Console.Write("Eingabe Jahr (q to quit):");
                int Jahr = Convert.ToInt32(Console.ReadLine());
                string input = Console.ReadLine();

                if (input.ToLower() == "q" || input.ToLower() == "Q") // Q soll hier das Programm schliessen können
                {
                    break;
                }

                if (true) // Berechnen ob das Jahr 
                {
                    if (Jahr % 4 == 0 && Jahr % 400 == 0 && Jahr % 100 == 0)
                    {
                        Console.WriteLine($"Das {Jahr} ist ein Schaltjahr!");
                    }

                    if (Jahr % 4 == 0 )
                    {
                        if (Jahr % 100 != 0 && Jahr % 400 != 0)
                        {
                         Console.WriteLine($"Das {Jahr} ist ein Schaltjahr!");
                        }
                        if (Jahr % 100 == 0 && Jahr % 400 != 0)
                        {
                            Console.WriteLine($"Das {Jahr} ist KEIN Schaltjahr!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Das {Jahr} ist KEIN Schaltjahr!");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
