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
        private static MenuDAO instance;

        public static MenuDAO Instance
        { get { if (instance == null) instance = new MenuDAO();return MenuDAO.instance ; }
            set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }
        public List<Menu> GetListMenuByPetInstance(int id)
        {
             List<Menu> listMenu = new List<Menu>();
            string query = "SELECT p.NamePet, bi.count,p.PRICE AS totalPrice FROM BillInfo AS bi, Bill AS b,Pet AS p WHERE bi.IdBillInfo = b.IdBill AND bi.IdPet = p.IdPet AND b.Status=0 AND b.IdPet = " + id;
               DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
                return listMenu;
        }
        
    }
}
