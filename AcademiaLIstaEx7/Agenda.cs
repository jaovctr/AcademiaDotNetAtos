using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx7
{
    internal class Agenda
    {
        private List<Pessoa> agenda = new List<Pessoa>();

        public void armazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa contato = new Pessoa(nome, idade, altura);
            if (!agenda.Contains(contato)) {
                agenda.Add(contato);
                Console.WriteLine(nome + " adicionado!");
            }
            else
            {
                Console.WriteLine(nome+" já existe na agenda");
            }           
        }
        public void removePessoa(string nome)
        {
            foreach (Pessoa p in agenda)
            { 
                if (p.getNome().Equals(nome))
                {
                    agenda.Remove(p);
                    Console.WriteLine(nome+" removido!");
                    return;
                }
            }
            Console.WriteLine(nome + " não encontrado na agenda!");
        }
        public void buscaPessoa(string nome)
        {
            foreach(Pessoa p in agenda)
            {
                if (p.getNome().Equals(nome))
                {
                    Console.WriteLine("Contato: " + p.getNome() + ", idade: " + p.getIdade() + ", altura: " + p.getAltura());
                    return;
                }
            }
            Console.WriteLine(nome+" não encontrado na agenda!");
        }
        public void imprimeAgenda()
        {
            foreach (Pessoa p in agenda)
            {
                Console.WriteLine("Contato: "+p.getNome()+", idade: "+p.getIdade()+", altura: "+p.getAltura());
            }
            if (agenda.Count() == 0)
            {
                Console.WriteLine("Agenda vazia");
            }
        }
    }
}
