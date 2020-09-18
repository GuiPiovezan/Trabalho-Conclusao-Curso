using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InterfaceAgendaAluno
{
    class CtrlCurso
    {
        public Boolean Inserir (Curso objCurso)
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn = Conexao.Conectar();
                String incluiMySql = @"insert into curso (descricao, coordenador, anoCurso, tipoCurso, codUnidade) values (@descricao, @coordenador, @anoCurso, @tipoCurso, @codUnidade);";
                MySqlCommand cmd = new MySqlCommand(incluiMySql, conn);
                cmd.Parameters.Add(new MySqlParameter(@"descricao", objCurso.descricao));
                cmd.Parameters.Add(new MySqlParameter(@"coordenador", objCurso.coordenador));
                cmd.Parameters.Add(new MySqlParameter(@"anoCurso", objCurso.anoCurso));
                cmd.Parameters.Add(new MySqlParameter(@"tipoCurso", objCurso.tipoCurso));
                cmd.Parameters.Add(new MySqlParameter(@"codUnidade", objCurso.codUnidade));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean Alterar (Curso objCurso, int idCurso)
        {
            MySqlConnection conn = new MySqlConnection();
            try
            { 
            conn = Conexao.Conectar();
            string altMySQL = "update CURSO set descricao=@descricao, coordenador=@coordenador, anoCurso=@anoCurso, tipoCurso=@tipoCurso, codUnidade=@codUnidade where idCurso='"+idCurso+"';";
            MySqlCommand cmd = new MySqlCommand(altMySQL, conn);
            cmd.Parameters.Add(new MySqlParameter("@descricao", objCurso.descricao));
            cmd.Parameters.Add(new MySqlParameter("@coordenador", objCurso.coordenador));
            cmd.Parameters.Add(new MySqlParameter("@anoCurso", objCurso.anoCurso));
            cmd.Parameters.Add(new MySqlParameter("@tipoCurso", objCurso.tipoCurso));
            cmd.Parameters.Add(new MySqlParameter("@codUnidade", objCurso.codUnidade));
            cmd.Parameters.Add(new MySqlParameter(Convert.ToString(idCurso), objCurso.idCurso));
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
            }
            catch
            {
                return false;
            }
        }
        
        public List<Curso> selecionarCurso ()
        {
            MySqlConnection conn = new MySqlConnection();
            Curso objCurso = new Curso();
            List<Curso> listarCursos = new List<Curso>();
            try
            {
                conn = Conexao.Conectar();
                string pesqMySQL = "SELECT * FROM CURSO";
                MySqlCommand cmd = new MySqlCommand(pesqMySQL, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    objCurso.idCurso = Convert.ToInt32(dr["idCurso"]);
                    objCurso.descricao = dr["descricao"].ToString();
                    objCurso.coordenador = dr["coordenador"].ToString();
                    objCurso.tipoCurso = dr["tipoCurso"].ToString();
                    objCurso.anoCurso = dr["anoCurso"].ToString();
                    objCurso.codUnidade = Convert.ToInt32(dr["codUnidade"]);
                    listarCursos.Add(objCurso);
                }
                dr.Close();
                conn.Close();
                return listarCursos;
            }
            catch
            {
                return null;
            }
            
        } 

        public List<Curso> preencherComboBox()
        {
            
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                List<Curso> listarCurso = new List<Curso>();
                string pesqMySQL = "select * from curso;";
                MySqlCommand cmd = new MySqlCommand(pesqMySQL, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Curso objCurso = new Curso();
                    objCurso.idCurso = Convert.ToInt32(dr["idCurso"]);
                    objCurso.descricao = dr["descricao"].ToString();
                    listarCurso.Add(objCurso);
                }
                dr.Close();
                conn.Close();
                return listarCurso;
            }
            catch
            {
                return null;
            }
            
        }

        public Boolean Excluir (Curso objCurso, int idCurso)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                string excMySQL = "DELETE FROM CURSO WHERE idCurso = '" + idCurso + "';";
                MySqlCommand cmd = new MySqlCommand(excMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter(Convert.ToString(idCurso), objCurso.tipoCurso));
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
