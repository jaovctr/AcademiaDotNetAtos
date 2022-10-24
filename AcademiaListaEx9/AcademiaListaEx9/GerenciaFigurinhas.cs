using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaListaEx9
{

    internal class GerenciaFigurinhas
    {
        public List<Figurinha> repetidas = new List<Figurinha>();
        public List<Figurinha> faltantes = new List<Figurinha>();

        public GerenciaFigurinhas()
        {
            PovoaListas();
        }

        public void AdicionarFigurinha(bool repetida, Figurinha figurinha)
        {
            if (repetida)
            {
                repetidas.Add(figurinha);
                Console.WriteLine("Figurinha adicionada!");
                AdicionarNoArquivo(figurinha, false);
            }
            else
            {
                faltantes.Add(figurinha);
                AdicionarNoArquivo(figurinha, true);
                Console.WriteLine("Figurinha adicionada!");
            }
        }

        public void ExibirFigurinhas(bool repetida)
        {
            string path="";
            List<Figurinha> lista;
            if (repetida)
            {
                lista=repetidas;
                path = "repetidas.txt";
            }
            else
            {
                lista = faltantes;
                path = "faltantes.txt";
            }
            StreamWriter sw = new StreamWriter(path);
            foreach(Figurinha f in lista)
            {
                string line = "Codigo: " + f.Codigo_figurinha + ", Seleção: " + f.Selecao + ", Jogador: " + f.Nome_jogador;
                Console.WriteLine(line);
                sw.WriteLine(line);
            }
            sw.Close();
            Console.WriteLine("Arquivo "+path+" criado.");
        }

        private void AdicionarNoArquivo(Figurinha f, bool repetida) {
            string path = "faltantes.csv";
            if (repetida)
            {
                path = "repetidas.csv";            
            }
            StreamWriter sw = new StreamWriter(path, true);
            string figurinhaStr = f.Codigo_figurinha + ";" + f.Selecao + ";" + f.Nome_jogador;
            sw.WriteLine(figurinhaStr);
            sw.Close();
        }

        private void AdicionarNaLista(Figurinha figurinha, bool repetida)
        {
            if (repetida)
            {
                repetidas.Add(figurinha);
            }
            else{
                faltantes.Add(figurinha);
            }
        }

        private void PovoaListas()
        {
            //repetidas
            try
            {
                StreamReader rd = new StreamReader("repetidas.csv");
                string line = rd.ReadLine();
                while (line != null)
                {
                    string[] figurinhaStr = line.Split(",");
                    Figurinha figurinha = new Figurinha(figurinhaStr[0], figurinhaStr[1], figurinhaStr[2]);
                    AdicionarNaLista(figurinha,true);                  
                    line = rd.ReadLine();
                }
                rd.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo de figurinhas repetidas não encontrado, um novo arquivo será criado ao adicionar na lista!");
            }

            //faltantes
            try
            {
                StreamReader rd = new StreamReader("faltantes.csv");
                string line = rd.ReadLine();
                while (line != null)
                {
                    string[] figurinhaStr = line.Split(",");
                    Figurinha figurinha = new Figurinha(figurinhaStr[0], figurinhaStr[1], figurinhaStr[2]);
                    AdicionarNaLista(figurinha, false);
                    line = rd.ReadLine();
                }
                rd.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo de figurinhas faltantes não encontrado, um novo arquivo será criado ao adicionar na lista!");
            }
        }


    }
}
