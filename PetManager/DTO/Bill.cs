using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class Bill
    {
        private int idbill;
        private DateTime? dataCheckIn;
        private DateTime? dataCheckOut;
        private int status;

        public int Idbill { get => idbill; set => idbill = value; }
        public DateTime? DataCheckIn { get => dataCheckIn; set => dataCheckIn = value; }
        public DateTime? DataCheckOut { get => dataCheckOut; set => dataCheckOut = value; }
        public int Status { get => status; set => status = value; }




        public Bill(int idBill, DateTime? dataCheckIn, DateTime? dataCheckOut, int status)
        {
            this.Idbill = idbill;
            this.DataCheckIn = dataCheckIn;
           // var dateCheckOutTemp = row["dataCheckOut"];
            this.DataCheckOut = dataCheckOut;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.Idbill = (int)row["idbill"];
            this.DataCheckIn = (DateTime?)row["dataCheckIn"];
            this.DataCheckOut = (DateTime?)row["dataCheckOut"];
            this.Status = (int)row["Status"];
        }
    }
}
