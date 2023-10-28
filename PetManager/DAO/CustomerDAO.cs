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

            

            //update change cus
            public bool UpdateCus(string namecus, string address, int phone)
            {
                int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @namecus , @address , @phone", new object[] { namecus, address, phone });
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


            //load id form pay

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
