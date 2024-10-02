using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Diagonale_Linie
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Zeichnen();
            Console.ReadKey();
        }

        static void Zeichnen()
        {
            for (int zeile = 1; zeile <= 6; zeile++)
            {
                for (int spalte = 1; spalte <= 6; spalte++)
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
