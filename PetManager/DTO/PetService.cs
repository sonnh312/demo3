using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class PetService
    {
        private int idservice;
        private string nameservice;
        private int price;
        
        public PetService(DataRow row)
        {
            this.Idservice =(int)row["IdService"];
            this.Nameservice = row["NameService"].ToString();
            this.Price = (int)row["Price"];
        }


        public PetService(int idservice,string nameservice,int price)
        {
            this.Idservice = idservice;
            this.Nameservice = nameservice;
            this.Price = price;
        }

        public int Idservice { get => idservice; set => idservice = value; }
        public string Nameservice { get => nameservice; set => nameservice = value; }
        public int Price { get => price; set => price = value; }
    }
}
