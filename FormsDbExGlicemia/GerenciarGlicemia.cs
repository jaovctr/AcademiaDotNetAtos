using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.Data;
using System.Windows.Forms;

namespace FormsDbExGlicemia
{
    internal class GerenciarGlicemia
    {
        private int idGlicemia;
        private int valor;
        private DateTime dataMedida;
        private int idPaciente;

        public GerenciarGlicemia(int valor, DateTime dataMedida, int idPaciente)
        {
            this.valor = valor;
            this.dataMedida = dataMedida;
            this.idPaciente = idPaciente;
        }

        public GerenciarGlicemia(int idGlicemia, int valor, DateTime dataMedida, int idPaciente)
        {
            this.idGlicemia= idGlicemia;
            this.valor = valor;
            this.dataMedida = dataMedida;
            this.idPaciente = idPaciente;
        }

        public GerenciarGlicemia(int idGlicemia)
        {
            this.idGlicemia= idGlicemia;
        }

        public GerenciarGlicemia() { }

        public bool AdicionarGlicemia()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tr = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tr;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into MedidaGlicemia values(@valor,@dataMedida,@idPaciente);";
            cmd.Parameters.Add("@valor", SqlDbType.Int);
            cmd.Parameters.Add("@dataMedida", SqlDbType.Date);
            cmd.Parameters.Add("@idPaciente", SqlDbType.Int);
            cmd.Parameters[0].Value= valor;
            cmd.Parameters[1].Value= dataMedida.Date;
            cmd.Parameters[2].Value= idPaciente;

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

        public bool EditarValorGlicemia()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update MedidaGlicemia set valorGlicemia=@valor, dataMedida=@dataMedida, idPaciente=@idPaciente " +
                "where idMedidaGlicemia=@idMedidaGlicemia;";
            cmd.Parameters.Add("@valor", SqlDbType.Int);
            cmd.Parameters.Add("@dataMedida", SqlDbType.Date);
            cmd.Parameters.Add("@idPaciente", SqlDbType.Int);
            cmd.Parameters.Add("@idMedidaGlicemia",SqlDbType.Int);
            cmd.Parameters[0].Value = valor;
            cmd.Parameters[1].Value = dataMedida.Date;
            cmd.Parameters[2].Value = idPaciente;
            cmd.Parameters[3].Value = idGlicemia;

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

        public bool RemoverValor()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from MedidaGlicemia where idMedidaGlicemia=@idMedidaGlicemia;";

            cmd.Parameters.Add("@idMedidaGlicemia", SqlDbType.Int);
            cmd.Parameters[0].Value = idGlicemia;

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
    

        public SqlDataReader ExibirDados()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            try
            {
                cmd.CommandText= "SELECT[MedidaGlicemia].idMedidaGlicemia, [MedidaGlicemia].valorGlicemia, [MedidaGlicemia].dataMedida, [Paciente].nome, [Paciente].idPaciente FROM MedidaGlicemia, Paciente WHERE[MedidaGlicemia].idPaciente = [Paciente].idPaciente";
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
