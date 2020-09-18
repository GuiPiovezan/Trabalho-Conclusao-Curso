using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace InterfaceAgendaAluno
{
    class CtrlUnidade
    {
        Unidade objUnidade = new Unidade();
        MySqlConnection conn = new MySqlConnection();
        public Boolean Inserir (Unidade objUnidade)
        {
            try
            {
                conn = Conexao.Conectar();
                string incluiMySQL = "insert into unidade (nomeUnidade, enderecoUnidade, emailUnidade, telefoneUnidade) values (@nomeUnidade, @enderecoUnidade, @emailUnidade, @telefoneUnidade);";
                MySqlCommand cmd = new MySqlCommand(incluiMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter(@"nomeUnidade", objUnidade.nomeUnidade));
                cmd.Parameters.Add(new MySqlParameter(@"enderecoUnidade", objUnidade.enderecoUnidade));
                cmd.Parameters.Add(new MySqlParameter(@"emailUnidade", objUnidade.emailUnidade));
                cmd.Parameters.Add(new MySqlParameter(@"telefoneUnidade", objUnidade.telefoneUnidade));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public Boolean Alterar(Unidade objUnidade, int idUnidade)
        {
            try
            {
                conn = Conexao.Conectar();
                string altMySQL = "update UNIDADE set nomeUnidade = @nomeUnidade, emailUnidade=@emailUnidade, enderecoUnidade=@enderecoUnidade, telefoneUnidade=@telefoneUnidade where idEscola='"+idUnidade+"';";
                MySqlCommand cmd = new MySqlCommand(altMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter("@nomeUnidade", objUnidade.nomeUnidade));
                cmd.Parameters.Add(new MySqlParameter("@emailUnidade", objUnidade.emailUnidade));
                cmd.Parameters.Add(new MySqlParameter("@enderecoUnidade", objUnidade.enderecoUnidade));
                cmd.Parameters.Add(new MySqlParameter("@telefoneUnidade", objUnidade.telefoneUnidade));
                cmd.Parameters.Add(new MySqlParameter(Convert.ToString(idUnidade), objUnidade.idEscola));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public List<Unidade> preencherComboBox ()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                List<Unidade> listarUnidade = new List<Unidade>();
                string pesqMySQL = "select * from unidade;";
                MySqlCommand cmd = new MySqlCommand(pesqMySQL, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    objUnidade.idEscola = Convert.ToInt32(dr["idEscola"]);
                    objUnidade.nomeUnidade = dr["nomeUnidade"].ToString();
                    listarUnidade.Add(objUnidade);
                }
                dr.Close();
                conn.Close();
                return listarUnidade;
            }
            catch 
            {
                return null;
            }
        }

        public List<Unidade> selecionarUnidades()
        {
            try
            {
                List<Unidade> listarUnidades = new List<Unidade>();
                conn = Conexao.Conectar();
                string pesqMySQL = "SELECT * FROM UNIDADE;";
                MySqlCommand cmd = new MySqlCommand(pesqMySQL, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    objUnidade.idEscola = Convert.ToInt32(dr["idEscola"]);
                    objUnidade.nomeUnidade = dr["nomeUnidade"].ToString();
                    objUnidade.enderecoUnidade = dr["enderecoUnidade"].ToString();
                    objUnidade.emailUnidade = dr["emailUnidade"].ToString();
                    objUnidade.telefoneUnidade = dr["telefoneUnidade"].ToString();
                    listarUnidades.Add(objUnidade);
                }
                dr.Close();
                conn.Close();
                return listarUnidades;
            }
            catch
            {
                return null;
            }
            
        }

        public Boolean Excluir (Unidade objUnidade, int idUnidade)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                string excMySQL = "DELETE FROM UNIDADE WHERE idEscola = '" + idUnidade + "';";
                MySqlCommand cmd = new MySqlCommand(excMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter(Convert.ToString(idUnidade), objUnidade.idEscola));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
