using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{


   /* 7 - Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio. 
    * A classe deve armazenar o andar atual (térreo = 0), total de andares no prédio (desconsiderando o térreo), 
    * capacidade do elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos:
    * Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio 
    * (os elevadores sempre começam no térreo e vazio);
    * Entra : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);
    * Sai : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);
    * Sobe : para subir um andar (não deve subir se já estiver no último andar);
    * Desce : para descer um andar (não deve descer se já estiver no térreo);
    * Encapsular todos os atributos da classe (criar os métodos set e get).*/
    internal class Elevador
    {
        private int andar;
        private int totalAndares;
        private int capacidade;
        private int lotacao;
       
        public int Andar { get => andar; set => andar = value; }
        public int TotalAndares { get => totalAndares; set => totalAndares = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }
        public int Lotacao { get => lotacao; set => lotacao = value; }

        public void Inicializa(int capacidade, int totalAndares)
        {
            Andar = 0;
            TotalAndares = totalAndares;
            Capacidade = capacidade;
            Lotacao = 0;
        }

        public void Entra()
        {
            if (Lotacao < Capacidade)
            {
                Lotacao++;
                Console.WriteLine("Alguém entrou no elevador");
            }
            else
                Console.WriteLine("Lotado");
        }

        public void Sai()
        {
            if (Lotacao > 0)
            {
                Lotacao--;
                Console.WriteLine("Alguém saiu do elevador");
            }
            else
                Console.WriteLine("Elevador já está vazio!");
        }

        public void Sobe() 
        {
            if (Andar < TotalAndares)
            {
                Andar++;
                Console.WriteLine("Subiu um andar");
            }
            else
            {
                Console.WriteLine("Já está na cobertura");
            }
        }

        public void Desce() 
        {
            if (Andar > 0)
            {
                Andar--;
                Console.WriteLine("Desceu um andar");
            }
            else
            {
                Console.WriteLine("Já está no térreo");
            }
        }
    }
}
