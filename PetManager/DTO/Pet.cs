using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class Pet
    {
        public Pet(DataRow row )
        {
            this.Idpet = (int)row["IdPet"];
            this.Idpet = (int)row["IdPetCategory"];-
            this.Namepet = row["NamePet"].ToString();
            this.Status = row["Status"].ToString();
        }


        public Pet(int idpet,string namepet,string status)
        {
            
            this.Namepet = namepet;
            this.Status = status;
            this.Idpet = idpet;
            this.Idpetcategory = idpetcategory;
        }

        private int idpet;
        private int idpetcategory;
        private string status;
        private string namepet;
        
        

        
        public string Namepet { get => namepet; set => namepet = value; }
        public string Status { get => status; set => status = value; }
        public int Idpet { get => idpet; set => idpet = value; }
        public int Idpetcategory { get => idpetcategory; set => idpetcategory = value; }
    }
}
