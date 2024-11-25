using GerenciamentoBiblioteca.Entities;
using System;

namespace GerenciamentoBiblioteca // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca(100);
            int opcao;
            do {
                Console.WriteLine("------Biblioteca-----");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Registrar Empréstimo");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha Uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) 
                {
                    case 1:
                        Console.Write("Titulo do Livro: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor do Livro: ");
                        string autor = Console.ReadLine();
                        Console.Write("Codigo do Livro: ");
                        int codigo = int.Parse(Console.ReadLine());
                        
                        Livro novoLivro = new Livro(titulo,autor,codigo);
                        biblioteca.AdicionarLivro(novoLivro);
                        break;

                    case 2:

                        biblioteca.ListarLivros();
                        break;

                    case 3:
                        Console.Write("Codigo do Livro Para Emprestimo: ");
                        int codigoEmprestimo = int.Parse(Console.ReadLine());
                        biblioteca.RegistrarEmprestimo(codigoEmprestimo);
                        break;
                    case 4:
                        Console.WriteLine("Saindo do Sistema....");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
