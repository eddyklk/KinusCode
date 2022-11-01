using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Probar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            List<int> lista2 = new List<int> {1,2,3,4,5,6,7,8,9,1,0};
            Random rand = new Random();

            var listaDistinct = lista2.Distinct();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Numero que son unicos: ");
            foreach (int num in listaDistinct)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(num + ",");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 6 # de los sobrantes: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int ctr = 0; ctr <= 9; ctr++)
           
            Console.Write("{0,3}", rand.Next(81));
            Console.WriteLine();

          

         


            Console.ReadKey();
        }
    }
}
