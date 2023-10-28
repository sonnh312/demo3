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
        private int idpet;
        private string namepet;
        private DateTime? datecheckin;
        private int price;
        private string status;
        private int count;

        public int Idbill { get => idbill; set => idbill = value; }
        public DateTime? Datecheckin { get => datecheckin; set => datecheckin = value; }
        public string Status { get => status; set => status = value; }
        public int Idpet { get => idpet; set => idpet = value; }
        public string Namepet { get => namepet; set => namepet = value; }
        public int Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }

        public Bill(int idBill,int idpet, string namepet ,DateTime? datecheckin ,int price,int count  ,string status)
        {
            this.Idbill = idbill;
            this.Idpet = idpet;
            this.Datecheckin = datecheckin;
            this.Namepet = namepet;
            this.Price = price;
            this.Count = count;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.Idbill = (int)row["IdBill"];
            this.Idpet = (int)row["IdPet"];
            this.Datecheckin = (DateTime?)row["DateCheckIn"];
            var datecheckintemp = (DateTime?)row["DateCheckIn"];
             if (datecheckintemp.ToString() != "")
                this.Datecheckin = (DateTime?)datecheckintemp;
            this.Namepet =row["NamePet"].ToString() ;
            this.Price = (int) row["Price"];
             this.Count =(int) row["Count"];
            this.Status = row["Status"].ToString();
        }
    }
}
