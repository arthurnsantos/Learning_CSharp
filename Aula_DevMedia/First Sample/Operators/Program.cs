using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("soma: " + (a + b));
            Console.WriteLine("subtração: " + (a - b));
            Console.WriteLine("multiplicação: " + (a * b));
            Console.WriteLine("divisão: " + (a / b));

            Console.ReadKey();

        }
    }
}
