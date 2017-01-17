using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a == 5)
            {
                Console.WriteLine("eh igual");
            }else
            {
                Console.WriteLine("nao eh igual");
            }

            //tambem serve para if - se (condicao) ? valor_verdadeiro : valor_falso;
            int b = (a < 10) ? 5 : 0;

            bool ok = true;

            if (ok)
            {
                Console.WriteLine("OK");
            }

            int c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 0:
                    Console.WriteLine("c == 0");
                    break;
                case 5:
                    Console.WriteLine("c == 5");
                    break;
                case 10:
                    Console.WriteLine("c == 10");
                    break;
                default:
                    Console.WriteLine("c ==" + c.ToString());
                    break;
            }



            Console.ReadKey();
        }
    }
}
