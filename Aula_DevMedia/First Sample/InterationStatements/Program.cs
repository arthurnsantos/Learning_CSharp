using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            do
            {
                Console.WriteLine("o valor de a eh: " + a);
                a++;

            } while(a<10);

            while(a > 0)
            {
                Console.WriteLine("o valor de a eh: " + a);
                a--;
            }

            Console.ReadKey();
        }
    }
}
