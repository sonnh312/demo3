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




        public Bill(int idBill, DateTime? dataCheckIn, DateTime? dataCheckOut, string status)
        {
            this.Idbill = idbill;
            this.Datecheckin = datecheckin;
           // var dateCheckOutTemp = row["dataCheckOut"];
            this.Datecheckout = datecheckout;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.Idbill = (int)row["IdBill"];
            this.Datecheckin = (DateTime?)row["dataCheckIn"];
            this.Datecheckout = (DateTime?)row["dataCheckOut"];
            this.Status = row["Status"].ToString();
        }
    }
}
