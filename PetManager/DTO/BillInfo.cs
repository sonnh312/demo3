using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class BillInfo
    {
        private int iD;
        private int billID;
        private int foodID;
        private int count;

        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }

        public BillInfo(int iD,int billID,int FoodID,int count)
        {
            this.ID = iD;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }
        public BillInfo (DataRow row)
        {
            this.ID = (int)row["iD"];
            this.FoodID = (int)row["foodID"];
            this.BillID = (int)row[" billID"];
            this.Count = (int)row[" count"];
        }

    }
}
