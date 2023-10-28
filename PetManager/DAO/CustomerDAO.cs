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


        public List<Customer> LoadCus()
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT * FROM dbo.Customer";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer cus = new Customer(item);
                list.Add(cus);
            }
            return list;
        }

        public bool InsertCus(string fullname, string address, int phone)
        {
            string query = string.Format("INSERT INTO Customer (FullName , Address, Phone)VALUES( N'{0}' , N'{1}' , {2} )", fullname, address, phone);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCus(string fullname, string address, int phone)
        {
            string query = string.Format("UPDATE Customer SET Address = N'{0}', Phone = {1} WHERE FullName = N'{2}' ", address, phone, fullname);
        int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCus(string fullname)
    {
        string query = string.Format("DELETE Customer WHERE FullName = N'{0}'", fullname);
        int result = DataProvider.Instance.ExecuteNonQuery(query);
        return result > 0;
    }





    public Customer GetNameById(int id)
        {
            Customer name = null;
            string query = "SELECT * FROM dbo.Customrer WHERE IdCus =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                name = new Customer(item);
                return name;
            }

            return name;
        }

        public List<Customer> GetListId()
        {
            List<Customer> lsCategory = new List<Customer>();
            string query = "SELECT IdCus,FullName FROM dbo.Customer";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer category = new Customer(item);
                lsCategory.Add(category);
            }

            return lsCategory;
        }

       
    }
}
