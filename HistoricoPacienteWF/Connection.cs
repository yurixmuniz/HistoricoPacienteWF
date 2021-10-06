using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricoPacienteWF
{
    class Connection
    {
        private static string strCon = @"Server=tcp:aw-server0409.database.windows.net,1433;Initial Catalog=db_registro_medico;Persist Security Info=False;User ID=;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private static SqlConnection connection = null;

        public static SqlConnection ObterConexao()
        {
            SqlConnection connection = new SqlConnection(strCon);

            try
            {
                connection.Open();
            }
            catch (SqlException)
            {
                connection = null;
            }

            return connection;
        }

        public static void FecharConexao()
        {
            if (connection != null)
            {
                connection.Close();
            }


        }
    }
}
