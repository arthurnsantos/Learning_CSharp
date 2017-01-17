using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a1 = new int[3];

            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;

            Console.WriteLine(a1[0]);
            Console.WriteLine(a1[1]);
            Console.WriteLine(a1[2]);

            int[] a2 = new int[] { 40, 50, 60 };

            string[] a3 = { "one", "two", "three" };

            Console.WriteLine(a3.Length);

            //Multidimensional Array

            int[,] ma1 = new int[3, 3];
            ma1[0, 0] = 10;

            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("ok");
            al.Add(true);

            Console.WriteLine(al[1]);

            List<int> l1 = new List<int>();

            l1.Add(20);
            l1.Add(35);
            l1.Add(7);


            Console.ReadKey();
        }
    }
}
