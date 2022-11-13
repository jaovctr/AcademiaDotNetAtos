using Microsoft.SqlServer.Server;
using System.Data.SqlClient;

namespace FormsDbExGlicemia
{
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
        }
        
        private void button_conectar_Click(object sender, EventArgs e)
        {
            ExibirLista();
            button_conectar.Enabled = false;
            button_cadastrar.Enabled = true;
            button_deletar.Enabled = true;
            button_editar.Enabled = true;
            panel_cadastrar.Enabled = true;
            

        }

        private void ExibirLista()
        {
            listView_exibirValores.Items.Clear();
            GerenciarGlicemia gc = new GerenciarGlicemia();
            SqlDataReader dados = gc.ExibirDados();
            int i = 0;
            string[] vetorDados;
            while(dados.Read())
            {
                listView_exibirValores.Items.Add(dados["idMedidaGlicemia"].ToString());
                listView_exibirValores.Items[i].SubItems.Add(dados["valorGlicemia"].ToString());
                vetorDados = dados["dataMedida"].ToString().Split(' ');
                listView_exibirValores.Items[i].SubItems.Add(vetorDados[0]);
                listView_exibirValores.Items[i].SubItems.Add(dados["nome"].ToString());
                listView_exibirValores.Items[i].SubItems.Add(dados["idPaciente"].ToString());
                i++;
            }
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            textBox_idGlicemia.Enabled = false;
            textBox_idPaciente.Enabled = true;
            textBox_valorGlicemia.Enabled = true;
            dateTimePicker_data.Enabled = true;
            button_salvarGlicemia.Enabled = true;
            
        }

        private void button_salvarGlicemia_Click(object sender, EventArgs e)
        {

            if(textBox_idGlicemia.Enabled == false && textBox_valorGlicemia.Enabled==true)
            {
                int valorGlicemia = int.Parse(textBox_valorGlicemia.Text);
                int idPaciente = int.Parse(textBox_idPaciente.Text);
                DateTime data = dateTimePicker_data.Value.Date;
                GerenciarGlicemia gc = new GerenciarGlicemia(valorGlicemia, data, idPaciente);
                if (gc.AdicionarGlicemia())
                {
                    MessageBox.Show("Valor adicionado!");
                }
                else
                {
                    MessageBox.Show("Algum erro ocorreu, o valor não foi adicionado");
                }

            }else if(textBox_idGlicemia.Enabled=true && textBox_valorGlicemia.Enabled == false)
            {
                GerenciarGlicemia gc = new GerenciarGlicemia(int.Parse(textBox_idGlicemia.Text));
                if (gc.RemoverValor())
                {
                    MessageBox.Show("Valor removido!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro, valor não removido!");
                }
            }
            else
            {
                int idGlicemia = int.Parse(textBox_idGlicemia.Text);
                int valorGlicemia = int.Parse(textBox_valorGlicemia.Text);
                int idPaciente = int.Parse(textBox_idPaciente.Text);
                DateTime data = dateTimePicker_data.Value.Date;
                GerenciarGlicemia gc = new GerenciarGlicemia(idGlicemia, valorGlicemia, data, idPaciente);
                if (gc.EditarValorGlicemia())
                {
                    MessageBox.Show("valor editado!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro, valor não editado");
                }
            }

            LimparCampos();
            ExibirLista();
        }


        private void LimparCampos()
        {
            textBox_idGlicemia.Text = string.Empty;
            textBox_idPaciente.Text= string.Empty;
            textBox_valorGlicemia.Text= string.Empty;
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            textBox_idGlicemia.Enabled = true;
            textBox_idPaciente.Enabled = false;
            textBox_valorGlicemia.Enabled = false;
            dateTimePicker_data.Enabled = false;
            button_salvarGlicemia.Enabled = true;
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            textBox_idGlicemia.Enabled = true;
            textBox_idPaciente.Enabled = true;
            textBox_valorGlicemia.Enabled = true;
            button_salvarGlicemia.Enabled = true;
        }

        private void button_gerPaciente_Click(object sender, EventArgs e)
        {
            var gerPaciente = new Paciente();
            gerPaciente.Show();
        }
    }
}