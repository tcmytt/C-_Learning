using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        private string name;
        private string status;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }

        public Table(int iD,string name, string status  )
        {
            this.iD = iD;
            this.name = name;
            this.status = status;
        }

        public Table(DataRow row) {
            this.ID = (int)row["id"];
            this.Name = (string)row["name"];
            this.status = (string)row["status"];
        }
    }
}
