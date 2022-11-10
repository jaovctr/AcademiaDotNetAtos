using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx11
{
    
    internal class ListaDeNomes
    {
        private List<string> nomes = new List<string>();

        public ListaDeNomes() { }

        public void AdicionarNome(string nome)
        {
            nome = nome.ToUpper();

            if (VerificarNome(nome))
            {
                if (!nomes.Contains(nome))
                {
                    nomes.Add(nome);
                    MessageBox.Show("Nome adicionado!");
                }
                else
                {
                    MessageBox.Show("O nome já existe na lista!");
                }
            }
            else
            {
                MessageBox.Show("O nome não está completo!");
            }
        }
        
        private bool VerificarNome(string nome) {
            string[] nomeVetor = nome.Split(" ");
            if (nomeVetor.Length < 2)
                return false;
            else
                return true;
        }

        public List<string> RetornaNomes()
        {
            nomes.Sort();
            return nomes;
        } 
    }
}
