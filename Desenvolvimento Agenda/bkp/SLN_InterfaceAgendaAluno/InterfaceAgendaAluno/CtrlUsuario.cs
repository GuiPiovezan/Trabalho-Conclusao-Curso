using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAgendaAluno
{
    class CtrlUsuario
    {
        
        MySqlConnection conn = new MySqlConnection();

        public Boolean Inserir (Usuario objUsuario)
        {
            
            try
            {
                conn = Conexao.Conectar();
                string incluiMySQL = @"insert into usuario(nome, email, senha, dataNascimento, telefone, codTipoUsuario) values (@nome, @email, @senha, @dataNascimento, @telefone, @codTipoUsuario);";
                MySqlCommand cmd = new MySqlCommand(incluiMySQL, conn);

                cmd.Parameters.Add(new MySqlParameter("@nome", objUsuario.nome));
                cmd.Parameters.Add(new MySqlParameter("@email", objUsuario.email));
                cmd.Parameters.Add(new MySqlParameter("@senha", objUsuario.senha));
                cmd.Parameters.Add(new MySqlParameter("@dataNascimento", objUsuario.dataNascimento));
                cmd.Parameters.Add(new MySqlParameter("@telefone", objUsuario.telefone));
                cmd.Parameters.Add(new MySqlParameter("@codTipoUsuario", objUsuario.codTipoUsuario));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Usuario Logar (Usuario objUsuario, int idRecebido, string emailRecebido, string senhaRecebido)
        {
            string email = emailRecebido, senha = senhaRecebido;
            int idUsuario = idRecebido;
            try
            {
                conn = Conexao.Conectar();
                MySqlCommand cmd = new MySqlCommand("select * from usuario where email= '"+email+"' AND senha = '"+senha+"';", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                objUsuario.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                objUsuario.email = dr["email"].ToString();
                objUsuario.senha = dr["senha"].ToString();
                dr.Close();
                cmd.Dispose();
                conn.Close();
                return objUsuario;
            }
            catch (MySqlException ex)
            {
                return null;
            }
         }

        public Usuario selecionarUsuario (int idUsuario)
        {
            Usuario objUsuario = new Usuario();
            try
            {
                conn = Conexao.Conectar();
                string pesqMySQL = "SELECT * FROM USUARIO WHERE idUsuario = '"+idUsuario+"';";
                MySqlCommand cmd = new MySqlCommand(pesqMySQL, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                objUsuario.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                objUsuario.nome = dr["nome"].ToString();
                objUsuario.email = dr["email"].ToString();
                objUsuario.senha = dr["senha"].ToString();
                objUsuario.telefone = dr["telefone"].ToString();
                objUsuario.dataNascimento = dr["dataNascimento"].ToString();
                objUsuario.codTipoUsuario = Convert.ToInt32(dr["codTipoUsuario"]);
                dr.Close();
                conn.Close();
                return objUsuario;
            }
            catch
            {
                return null;
            }
            

        }

        public Boolean Alterar (Usuario objUsuario, int idUsuario)
        {
            try
            {
                conn = Conexao.Conectar();
                string altMySQL = "update USUARIO set nome = @nome, email = @email, senha = @senha, dataNascimento = @dataNascimento, telefone = @telefone, codTipoUsuario = @codTipoUsuario where idUsuario = '"+idUsuario+"' ;";
                MySqlCommand cmd = new MySqlCommand(altMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter("@nome", objUsuario.nome));
                cmd.Parameters.Add(new MySqlParameter("@email", objUsuario.email));
                cmd.Parameters.Add(new MySqlParameter("@senha", objUsuario.senha));
                cmd.Parameters.Add(new MySqlParameter("@dataNascimento", objUsuario.dataNascimento));
                cmd.Parameters.Add(new MySqlParameter("@telefone", objUsuario.telefone));
                cmd.Parameters.Add(new MySqlParameter("@codTipoUsuario", objUsuario.codTipoUsuario));
                cmd.Parameters.Add(new MySqlParameter("@idUsuario", objUsuario.idUsuario));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean Excluir (Usuario objUsuario, int idUsuario)
        {
            try
            {
                conn = Conexao.Conectar();
                string excMySQl = "DELETE FROM USUARIO WHERE idUsuario = '"+ idUsuario+"';";
                MySqlCommand cmd = new MySqlCommand(excMySQl, conn);
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
