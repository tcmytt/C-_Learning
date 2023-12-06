using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        public static int TableWidth = 120;
        public static int TableHeight = 120;
        private static TableDAO instance;

        public static TableDAO Instance { 
            get
            {
                if (instance == null)
                {
                    instance = new TableDAO();
                }
                return instance;
            }
            private set 
            {
                instance = value;
            } 
        }

        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tablelist = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("CALL USP_GetTableList()");

            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);
                tablelist.Add(table);
            }
            return tablelist;
        }
    }
}
