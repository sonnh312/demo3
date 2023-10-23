using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class Menu
    {
        public Menu(string petname, int count,float price, float totalprice)
        {
            this.Petname = petname;
            this.Count = count;
            this.Price = price;
            this.Totalprice = totalprice;
        }

        public Menu(DataRow row)
        {
            this.Petname = row["NamePet"].ToString();
            this.Count = (int)row ["Count"];
            this.Price = (float)Convert.ToDouble((row["Price"]).ToString());
            this.Totalprice = (float)Convert.ToDouble((row["totalPrice"].ToString()));
        }


        private string petname;
        private int count;
        private float price;
        private float totalprice;

        public string Petname { get => petname; set => petname = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float Totalprice { get => totalprice; set => totalprice = value; }
    }
}
