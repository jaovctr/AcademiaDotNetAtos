using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx8
{
   
    internal class Animal
    {
        private String[] tipoAnimal = { "cachorro", "gato", "peixe" };
        private string tipo;
        private string nome;
        private int idade;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string[] TipoAnimal { get => tipoAnimal;}

        public Animal() { }

        public Animal( string tipo, string nome, int idade)
        {            
            Tipo = tipo;
            Nome = nome;
            Idade = idade;
        }
    }
}
