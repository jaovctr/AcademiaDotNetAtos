using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{
    internal class Carro
    {
        private double velocidadeMax;
        private string modelo;
        private string fabricante;
        private string cor;
        private string placa;
        private bool ligado = false;

        public void setVelocidadeMax(double velocidadeMax) {
            this.velocidadeMax = velocidadeMax;
        }
        public double getVelocidadeMax()
        {
            return velocidadeMax;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getModelo()
        {
            return modelo;
        }
        public void setFabricante(string fabricante)
        {
            this.fabricante = fabricante;
        }
        public string getFabricante()
        {
            return fabricante;
        }
        public string getCor()
        {
            return cor;
        }
        public void setCor(String cor)
        {
            this.cor = cor;
        }
        public void setPlaca(String placa)
        {
            this.placa = placa;
        }
        public string getPlaca()
        {
            return placa;
        }
        public bool getLigado()
        {
            return ligado;
        }
        public void ligar()
        {
            ligado = true;
            Console.WriteLine("O carro foi ligado!");
        }
        public void desligar()
        {
            ligado = false;
            Console.WriteLine("O carro foi desligado!");
        }
        public Carro()
        {

        }
        public Carro(string modelo, string fabricante, string cor, string placa, double velocidadeMax, bool ligado)
        {
            this.velocidadeMax = velocidadeMax;
            this.modelo = modelo;
            this.cor = cor;
            this.placa = placa;
            this.fabricante = fabricante;
            this.ligado = ligado;
        
        }
    }
}
