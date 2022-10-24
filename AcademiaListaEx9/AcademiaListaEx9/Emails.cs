using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AcademiaListaEx9
{
    internal class Emails
    {
        private static string path = "emails.csv";
        
        public List<string> listaEmails = new List<string>();
        public List<string> dominio = new List<string>();


        public Emails()
        {
            PovoarLista(path);
        }

        public void AdicionarEmail(string email)
        {

            if (listaEmails.Contains(email))
            {
                Console.WriteLine("O email já está cadastrado na lista!");
            }else if(!ValidaEmail(email))
            {
                Console.WriteLine("Formato inválido");
            }
            else
            {
                AdicionarLista(email);
                AdicionarNoArquivo(email+";");
                AdicionarDominio(email);
                Console.WriteLine(email +" inserido na lista!");
            }
        }
        private bool ValidaEmail(string email)
        {
            if (email == null)
            {
                return false;
            }
            if (email == "")
            {
                return false;
            }
            string[] vetorEmail=email.Split('@');
            if (vetorEmail.Length < 2)
            {
                return false;
            }
            return true;
        }

        private void AdicionarLista(string email)
        {
            if(!listaEmails.Contains(email))
                listaEmails.Add(email);
        }
        private void AdicionarDominio(string email)
        {
            string[] dom = email.Split("@");
            
            if (!dominio.Contains(dom[1]))
            {
                dominio.Add(dom[1]);
            }
        }
        public void ListarEmails()
        {
            Console.WriteLine("Emails cadastrados: ");
            foreach (var e in listaEmails)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Domínios: ");
            foreach(var d in dominio)
            {
                Console.WriteLine(d);
            }
        }

        private static void AdicionarNoArquivo(string email)
        {
            StreamWriter sw = new StreamWriter(path,true);
            sw.WriteLine(email);
            Console.WriteLine("Adicionado ao arquivo!");
            sw.Close();
            
        }

        private void PovoarLista(string path)
        {
            try
            {
                StreamReader rd = new StreamReader(path);
                string line = rd.ReadLine();
                while (line != null)
                {
                    AdicionarLista(line);
                    AdicionarDominio(line);

                    line = rd.ReadLine();
                }
                rd.Close();

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo De Emails não existente!");
                Console.WriteLine("Criando arquivo emails.csv em "+AppContext.BaseDirectory);
                
            }
        }
    }
}
