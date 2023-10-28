using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class PetCus
    {
        public PetCus(DataRow row)
        {
            this.Namepet = row["NamePet"].ToString();
            this.Price = (int)row["Price"];
        }

        public PetCus(string namepet, int price)
        {

            
            this.Namepet = namepet;
            this.Price = price;
            


        }

        private int price;
        private string namepet;




       
        public string Namepet { get => namepet; set => namepet = value; }
        public int Price { get => price; set => price = value; }
        
    }
}
