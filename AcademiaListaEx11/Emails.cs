using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AcademiaListaEx11
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
                MessageBox.Show("O email já está cadastrado na lista!");
            }else if(!ValidaEmail(email))
            {
                MessageBox.Show("Formato inválido");
            }
            else
            {
                AdicionarLista(email);
                AdicionarNoArquivo(email+";");
                AdicionarDominio(email);
                MessageBox.Show(email +" inserido na lista!");
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

        public List<string> ListaDeEmails()
        {
            return listaEmails;
        }
        public List<string> ListaDeDominios()
        {
            return dominio;
        }
        public string ListarEmails()
        {
            string emails = "";
            foreach (var e in listaEmails)
            {
                emails += e + "/n";
            }
            return emails;
        }

        public string ListarDominios()
        {
            string dominios = "";
            foreach(string d in dominio){
                dominios += d + "/n";
            }
            return dominios;
        }

        private static void AdicionarNoArquivo(string email)
        {
            StreamWriter sw = new StreamWriter(path,true);
            sw.WriteLine(email);
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
                MessageBox.Show("Arquivo De Emails não existente!\n"
                    + "Criando arquivo emails.csv em " + AppContext.BaseDirectory);             
            }
        }

        public void ApagarLista()
        {
            listaEmails = null;
            dominio = null;
            File.Delete(path);
            MessageBox.Show("Lista deletada");

        }
    }
}
