using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string Condicao;
            
            Console.WriteLine("Hello word");
            Console.WriteLine("How are you?");

            Condicao = Console.ReadLine();

            Console.WriteLine("Voce esta " + Condicao);
            
            Console.ReadKey();
        }
    }
}
