using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SagHallo("Mond", "Sonne");

            Console.ReadKey();
        }

        static void SagHallo(string wem,int wieOft)
        {
            for (int i = 0; i < wieOft; i++)
            {
                Console.WriteLine("Hallo " + wem);
            }
        }

        static void SagHallo(string wem, string wemNoch)
        {

           Console.WriteLine("Hallo " + wem + " und " + wemNoch) ;
        }



    }
}
