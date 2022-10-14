using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{
    internal class Aluguel
    {
        private Cliente cliente;
        private Carro carro;
        private double valorAluguel;
        private double valorDiaria;
        private DateOnly dataAluguel;
        private int diarias;
        private DateOnly dataDevolucao;

        public Aluguel(Cliente cliente, Carro carro, double valorDiaria, DateOnly dataAluguel, int diarias)
        {
            this.cliente = cliente;
            this.carro = carro;
            this.valorDiaria = valorDiaria;
            this.valorAluguel = valorDiaria*diarias;
            this.dataAluguel = dataAluguel;
            this.diarias = diarias;
            this.dataDevolucao = dataAluguel;
            this.dataDevolucao=dataDevolucao.AddDays(diarias) ;
        }
        public string getCliente()
        {
            return cliente.getNome();
        }
        public string getCarro()
        {
            return carro.getModelo();
        }
        public double getValorDiaria()
        {
            return valorDiaria;
        }
        public double getValorAluguel()
        {
            return valorAluguel;
        }
        
        public DateOnly getDataAluguel()
        {
            return dataAluguel;
        }
        public double getDiarias()
        {
            return diarias;
        }

        public DateOnly getDataDevolucao()
        {
            return dataDevolucao;
        }
    }
}
