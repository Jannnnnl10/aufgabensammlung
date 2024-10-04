using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_Tannenbaum_zeichnen
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Breite des Stammes?");
            int breiteStamm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Höhe des Stammes?");
            int höheStamm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie hoch soll die Krone sein?");
            int höheKrone = Convert.ToInt32(Console.ReadLine());


            zeichneKrone(höheKrone);
            zeichneStamm(breiteStamm, höheStamm, höheKrone);
            Console.ReadKey();
        }


        static void zeichneBaum(int höheStamm, int höheKrone, int breiteStamm)
        {
            Console.ReadKey();
        }


        static void zeichneStamm(int breiteStamm, int höheStamm, int höheKrone)
        {
            for (int i = 0; i < höheStamm; i++)
            {
                zeichneForm((höheKrone - 1) - (breiteStamm / 2), breiteStamm);
            }
        }


        static void zeichneKrone(int höheKrone)
        {
            int anzahlStars = 1;
            int space = höheKrone - 1;

            for (int i = 0; i < höheKrone; i++)
            {
                zeichneForm(space,anzahlStars);

                anzahlStars += 2;
                space-=1;
            }

        }


        static void zeichneForm(int anzahlSpace, int anzahlStars)
       {

            for (int i = 1; i <= anzahlSpace; i++)
            {
                Console.Write(' ');

            }
            for (int i = 1; i <= anzahlStars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }





    }
}
