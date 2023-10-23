using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class PetInstance
    {
        private int idpet;
        private string namepet;
        private int status;

        public PetInstance(int idpet,string namepet,int status)
        {
            this.IdPet = idpet;
            this.Namepet = namepet;
            this.Status = status;

        }

        public PetInstance(DataRow row)
        {
            this.IdPet = (int)row["IdPet"];
            this.Namepet = row["NamePet"].ToString();
            this.Status = (int)row["Status"];
        }


        public int IdPet { get => idpet; set => idpet = value; }
        public string Namepet { get => namepet; set => namepet = value; }
        public int Status { get => status; set => status = value; }
    }
}
