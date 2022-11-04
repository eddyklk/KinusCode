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

            
         
            List<int> data1 = new List<int> { 1, 2, 3, 4, 5 };
            List<string> data2 = new List<string> { "6", "3" };

            var newData = data1.Select(i => i.ToString()).Intersect(data2);

            Console.WriteLine(newData);

            Console.ReadKey();
        }
    }
}
