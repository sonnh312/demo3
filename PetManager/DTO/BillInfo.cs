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
        private int idbill;
        private int idpet;
        private int count;

        
        public int Count { get => count; set => count = value; }
        public int Idbill { get => idbill; set => idbill = value; }
        public int Idpet { get => idpet; set => idpet = value; }

        public BillInfo(int idbill, int idpet,int count)
        {
            this.Idbill = idbill;
            this.Idpet = idpet;
            this.Count = count;
        }
        public BillInfo (DataRow row)
        {
            this.Idbill = (int)row["IdBill"];
            this.Idpet = (int)row["IdPet"];
            this.Count = (int)row["Count"];
        }

    }
}
