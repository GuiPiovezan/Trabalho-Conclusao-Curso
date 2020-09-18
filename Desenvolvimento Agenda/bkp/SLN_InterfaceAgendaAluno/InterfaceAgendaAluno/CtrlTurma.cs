using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InterfaceAgendaAluno
{
    class CtrlTurma
    {
        
        Turma objTurma = new Turma();
        public Boolean Inserir (Turma objTurma)
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn = Conexao.Conectar();
                string incluiMySQL = "insert into turma (descricao, codCurso, codPeriodo) values (@descricao, @codCurso, @codPeriodo);";
                MySqlCommand cmd = new MySqlCommand(incluiMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter(@"descricao", objTurma.descricao));
                cmd.Parameters.Add(new MySqlParameter(@"codCurso", objTurma.codCurso));
                cmd.Parameters.Add(new MySqlParameter("@codPeriodo", objTurma.codPeriodo));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Turma> selecionarTurma()
        {
            List<Turma> listarTurmas = new List<Turma>();
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn = Conexao.Conectar();
                string pesqMySQL = "SELECT * FROM TURMA";
                MySqlCommand cmd = new MySqlCommand(pesqMySQL, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    objTurma.idTurma = Convert.ToInt32(dr["idTurma"]);
                    objTurma.descricao = dr["descricao"].ToString();
                    objTurma.codCurso = Convert.ToInt32(dr["codCurso"]);
                    objTurma.codPeriodo = Convert.ToInt32(dr["codPeriodo"]);
                    listarTurmas.Add(objTurma);
                }
                
                dr.Close();
                conn.Close();
                return listarTurmas;
            }
            catch
            {
                return null;
            }
        }
        public Turma pesquisarTurma(string idTurma)
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn = Conexao.Conectar();
                string pesqMySQL = "SELECT * FROM TURMA WHERE idTurma = '"+idTurma+"';";
                MySqlCommand cmd = new MySqlCommand(pesqMySQL, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    objTurma.idTurma = Convert.ToInt32(dr["idTurma"]);
                    objTurma.descricao = dr["descricao"].ToString();
                    objTurma.codCurso = Convert.ToInt32(dr["codCurso"]);
                    objTurma.codPeriodo = Convert.ToInt32(dr["codPeriodo"]);
                }
                dr.Close();
                conn.Close();
                return objTurma;
            }
            catch
            {
                return null;
            }
        }

        public List<Turma> preencherCombo ()
        {
            List<Turma> listarTurma = new List<Turma>();
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                string pesqMySQl = "select * from turma;";
                MySqlCommand cmd = new MySqlCommand(pesqMySQl, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    objTurma.idTurma = Convert.ToInt32(dr["idTurma"]);
                    objTurma.descricao = dr["descricao"].ToString();
                    listarTurma.Add(objTurma);
                }
                dr.Close();
                conn.Close();
                return listarTurma;
            }
            catch
            {
                return null;
            }
        }

        public Boolean Alterar (Turma objTurma, int idTurma)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                string altMySQL = "update turma set descricao=@descricao, codCurso=@codCurso, codPeriodo=@codPeriodo where idTurma='" + idTurma + "';";
                MySqlCommand cmd = new MySqlCommand(altMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter("@descricao", objTurma.descricao));
                cmd.Parameters.Add(new MySqlParameter("@codCurso", objTurma.codCurso));
                cmd.Parameters.Add(new MySqlParameter("@codPeriodo", objTurma.codPeriodo));
                cmd.Parameters.Add(new MySqlParameter(Convert.ToString(idTurma), objTurma.idTurma));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch 
            {
                return false;
            }

        }

        public Boolean Excluir (Turma objTurma, int idTurma)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                string excMySQL = "DELETE FROM TURMA WHERE idTurma = '"+idTurma+"';";
                MySqlCommand cmd = new MySqlCommand(excMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter(Convert.ToString(idTurma), objTurma.idTurma));
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
