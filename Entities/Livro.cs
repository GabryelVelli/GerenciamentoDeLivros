using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca.Entities
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public int Codigo { get; set; }

        public Livro() { }

        public Livro(string titulo, string autor, int codigo)
        {
            Titulo = titulo;
            Autor = autor;
            Codigo = codigo;
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Codigo: " + Codigo); 
        }
    }
}
