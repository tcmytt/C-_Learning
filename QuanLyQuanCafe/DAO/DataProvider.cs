using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        string connectionString = "server=127.0.0.1:3306;database=QuanLyQuanCafe;user=root;password=G@jxinh176;";

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            try
            {
                string connectionString = "server=localhost;database=QuanLyQuanCafe;user=root;password=G@jxinh176;";
                using(MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    if(parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach(string para in listPara)
                        {
                            if (para.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(para, parameter[i]);
                                i++;
                            }
                        }
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(data);

                    connection.Close();
                }
                return data;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Lỗi kết nối database");
                return data;
            }
        }


        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            string connectionString = "server=localhost;database=QuanLyQuanCafe;user=root;password=G@jxinh176;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }


        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            string connectionString = "server=localhost;database=QuanLyQuanCafe;user=root;password=G@jxinh176;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();

                connection.Close();
            }
            return data;
        }


    }
}
