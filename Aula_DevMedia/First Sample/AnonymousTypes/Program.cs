using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
           //Nulable
            int? i = null;
            string s = null;

            var valores = new[] { new { idade = 18, nome = "Luis" }, new { idade = 20, nome = "Alberto" } };

            foreach (var item in valores)
            {
                Console.WriteLine("Nome: " + item.nome);
                Console.WriteLine("Nome: " + item.idade);
                Console.WriteLine("-------------------");
            }

            Console.ReadKey();
        }
    }
}
