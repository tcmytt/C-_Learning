using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private AccountDAO() { }

        public bool Login (string userName, string passWord)
        {
            //string query = "SELECT * FROM account";

            //string query = "SELECT * FROM account where UserName = '" + userName + "' AND PassWord = '"+ passWord +"' ";
            //string query = "CALL USP_Login('" + userName + "' , '" + passWord + "') ";
            string query = "CALL USP_Login( @userName , @passWord )";
            //DataTable result = DataProvider.Instance.ExecuteQuery(query);
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {userName, passWord });


            return result.Rows.Count > 0;
        }

    }
}
