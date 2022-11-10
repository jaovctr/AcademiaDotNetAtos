using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx11
{
    internal class Criptomoeda
    {
        private string nome;
        private string sigla;
        private double valor;

    
        public Criptomoeda(string nome, string sigla, double valor)
        {
            this.nome = nome;
            this.sigla = sigla;
            this.valor = valor;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public double Valor { get => valor; set => valor = value; }

        public bool IsNull()
        {
            if (nome == null || sigla == null || valor == 0)
                return true;
            return false;
        }
    }
}
