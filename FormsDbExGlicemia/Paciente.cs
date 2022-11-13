using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDbExGlicemia
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void button_conectar_Click(object sender, EventArgs e)
        {
            ExibirPaciente();
            panel_dados.Enabled = true;
            button_cadastrar.Enabled = true;
            button_conectar.Enabled = false;
            button_deletar.Enabled = true;
            button_editar.Enabled = true;
        }

        private void ExibirPaciente()
        {
            listView_exibirPaciente.Items.Clear();
            GerenciarPaciente pacientes = new GerenciarPaciente();
            SqlDataReader dados = pacientes.ExibirPacientes();
            int i = 0;
            string[] vetorDados;
            while(dados.Read())
            {
                listView_exibirPaciente.Items.Add(dados["idPaciente"].ToString());
                listView_exibirPaciente.Items[i].SubItems.Add(dados["nome"].ToString());
                listView_exibirPaciente.Items[i].SubItems.Add(dados["email"].ToString());
                i++;
            }
        }

        private void LimparCampos()
        {
            textBox_idPaciente.Text = string.Empty;
            textBox_nome.Text = string.Empty;
            textBox_email.Text = string.Empty;
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            textBox_idPaciente.Enabled = false;
            textBox_nome.Enabled = true;
            textBox_email.Enabled = true;
            button_salvar.Enabled = true;
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            textBox_idPaciente.Enabled = true;
            textBox_nome.Enabled = false;
            textBox_email.Enabled = false;
            button_salvar.Enabled = true;
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            textBox_idPaciente.Enabled = true;
            textBox_nome.Enabled = true;
            textBox_email.Enabled = true;
            button_salvar.Enabled = true;

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            GerenciarPaciente gp = new GerenciarPaciente();
            if(textBox_idPaciente.Enabled==true && textBox_nome.Enabled == false)
            {
                gp.Paciente(int.Parse(textBox_idPaciente.Text));
                if (gp.RemoverPaciente())
                {
                    MessageBox.Show("Paciente removido");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro. Paciente não removido!");
                }

            }
             else if (textBox_idPaciente.Enabled == false && textBox_nome.Enabled == true)
             {
                if(gp.Paciente(textBox_nome.Text, textBox_email.Text))
                {
                    if(gp.AdicionarPaciente() )
                    {
                        MessageBox.Show("Paciente Adicionado!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro. Paciente não adicionado!");
                    }
                }

            }
            else
            {
                if (gp.Paciente(int.Parse(textBox_idPaciente.Text), textBox_nome.Text, textBox_email.Text))
                {
                    if (gp.EditarPaciente())
                    {
                        MessageBox.Show("Paciente Editado!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro. Paciente não editado!");
                    }
                }
            }
            LimparCampos();
            ExibirPaciente();

        }
    }
}
