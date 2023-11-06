using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ConnectSQL
{
    internal class LoginSQL
    {
        static private LoginSQL instance;

        public static LoginSQL Instance
        {
            get { if (instance == null) instance = new LoginSQL(); return instance; }
            private set => instance = value;
        }

        public bool LoginCheck(string UserName, string Pass)
        {
            string query = "SELECT * FROM Account WHERE UserName =N'" + UserName + "' AND Pass = N'" + Pass + "'";
            DataTable result = Connect.Instance.ExecuteOuery(query);

            return result.Rows.Count > 0;
        }

        public (string, string) GetDisplayName(string userName, string passWord)
        {
            string query = "SELECT Funtion FROM Account WHERE UserName =N'" + userName + "' AND Pass = N'" + passWord + "'";
            DataTable result = Connect.Instance.ExecuteOuery(query);

            return (result.Rows[0]["displayName"].ToString(), result.Rows[0]["idStaff"].ToString());
        }

        public DataTable GetAllAccount()
        {
            string query = "select * from Account";

            DataTable result = Connect.Instance.ExecuteOuery(query);

            return result;
        }
        public bool insertAccount(string usernameAccount, string passwordAccount, string funTion)
        {
            string query = $"insert into Account (UserName, Pass, Funtion) values ('{usernameAccount}','{passwordAccount}','{funTion}')";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool deleteAccount(string usernameAccount)
        {
            string query = $"DELETE FROM Account WHERE id='{usernameAccount}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool updateAccount(string usernameAccount, string passwordAccount, string funTion)
        {
            string query = $"UPDATE Account SET Pass='{passwordAccount}', Funtion='{funTion}' WHERE UserName='{usernameAccount}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public DataTable searchAccount(string usernameAccount)
        {
            string query = $"SELECT * FROM Account WHERE UserName LIKE '{usernameAccount}'";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
