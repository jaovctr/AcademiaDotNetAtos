using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx8
{

        /*Crie uma classe para representar um item de cenário, com os atributos privados de:
         
         * Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
         * todos dados de um item de cenário. 
         * Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
         * a classe criada.*/
    internal class ItemCenario
    {
        private string descricao;
        private DateTime dataCriacao;
        private float altura;

        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime DataCriacao { get => dataCriacao; set => dataCriacao = value; }
        public float Altura { get => altura; set => altura = value; }

        public ItemCenario() { }

        public ItemCenario(string descricao, DateTime dataCriacao, float altura)
        {
            Descricao = descricao;
            DataCriacao = dataCriacao;
            Altura = altura;            
        }

        public void MostraItem()
        {
            Console.WriteLine(descricao+"\nData de criação: "+dataCriacao.Date+"\nAltura: "+altura);
        }

        public void TempoCriacao()
        {
            DateTime hoje = DateTime.Now.Date;
            DateTime idade = DateTime.MinValue + hoje.Subtract(DataCriacao);
            int anos = idade.Year-1;            
            int meses = idade.Month-1;           
            int dias = idade.Day-1;
            Console.WriteLine(anos+" anos, "+meses+" meses e "+dias+" dias");

        }

    }
}
