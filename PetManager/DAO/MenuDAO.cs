using System;
using PetManager.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PetManager.DAO
{
    public class MenuDAO
    {
        /// <summary>
        /// this class to multi edit show list bill
        /// </summary>
        private static MenuDAO instance;

        public static MenuDAO Instance
        { get { if (instance == null) instance = new MenuDAO();return MenuDAO.instance ; }
            set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }
        public List<Menu> GetListBillByName(string name)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT b.IdBill, p.NamePet, b.count, p.Price, p.Price*b.count AS totalPrice FROM dbo.Bill AS b,dbo.Pet AS p WHERE b.IdPet = p.IdPet AND b.Status = N'Unpaid' AND p.PetName=" + name;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
                return listMenu;
        }
        public List<Menu> LoadBill()
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT * FROM Bill";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }

        public List<Menu> GetListBill(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT p.NamePet, bi.count,p.PRICE AS totalPrice FROM BillInfo AS bi, Bill AS b,Pet AS p WHERE bi.IdBill = b.IdBill AND bi.IdPet = p.IdPet AND b.Status=N'Unpaid' AND b.IdPet = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }

    }
}
