using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{
    internal class Livro
    {
        private int codigo;
        private string nome;
        private string autor;
        private string genero;
        private string editora;
        private int edicao;

        public Livro(int codigo, string nome, string autor, string genero, string editora, int edicao)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.autor = autor;
            this.genero = genero;
            this.editora = editora;
            this.edicao = edicao;
        }
        public void dadosLivros() 
        {
            Console.WriteLine("Codigo:"+codigo
                +"\nNome: "+nome
                +"\nAutor: "+autor
                +"\nGenero: "+genero
                +"\nEditora: "+editora
                +"\nEdição: "+edicao);
        }
    }
}
