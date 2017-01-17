using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Aluno
    {
        //public Aluno()
        //{
        //    Console.WriteLine("aluno constructor");
        //}

        public Aluno(string _nome, int _idade)
        {
            this.nome = _nome;
            this.idade = _idade;
        }

        private string nome;
        private int idade;

        public string Nome
        {
            get;
            set;
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (idade != 0)
                {
                    idade = value;
                }
            }
        }

        public void Limpar()
        {
            this.idade = 0;
            this.nome = string.Empty;
                
        }

        public int getTwiceIdade()
        {
            int twice;
            twice = this.idade * 2;
            return twice;
        }

        ~Aluno()
        {
            Console.WriteLine("aluno destructor");
        }

    }
}
