using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class KetNoiCSDL
    {
        private string chuoiketnoi = "Data Source=HUYNHNHU;Initial Catalog=HTQUANLYGIOPVCD;Integrated Security=True";
        public SqlConnection KetNoi()
        {
            return new SqlConnection(chuoiketnoi);
        }

        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = KetNoi())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            return data;
        }

        public bool ExecuteNonQuery(SqlCommand command)
        {
            using (SqlConnection connection = KetNoi())
            {
                command.Connection = connection;
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public object ExecuteScalar(SqlCommand command)
        {
            using (SqlConnection connection = KetNoi())
            {
                command.Connection = connection;
                connection.Open();
                return command.ExecuteScalar();
            }
        }
        public DataTable ExecuteReader(SqlCommand command)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = KetNoi())
            {
                command.Connection = connection;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    data.Load(reader);
                }
            }
            return data;
        }


    }
}
