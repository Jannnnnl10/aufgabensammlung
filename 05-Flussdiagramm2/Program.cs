using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Flussdiagramm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen? ");
            int distance = Convert.ToInt32(Console.ReadLine());


            if (distance > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
                Console.ReadKey();  
            }
            else
            {
                int round = 400;
                float rounds = (float)distance * 1000 / round;
                Console.WriteLine("Runden:" + rounds);

                Console.WriteLine("Bist du bereit?: ");
                char ready = Convert.ToChar(Console.ReadLine());
                Console.ReadKey();

                if (ready == 'J' || ready == 'j')
                {
                    for (int j = 0; j <= rounds;)
                    {
                        Console.WriteLine($"Du laufst runde {j}");
                    }
                    Console.WriteLine("Du hast es geschafft");
                }

                else
                {
                    Console.ReadKey();
                }

                    if (ready == 'n' || ready == 'N')
                    {
                      Console.WriteLine("Ende");
                    }

                Console.ReadKey();
                }
                }
            }
        }
