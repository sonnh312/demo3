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

        public string Username { get => username; set => username = value; }
        public string Password ; 
        public string Displayname { get => displayname; set => displayname = value; }

        public Account(string username,string displayname,string password =null)
        {
            this.Username = username;
            this.Password = password;
            this.Displayname = displayname;
        }

        public Account(DataRow row )
        {
            this.Username =row["username"].ToString();
            this.Password = row["password"].ToString(); 
            this.Displayname = row["displayname"].ToString();
        }
    }
}
