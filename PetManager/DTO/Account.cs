using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class Account
    {
        private string username;
        private string password;
        private string displayname;
        private string role;
        private int type;
        private int phone;
        private string address;
        private DateTime? birthday;

        public string Username { get => username; set => username = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Role { get => role; set => role = value; }
        public int Type { get => type; set => type = value; }
        public string Password { get => password; set => password = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public DateTime? Birthday { get => birthday; set => birthday = value; }

        public Account(string username,string displayname,string role,string password =null,int phone,string address,DateTime? birthday)
        {
            this.Username = username;
            this.Password = password;
            this.Displayname = displayname;
            this.Role = role;
            this.Type = Type;
            this.Phone = phone;
            this.Address = address;
            this.Birthday = birthday;


        }

        public Account(DataRow row )
        {
            this.Username =row["Username"].ToString();
            this.Password = row["Password"].ToString(); 
            this.Displayname = row["Displayname"].ToString();
            this.Role= row["Role"].ToString();
            this.Type = (int)row["Type"];
            this.Phone = (int)row["PhoneStaff"];
            this.Address = row["AddressStaff"].ToString();
            this.Birthday = (DateTime?)row["Birthday"];


        }
    }
}
