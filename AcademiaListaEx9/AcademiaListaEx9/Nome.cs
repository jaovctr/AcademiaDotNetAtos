using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx9
{

    internal class Nome
    {
        string path = "nomes.csv";
        public List<string> nomes = new List<string>();


        public Nome() {
            PovoarLista(path);
        }

        private void AdicionarNaLista(string nome)
        {
            nomes.Add(nome);
        }

        public bool AdicionarNome(string nome)
        {
            if (NomeValido(nome) && !VerificaDuplicado(nome))
            {
                AdicionarNaLista(nome);
                Console.WriteLine("Nome Adicionado na lista!");
                AdicionarNoArquivo(nome);
                return true;
            }
            else if(VerificaDuplicado(nome))
            {
                Console.WriteLine("Nome já existe na lista");
            }
            else
            {
                Console.WriteLine("Formato de nome inválido!");
            }
            return false;
        }
        
        private static bool NomeValido(string nome)
        {
            if (nome == null)
                return false;
            if (nome == "")
                return false;
            string[] nomeVetor = nome.Split(" ");
            if (nomeVetor.Length < 2)
                return false;
            return true;
        }

        private bool VerificaDuplicado(string nome)
        {
            foreach (var n in nomes)
            {
                if (n.Equals(nome))
                    return true;
            }


            return false;                  
        }

        public void AdicionarNoArquivo(string nome)
        {
            StreamWriter sw = new StreamWriter(path,true);            
            sw.WriteLine(nome + ";");
            sw.Close();

            Console.WriteLine("Adicionado no arquivo!");
        }

        public void ListarNomes()
        {
            nomes.Sort();
            Console.WriteLine("Lista ordenada de nomes cadastrados:");
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
              
        private void PovoarLista(string path)
        {
            try
            {
                StreamReader rd = new StreamReader(path);
                string line = rd.ReadLine();
                while (line != null)
                {
                    AdicionarNaLista(line);

                    line = rd.ReadLine();
                }
                rd.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo de nomes não existente!");
                Console.WriteLine("Criando arquivo nomes.csv em " + AppContext.BaseDirectory);

            }
        }
    }
}
