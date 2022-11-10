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
    public partial class Questao1 : Form
    {
        public Questao1()
        {
            InitializeComponent();
        }

        ListaDeNomes lista = new ListaDeNomes();

        private void textBox_nomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                inserirNaLista();
                ExibirLista();
            }
        }
        private void button_inserir_Click(object sender, EventArgs e)
        {
            inserirNaLista();
            ExibirLista();
        }

        private void inserirNaLista()
        {
            if (textBox_nomeCompleto.Text == "")
            {
                MessageBox.Show("Insira o nome primeiro!");
            }
            else
            {
                lista.AdicionarNome(textBox_nomeCompleto.Text);
            }
            textBox_nomeCompleto.Text= String.Empty;
            textBox_nomeCompleto.Focus();
        }

        private void ExibirLista()
        {
            List<string> listaNomes = lista.RetornaNomes();
            textBox_listarNomes.Text = String.Empty;
            foreach(var nome in listaNomes)
            {
                textBox_listarNomes.Text += nome + Environment.NewLine;
            }
        }

    }
}
