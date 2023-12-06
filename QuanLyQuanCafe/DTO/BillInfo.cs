using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        private int billID;
        private int iD;
        private int foodID;
        private int count;

        public BillInfo(int iD, int billID, int foodID, int count)
        {
            BillID = billID;
            ID = iD;
            FoodID = foodID;
            Count = count;
        }

        public BillInfo(DataRow row) {
            BillID = (int)row["idbill"];
            ID = (int)row["iD"];
            FoodID = (int)row["idfood"];
            Count = (int)row["count"];
        }

        public int BillID { get => billID; set => billID = value; }
        public int ID { get => iD; set => iD = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }
    }
}
