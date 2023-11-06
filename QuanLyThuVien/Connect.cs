using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class Connect
    {
        string strConnect = @"Data Source=DESKTOP-HDN60VP\TESTDB;Initial Catalog=ThuVien_DoAn;Integrated Security=True";
        private static Connect instance;

        public static Connect Instance  // truy cập bằng tên của lớp mà không cần tạo một thể hiện của lớp
        {
            get { if (instance == null) instance = new Connect(); return Connect.instance; }
            private set { Connect.instance = value; }
        }

        public DataTable ExecuteOuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConnect))
            {

                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                conn.Close();
            }

            return data;
        }
        public bool ExecuteNonOuery(string query)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                data = command.ExecuteNonQuery();

                conn.Close();
            }
            return data > 0;
        }
    }
}
