using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ForeachStatement
{
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public string autor;
            public int codigo;
            public int anoPublicacao;
        }
        static void Main(string[] args)
        {
            Livro l1 = new Livro();

            l1.autor = "Arthur";
            l1.titulo = "Minha Nada Mole Vida";
            l1.codigo = 182;
            l1.anoPublicacao = 1994;

            Livro l2;

            l2.autor = "Jessica";
            l2.titulo = "Como ser ZEN";
            l2.codigo = 55;
            l2.anoPublicacao = 1996;

            //ArrayList livros = new ArrayList();
            List<Livro> livros = new List<Livro>();

            livros.Add(l1);
            livros.Add(l2);
            int qtde = livros.Count();

            foreach (Livro item in livros)
            {
                Console.WriteLine("Livro Código: " + item.codigo);
                Console.WriteLine("Livro Autor: " + item.autor);
                Console.WriteLine("Livro Titulo: " + item.titulo);
                Console.WriteLine("Livro Ano Publicação: " + item.anoPublicacao);
                Console.WriteLine("----------------------------------------------");
            }

            Console.WriteLine("Quantidade de livros é: " + qtde);
            
            //outra forma 
            for (int i = 0; i < livros.Count; i++)
            {
                // pega o livro que for a "posição" i
                Livro l = livros.ElementAt(i);
            }

            Console.ReadKey();
        }
    }
}
