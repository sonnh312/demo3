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
        private DateTime? dataCheckIn;
        private DateTime? dataCheckOut;
        private int status;

        public DateTime? DataCheckIn { get => dataCheckIn; set => dataCheckIn = value; }
        public DateTime? DataCheckOut { get => dataCheckOut; set => dataCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int ID { get => iD; set => iD = value; }

        public BillInfo(int id,DateTime? dataCheckIn, DateTime? dataCheckOut, int status)
        {
            this.ID = iD;
            this.DataCheckIn = dataCheckIn;
            this.DataCheckOut = dataCheckOut;
            this.Status = Status;
        }
        public Bull(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.DataCheckIn = (DateTime?)row["dataCheckIn"];
            this.DataCheckOut = (DateTime?)row["dataCheckOut"];
            this.Status = (int)row["Status"];
        }


    }


}
