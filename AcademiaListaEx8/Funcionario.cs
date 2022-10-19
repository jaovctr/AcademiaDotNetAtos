using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx8
{
         /*        
         * Haverá duas implementações da classe Funcionario chamada de Gerente e Operador. 
         * Nos metodos de cada uma das classes Gerente e Operador deverá aparecer a mensagem informando qual é a função desempenhada pelo funcionário*/
    internal abstract class Funcionario
    {
        private string nome;
        private string departamento;
        private double salario;
        private string dataCadastro;
        private string rg;
        private bool ativo;

        public string Nome { get => nome; set => nome = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public double Salario { get => salario; set => salario = value; }
        public string DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public string Rg { get => rg; set => rg = value; }
        public bool Ativo { get => ativo; set => ativo = value; }


        public void Bonifica(double bonificacao)
        {
            Salario+=bonificacao;
        }
        public void Demite()
        {
            Ativo = false;
        }

        public abstract void ExecutaTrabalho();
    }
}
