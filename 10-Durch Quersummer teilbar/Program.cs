using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Durch_Quersummer_teilbar
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Zahl 1:");
             string zahl1 = Console.ReadLine();
            Console.WriteLine("Zahl 2:");
             string zahl2 = Console.ReadLine();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Zahl \t" + "|  Quersumme \t" + "|  Zahl / Quersumme");
            Console.WriteLine("------------------------------------------------");

            if (int.TryParse(zahl1, out int start) && int.TryParse(zahl2, out int end))
            {
                for (int i = start; i <= end; i++)
                {
                    int quersumme = CalculateDigitSum(i);

                    if (i % quersumme == 0)
                    {
                        Console.WriteLine(i + " \t" + "| " + quersumme + "\t\t | " + i / quersumme);
                    }  
                }
            }
            else
            {
                Console.WriteLine("Fehler! Geben sie eine reguläre Zahl ein");
            }
            Console.ReadKey();
        }
        static int CalculateDigitSum(int zahl1)
        {
            int sum = 0;

            while (zahl1 > 0)
            {
                sum += zahl1 % 10;
                zahl1 /= 10;
            }

            return sum;     
        }
        
    }
}
