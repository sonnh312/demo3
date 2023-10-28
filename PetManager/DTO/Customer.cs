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
        private int idcus;
        private string fullname;
        private string address;
        private int phone;

        public string FullName { get => fullname; set => fullname = value; }
        public string Address { get => address; set => address = value; }
        public int Phone { get => phone; set => phone = value; }
        public int Idcus { get => idcus; set => idcus = value; }

        public Customer(int idcus,string fullname, string address, int phone)
        {
            this.FullName = fullname;
            this.Address = address;
            this.Phone = phone;
            this.Idcus = idcus;
        }

        public Customer(DataRow row)
        {
            this.Idcus = (int)row["IdCus"];
            this.FullName = row["FullName"].ToString();
            this.Address = row["Address"].ToString();
            this.Phone = (int)row["Phone"];
        }
    }
}
