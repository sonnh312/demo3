using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTOO
{
    public class BillInfo
    {
        private int iD;
        private int billID;
        private int FoodID;
        private int count;

        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID1 { get => FoodID; set => FoodID = value; }
        public int Count { get => count; set => count = value; }

        public BillInfo(int int iD,int billID,int FoodID,int count)
        {
            this.ID = iD;
            this.FoodID = FoodID1;
            this.BillID = billID;
            this.Count = count;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.FoodID = (int)row["FoodID1"];
            this.BillID = (int)row[" billID"];
            this.Count = (int)row[" count"];
        }

    }
}
