using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{
    public class Cliente
    {
        private string nome;
        private int idade;
        
        public Cliente (string nome)
        {
            this.nome = nome;
        }
        public Cliente(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public string getNome()
        {
            return nome;
        }
        public int getIdade()
        {
            return idade;
        }
    }
}
