using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx8
{
    internal class Gerente : Funcionario
    {
        public Gerente()
        {

        }
       
        public Gerente(string nome, string departamento, double salario, string dataCadastro, string rg, bool ativo)
        {
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            DataCadastro = dataCadastro;
            Rg = rg;
            Ativo = ativo;
        }

        public override void ExecutaTrabalho()
        {
            Console.WriteLine("Gerencia o povo!");
        }
    }
}
