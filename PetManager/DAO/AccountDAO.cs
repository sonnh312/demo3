using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
                get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { instance = value; }
        }
        public AccountDAO() { }
        public bool Login(string username,string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE Username=N'hs' AND password=N'1' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0; 
        }

        public Account GetAccountByUserName(int username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE Username=" + username);
            
            return null;
        }

    }
}
    