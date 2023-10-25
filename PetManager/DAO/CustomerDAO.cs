using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }
        public CustomerDAO() { }

       
        //update change pass 
        public bool UpdateCus(string namecus, string address, int phone)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @namecus , @address , @phone", new object[] { namecus, address, phone });
            return result > 0;
        }

        // find account
        public Customer GetCusByName(string namecus)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE Username =N'" + namecus + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Customer(item);
            }
            return null;
        }


    }
}
