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
             string zahl = Console.ReadLine();
            Console.WriteLine("Zahl 2:");
             string ziffer = Console.ReadLine();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Zahl \t" + "|  Quersumme \t" + "|  Zahl / Quersumme");
            Console.WriteLine("------------------------------------------------");

            Console.ReadKey();


        }
    }
}
