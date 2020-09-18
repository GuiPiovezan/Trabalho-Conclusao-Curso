using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InterfaceAgendaAluno
{
    class CtrlAula
    {
        MySqlConnection conn = new MySqlConnection();
        

        public Boolean Inserir (Aula objAula)
        {
            try
            {
                conn = Conexao.Conectar();
                string incluiMySQL = "insert into aula (dataAula, horaInicio, horaTermino, locall, codTurma, codDisciplina) values(@dataAula, @horaInicio, @horaTermino, @locall, @codTurma, @codDisciplina);";
                MySqlCommand cmd = new MySqlCommand(incluiMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter(@"dataAula", objAula.dataAula));
                cmd.Parameters.Add(new MySqlParameter(@"horaInicio", objAula.horaInicio));
                cmd.Parameters.Add(new MySqlParameter(@"horaTermino", objAula.horaTermino));
                cmd.Parameters.Add(new MySqlParameter(@"locall", objAula.locall));
                cmd.Parameters.Add(new MySqlParameter("@codTurma", objAula.codTurma));
                cmd.Parameters.Add(new MySqlParameter("@codDisciplina", objAula.codDisciplina));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean Alterar (Aula objAula, int idAula)
        {
            try
            {
                conn = Conexao.Conectar();
                string altMySQL = "update AULA set  locall=@locall, horaInicio=@horaInicio, horaTermino=@horaTermino, dataAula=@dataAula, codTurma = @codTurma, codDisciplina=@codDisciplina where idAula = '"+idAula+"';";
                MySqlCommand cmd = new MySqlCommand(altMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter("@locall", objAula.locall));
                cmd.Parameters.Add(new MySqlParameter("@horaInicio", objAula.horaInicio));
                cmd.Parameters.Add(new MySqlParameter("@horaTermino", objAula.horaTermino));
                cmd.Parameters.Add(new MySqlParameter("@dataAula", objAula.dataAula));
                cmd.Parameters.Add(new MySqlParameter("@codTurma", objAula.codTurma));
                cmd.Parameters.Add(new MySqlParameter("@codDisciplina", objAula.codDisciplina));
                cmd.Parameters.Add(new MySqlParameter("@idAula", objAula.idAula));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public List<Aula> selecionarAula()
        {
            List<Aula> listarAula = new List<Aula>();
            try
            {
                Aula objAula = new Aula();
                CtrlAula objCtrlAual = new CtrlAula();
                conn = Conexao.Conectar();
                string pesqMySQL = " SELECT * FROM AULA"; 
                MySqlCommand cmd = new MySqlCommand(pesqMySQL, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    objAula.idAula = Convert.ToInt32(dr["idAula"]);
                    objAula.locall = dr["locall"].ToString();
                    objAula.horaInicio = dr["horaInicio"].ToString();
                    objAula.horaTermino = dr["horaTermino"].ToString();
                    objAula.dataAula = dr["dataAula"].ToString();
                    objAula.codTurma = Convert.ToInt32(dr["codTurma"]);
                    objAula.codDisciplina = Convert.ToInt32(dr["codDisciplina"]);
                    listarAula.Add(objAula);
                }
                
                dr.Close();
                conn.Close();
                return listarAula;
            }
            catch
            {
                return null;
            }
        }

        public Boolean Excluir (Aula objAula, int idAula)
        {
            try
            {
                conn = Conexao.Conectar();
                string excMySQL = "delete from aula where idAula =  '" + idAula + "';";
                MySqlCommand cmd = new MySqlCommand(excMySQL, conn);
                cmd.Parameters.Add(new MySqlParameter(Convert.ToString(idAula), objAula.idAula));
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
