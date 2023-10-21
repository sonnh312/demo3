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
        private string type;

        public string Username { get => username; set => username = value; }
        public string Password ; 
        public string Displayname { get => displayname; set => displayname = value; }
        public string Role { get => role; set => role = value; }
        

        public Account(string username,string displayname,string role,string password =null)
        {
            this.Username = username;
            this.Password = password;
            this.Displayname = displayname;
            this.Role = role;
            
        }

        public Account(DataRow row )
        {
            this.Username =row["Username"].ToString();
            this.Password = row["Password"].ToString(); 
            this.Displayname = row["Displayname"].ToString();
            this.Role= row["Role"].ToString();
            
        }
    }
}
