using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("o valor de i eh: " + (i+1));
            }

            Console.ReadKey();
        }
    }
}
