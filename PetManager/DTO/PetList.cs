using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class PetList
    {
        private int idpet;
        private string namepet;
        private int status;

        public PetList(int idpet,string namepet,int status)
        {
            this.IdPet = idpet;
            this.Namepet = namepet;
            this.Status = status;

        }

        public PetList(DataRow row)
        {
            if (int.TryParse(row["IdPet"].ToString(), out int idPetValue))
            {
                this.IdPet = idPetValue;
            }

            this.Namepet = row["NamePet"].ToString();
            if (int.TryParse(row["Status"].ToString(), out int StatusValue))
            {
                this.Status = StatusValue;
            }
        }


        public int IdPet { get => idpet; set => idpet = value; }
        public string Namepet { get => namepet; set => namepet = value; }
        public int Status { get => status; set => status = value; }
    }
}
