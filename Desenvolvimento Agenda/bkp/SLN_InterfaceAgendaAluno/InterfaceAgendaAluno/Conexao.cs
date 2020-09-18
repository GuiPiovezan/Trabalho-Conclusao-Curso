using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InterfaceAgendaAluno
{
    class Conexao
    {
        public string testarConexao()
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                string connConnection = "server = 127.0.0.1; user id=root;password=''; database=AGENDA";
                conn.ConnectionString = connConnection;
                conn.Open();
                return "Conexão estabelecida com sucesso!";
            }
            catch(Exception ex)
            {
                return "Problemas com a conexão database:\n" + ex;
            }
         }

        public static MySqlConnection Conectar()
        {
            MySqlConnection conn = new MySqlConnection();
            //Utiliza-se esse server=127.0.0.1;user id=root;database=agenda;
            string connConnection = "server = 127.0.0.1; user id=root; database=AGENDA";
            conn.ConnectionString = connConnection;
            conn.Open();
            return conn;
        }

       
    }
}
