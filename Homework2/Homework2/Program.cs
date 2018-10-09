using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInt b1 = new BigInt("321");
            BigInt b2 = new BigInt("-999");

            var b = b2 + b1 - 99;
            Console.WriteLine(b.Value);
            Console.ReadKey();
        }
    }
}
