using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAgendaAluno
{
    class CtrlDisciplia
    {
        public Boolean Inserir (Disciplina objDisciplina)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                string incluiMySQL = "insert into disciplina (disciplina) VALUES (@disciplina)";
                MySqlCommand cmd = new MySqlCommand(incluiMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter("@disciplina", objDisciplina.disciplina));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
          
        }

        public List<Disciplina> preencherComboBox()
        {
            List<Disciplina> listarDisciplinaCombo = new List<Disciplina>();
            try
            {
                Disciplina objDisciplina = new Disciplina();
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                string pesqMySQL = "select * from disciplina;";
                MySqlCommand cmd = new MySqlCommand(pesqMySQL, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    objDisciplina.idDisciplina = Convert.ToInt32(dr["idDisciplina"]);
                    objDisciplina.disciplina = dr["disciplina"].ToString();
                    listarDisciplinaCombo.Add(objDisciplina);
                }
                dr.Close();
                conn.Close();
                return listarDisciplinaCombo;
            }
            catch
            {
                return null;
            }
        }

        public List<Disciplina> selecionarDisciplina()
        {
            Disciplina objDisciplina = new Disciplina();
            List<Disciplina> listarDisciplina = new List<Disciplina>();
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                string pesqMySQL = "SELECT * FROM DISCIPLINA";
                MySqlCommand cmd = new MySqlCommand(pesqMySQL, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    objDisciplina.idDisciplina = Convert.ToInt32(dr["idDisciplina"]);
                    objDisciplina.disciplina = dr["disciplina"].ToString();
                    listarDisciplina
.Add(objDisciplina);
                }
                dr.Close();
                conn.Close();
                return listarDisciplina;
            }
            catch
            {
                return null;
            }
        }

        public Boolean Alterar (Disciplina objDisciplina, int idDisciplina)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                string altMySQL = "update DISCIPLINA set disciplina = @disciplina where idDisciplina='"+idDisciplina+"';";
                MySqlCommand cmd = new MySqlCommand(altMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter("@disciplina", objDisciplina.disciplina));
                cmd.Parameters.Add(new MySqlParameter(Convert.ToString(idDisciplina), objDisciplina.idDisciplina));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public Boolean Excluir (Disciplina objDisciplina, int idDisciplina)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn = Conexao.Conectar();
                string excMySQL = "DELETE FROM DISCIPLINA WHERE idDisciplina = '" + idDisciplina + "';";
                MySqlCommand cmd = new MySqlCommand(excMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter(Convert.ToString(idDisciplina), objDisciplina.idDisciplina));
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
