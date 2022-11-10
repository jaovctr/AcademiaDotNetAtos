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
    public partial class Questao3 : Form
    {
        GerenciaCripto moedas = new GerenciaCripto();
        public Questao3()
        {
            InitializeComponent();
            ListarMoedas();
        }

        private void button_addCripto_Click(object sender, EventArgs e)
        {
            AdicionarCripto();
            LimparCampoAdc();
            ListarMoedas();
        }

        private void AdicionarCripto()
        {
            string sigla = textBox_adcsigla.Text;
            string nome = textBox_adcnome.Text;
            double valor = double.Parse(textBox_adcvalor.Text); 
            Criptomoeda c = new Criptomoeda(nome,sigla,valor);
            moedas.AdicionarCripto(c);
        }
        
        private void LimparCampoAdc()
        {
            textBox_adcnome.Text = String.Empty;
            textBox_adcsigla.Text = String.Empty;
            textBox_adcvalor.Text = String.Empty;
        }

        private void button_removerCripto_Click(object sender, EventArgs e)
        {
            moedas.RemoverCripto(textBox_remover.Text);
            textBox_remover.Text = String.Empty;
            ListarMoedas();
        }

        private void ListarMoedas()
        {
            listView_exibir.Clear();

            List<Criptomoeda> lista = moedas.retornaLista();
            listView_exibir.Columns.Add("Sigla");
            listView_exibir.Columns.Add("Nome");
            listView_exibir.Columns.Add("Valor");
            foreach (var cripto in lista)
            {
                ListViewItem linha = new ListViewItem(cripto.Sigla);
                linha.SubItems.Add(new ListViewItem.ListViewSubItem(linha, cripto.Nome));
                linha.SubItems.Add(new ListViewItem.ListViewSubItem(linha, cripto.Valor.ToString()));
                
                listView_exibir.Items.Add(linha);
                
            }
        }
    }
}
