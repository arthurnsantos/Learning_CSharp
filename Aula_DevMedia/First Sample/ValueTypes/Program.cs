using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        enum acessorio {Sapato, Bolsa, Cinto, Carteira, Colar}

        static void Main(string[] args)
        {
            int i = 10;
            string a = "OK";
            char c = 'X';
            float f = 10.89F;
            double d = 90.9876;
            decimal dec = 10.88M;
            bool b = true;

            int item = (int)acessorio.Colar;

            //implicit conversion

            int i1 = 10;
            long i2 = i1;

            //explicit conversion
            double d1 = 10.9;
            int d2 = (int)d1;

            //int.TryParse(
            //int.Parse()
            //Convert.ToInt32()

            Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
