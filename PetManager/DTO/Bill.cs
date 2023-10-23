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
        private DateTime? datecheckin;
        private DateTime? datecheckout;
        private string status;

        public int Idbill { get => idbill; set => idbill = value; }
        public DateTime? Datecheckin { get => datecheckin; set => datecheckin = value; }

        public DateTime? Datecheckout { get => datecheckout; set => datecheckout = value; }
        public string Status { get => status; set => status = value; }




        public Bill(int idBill, DateTime? dateCheckIn, DateTime? dateCheckOut, string status)
        {
            this.Idbill = idbill;
            this.Datecheckin = datecheckin;
            //var dateCheckOutTemp = row ["DateCheckOut"];
            //if (dateCheckOutTemp.ToString != "")
              //  this.Datecheckout = (DateTime?)dateCheckOutTemp;
            this.Datecheckout = datecheckout;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.Idbill = (int)row["IdBill"];
            this.Datecheckin = (DateTime?)row["DateCheckIn"];
            this.Datecheckout = (DateTime?)row["DateCheckOut"];
            this.Status = row["Status"].ToString();
        }
    }
}
