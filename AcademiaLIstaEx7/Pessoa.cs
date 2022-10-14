using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private string genero;
        private string cpf;
        private Pessoa pai;
        private Pessoa mae;

        //Questão 7
        float altura;

        public Pessoa(string nome,int idade, string genero, string cpf)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
            this.cpf = cpf;
        }
       
        //Questão 7
        public Pessoa(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }
        
        public void apresentaPessoa()
        {
            Console.WriteLine("Nome: "+nome
                +"\nIdade: "+idade
                +"\nGenero: "+genero
                +"\nCPF: "+cpf);
        }
        public String getNome()
        {
            return nome;
        }
        public int getIdade()
        {
            return idade;
        }
        public string getGenero()
        {
            return genero;
        }
        public string getCpf()
        {
            return cpf;
        }

        public void setPai(Pessoa pai)
        {
            this.pai = pai;
        }
        public Pessoa getPai()
        {
            return pai;
        }
        public void setMae(Pessoa mae)
        {
            this.mae = mae;
        }
        
        public Pessoa getMae()
        {
            return mae; 
        }

        public String arvore()
        {
            return this.pai.getNome() + ", " + this.mae.getNome();
        }

        public void setAltura(float altura)
        {
            this.altura = altura;
        }
        public float getAltura()
        {
            return altura;
        }
    }
}
