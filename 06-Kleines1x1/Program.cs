using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Kleines1x1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Kleines 1x1"); // Dekoration 
            Console.WriteLine("-----------");

            for (int i = 1; i <= 10; i++)  // Äußere Schleife 
            {
                for (int j = 1; j <= 10; j++)// Inernere Schleife
                {
                    Console.Write(i * j + "\t");// Sorgt für den Zeilenabstand
                }
                Console.WriteLine();// Macht nach jeder Zeile eine neue Spalte
            }

            Console.ReadKey();
            }
        }
    }
