using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx8
{
    internal class Personagem
    {
        private string nome;
        private double poder;

        public string Nome { get => nome; set => nome = value; }
        public double Poder { get => poder; set => poder = value; }

        public Personagem()
        {

        }
        public Personagem(string nome, double poder)
        {
            Nome = nome;
            Poder = poder;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: "+Nome+", Nível de poder: "+Poder);
        }
    }
}
