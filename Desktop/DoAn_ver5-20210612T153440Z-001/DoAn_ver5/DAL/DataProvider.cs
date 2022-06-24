using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    public class DataProvider
    {
        private string cnnStr = @"Data Source=LAPTOP-51GQMDC8\SQLEXPRESS;Initial Catalog=DOAN_TEST;Integrated Security=True";
        
        private static DataProvider _Instance;
        public static DataProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DataProvider();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private DataProvider()
        {
            cnnStr = @"Data Source=LAPTOP-51GQMDC8\SQLEXPRESS;Initial Catalog=DOAN_TEST;Integrated Security=True";
        }
        public bool ExcuteDB(string query)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cnnStr))
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cnn.Open();
                da.Fill(dt);
                cnn.Close();
                return dt;                
            }
        }
        public DataTable ExecuteQueryParam(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection cnn = new SqlConnection(cnnStr))
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(query, cnn);
                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(data);
                cnn.Close();
            }
            return data;
        }
    }
}
