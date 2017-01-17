using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "one";
            string s2 = "one,two,three";

            s1 += ",two";
            s1 += ",three";

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("one");
            sb.Append(",two");
            sb.Append(",three");

            s1.EndsWith("ree");
            s1.Equals("xxxx");
            s1.IndexOf("three"); // tras o index onde se encontra esse valor
            string[] s4 = s1.Split(','); // separa a string considerando o delimitador e insere na array com index

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}
