using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Pedro",30);
            Aluno a2 = new Aluno("Paulo", 40);
            Aluno a3 = new Aluno("Thiago", 50);
            Aluno a4 = new Aluno("Matheus", 20);
            Aluno a5 = new Aluno("Tadeu", 10);

            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(a1);
            alunos.Add(a2);
            alunos.Add(a3);
            alunos.Add(a4);
            alunos.Add(a5);


            foreach (var item in alunos)
            {
                Console.WriteLine("nome: " + item.Nome + " Idade: " + item.Idade + " dobro da idade: " + item.getTwiceIdade());
                Console.WriteLine("-----------------------------");
            }
           

            Console.ReadKey();
        }
    }
}
