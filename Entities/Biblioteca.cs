using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca.Entities
{
    internal class Biblioteca
    {
        private Livro[] livros;
        private int contadorLivros;

        public Biblioteca(int tamanho)
        {
            livros = new Livro[tamanho];
            contadorLivros = 0;
        }

        public void AdicionarLivro(Livro livro) 
        {
            if(contadorLivros < livros.Length) 
            {
                livros[contadorLivros] = livro;
                contadorLivros++;
                Console.WriteLine("Livro Adicionado com Sucesso!!");
            } 
            else
            {
                Console.WriteLine("Biblioteca Cheia, Não é Possivel Adicionar mais Livros.");
            }
        }
  
        public void RegistrarEmprestimo(int codigo) 
        {
            for(int i = 0; i < livros.Length; i++)
            {
                if (livros[i].Codigo == codigo)
                {
                    Console.WriteLine($"Livro '{livros[i].Titulo}' emprestado com sucesso!");
                    return;
                }
            }
            Console.WriteLine("Livro Não Encontrado");
        }

        public void ListarLivros()
        {
            Console.WriteLine("Livros na Biblioteca:");
            for (int i = 0; i < contadorLivros; i++)
            {
                livros[i].ExibirInfo();
            }
        }
    }
}
