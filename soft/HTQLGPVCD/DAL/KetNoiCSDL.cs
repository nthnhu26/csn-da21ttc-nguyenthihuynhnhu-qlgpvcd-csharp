using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class KetNoiCSDL
    {
        private static KetNoiCSDL? instance;
        private string connectionString = "Data Source=HUYNHNHU;Initial Catalog=QLGPVCD;Integrated Security=True";
        private SqlConnection connection;
        
        public static KetNoiCSDL Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new KetNoiCSDL();
                }
                return instance;
            }
            private set { KetNoiCSDL.instance = value; }
        }

        private KetNoiCSDL()
        {
            connection = new SqlConnection();

        }
        // Thiết lập chuỗi kết nối
        public void SetConnectionString(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //trả về đối tượng SQLConnection để sử dụng trong các yêu cầu truy vấn CSDL
        public SqlConnection GetConnection()
        {
            return connection;
        }
        //Mở kết nối CSDL 
        public void OpenConnection()
        {
            if (string.IsNullOrEmpty(connection.ConnectionString))
            {
                connection.ConnectionString = connectionString;
            }
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
          
        }
        //Đóng kết nối cơ sở dữ liệu 
        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }


    }
}
