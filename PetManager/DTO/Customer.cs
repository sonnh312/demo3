using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class Customer
    {

        private string namecus;
        private string address;
        private int phone;

        public string Namecus { get => namecus; set => namecus = value; }
        public string Address { get => address; set => address = value; }
        public int Phone { get => phone; set => phone = value; }

        public Customer(string namecus, string address, int phone)
        {
            this.Namecus = namecus;
            this.Address = address;
            this.Phone = phone;
        }

        public Customer(DataRow row)
        {
            this.Namecus = row["NameCus"].ToString();
            this.Address = row["Address"].ToString();
            this.Phone = (int)row["Phone"];
        }
    }
}
