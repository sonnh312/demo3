using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class CusPayDAO
    {
        private static CusPayDAO instance;

        public static CusPayDAO Instance
        {
            get { if (instance == null) instance = new CusPayDAO(); return CusPayDAO.instance; }
            private set { CusPayDAO.instance = value; }
        }
        public CusPayDAO() { }

        public List<CusPay> GetListId()
        {
            List<CusPay> lsCategory = new List<CusPay>();
            string query = "SELECT IdCus,FullName FROM dbo.Customer";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CusPay category = new CusPay(item);
                lsCategory.Add(category);
            }

            return lsCategory;
        }





    }
}
