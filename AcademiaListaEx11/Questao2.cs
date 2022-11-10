using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaListaEx11
{
    public partial class Questao2 : Form
    {
        Emails listaEmail = new Emails();

        public Questao2()
        {
            InitializeComponent();
            ExibirDominios();
            ExibirEmails();
        }

        private void button_adicionarEmail_Click(object sender, EventArgs e)
        {
            AdicionarEmail();
            ExibirEmails();
            ExibirDominios();
        }

        private void AdicionarEmail()
        {
            listaEmail.AdicionarEmail(textBox_email.Text);
            textBox_email.Text = String.Empty;
        }

        private void textBox_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AdicionarEmail();
                ExibirEmails();
                ExibirDominios();
            }
        }

        private void ExibirEmails()
        {
            List<string> lista = listaEmail.ListaDeEmails();
            listView_email.Clear();
            foreach (string email in lista){
                listView_email.Items.Add(email);
            }
        }

        private void ExibirDominios()
        {
            List<string> lista = listaEmail.ListaDeDominios();
            listView_dominio.Clear();
            foreach(string email in lista)
            {
                listView_dominio.Items.Add(email);
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            listView_dominio.Clear();
            listView_email.Clear();
            listaEmail.ApagarLista();
        }
    }
}
