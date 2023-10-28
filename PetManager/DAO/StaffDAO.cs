using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }
        public StaffDAO() { }

        public bool Login(string username,string password)
        {
            
            string query = "exec USP_LoginAccount @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] { username,password});
            return result.Rows.Count > 0; 
        }

       //update change pass 
        public bool UpdateAccount(string username,string displayname,string password,string newpassword)
        {
            int  result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @username , @displayname , @password , @newpassword",new object[] {username,displayname,password,newpassword });
            return result > 0;
        }


        public DataTable InfoStaff()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT (Username,Password,Displayname,Phone,Address) FROM Staff");
        }




        public bool UpdateInfo(string phone, string address, DateTime birthday)
        { 
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateInfo @phone , @address , @birthday ", new object[] { phone, address, birthday });
            return result > 0;
        }
        public List<Staff> LoadStaff()
        {
            List<Staff> list = new List<Staff>();
            string query = "SELECT * FROM Staff";
            DataTable data =DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                list.Add(staff);
            }
            return list;
        }

        // find account
        public Staff GetAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Staff WHERE Username =N'"+username+"'");
            foreach (DataRow item in data.Rows)
            {
                return new Staff(item);
            }
            return null;
        }
        public bool InsertStaf(int idservice, string nameservice, int price)
        {
            string query = string.Format("INSERT INTO PetService (IdService , NameService , Price ) VALUES ({0} , N'{1}' , {2})", idservice, nameservice, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateStaff(int idservice, string nameservice, int price)
        {
            string query = string.Format("UPDATE PetService SET NameService = N'{0}' , Price = {1} WHERE IdService = {2}", nameservice, price, idservice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteStaff(int idservice)
        {
            //BillInfoDAO.Instance.DeleteBillInfoById(idservice);

            string query = string.Format("DELETE PetService WHERE IdService = {0}", idservice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }






    }
}
    