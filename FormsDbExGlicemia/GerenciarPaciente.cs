using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsDbExGlicemia
{
    internal class GerenciarPaciente
    {
        private int idPaciente;
        private string nome;
        private string email;

        public GerenciarPaciente() { }

        public void Paciente(int idPaciente) {
            this.idPaciente= idPaciente;
        } 
        public bool Paciente(string nome,string email)
        {
            
            this.nome = nome;

            if (ValidaEmail(email))
            {
                this.email = email;
                return true;
            }
            else
            {
                MessageBox.Show("E-mail inválido");
                return false;
            }
        }
        public bool Paciente(int idPaciente, string nome, string email)
        {
            this.idPaciente = idPaciente;
            this.nome = nome;

            if(ValidaEmail(email))
            {
                this.email = email;
                return true;
            }
            else
            {
                MessageBox.Show("E-mail inválido");
                return false;
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
            string[] vetorEmail = email.Split('@');
            if (vetorEmail.Length < 2)
            {
                return false;
            }
            return true;
        }

        public bool AdicionarPaciente()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tr = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tr;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Paciente values(@nome,@email);";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@email", SqlDbType.VarChar);

            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = email;

            try
            {
                cmd.ExecuteNonQuery();
                tr.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }

        public bool EditarPaciente()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tr = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tr;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update Paciente set nome=@nome,email=@email where idPaciente=@idPaciente";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@email", SqlDbType.VarChar);
            cmd.Parameters.Add("idPaciente", SqlDbType.Int);

            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = email;
            cmd.Parameters[2].Value = idPaciente;

            try
            {
                cmd.ExecuteNonQuery();
                tr.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }

        public bool RemoverPaciente()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from Paciente where idPaciente=@idPaciente;";
            cmd.Parameters.Add("@idPaciente", SqlDbType.Int);
            cmd.Parameters[0].Value = idPaciente;

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                b.fecharConexao();
            }
        }

        public SqlDataReader ExibirPacientes()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            try
            {
                cmd.CommandText = "select [Paciente].idPaciente,[Paciente].nome,[Paciente].email from Paciente;";
                SqlDataReader dados = cmd.ExecuteReader();
                return dados;
                
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }

}


