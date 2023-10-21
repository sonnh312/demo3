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
            this.Idpet = (int)row["idPet"];
            this.Name = row["NamePet"].ToString();
            this.Status = row["status"].ToString();
        }


        public Pet(int idpet,string name,string status)
        {
            
            this.Name = name;
            this.Status = status;
            this.Idpet = idpet;
        }

        private int idpet;
       // private string 
        private string status;
        private string name;
        
        

        
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int Idpet { get => idpet; set => idpet = value; }

    }
}
