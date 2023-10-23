using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class PetListDAO
    {
        private static PetListDAO instance;

        public static int TableWidth = 300;
        public static int TableHeigh = 70;

        public static PetListDAO Instance
        {
            get { if (instance == null) instance = new PetListDAO(); return PetListDAO.instance; }
            private set { PetListDAO.instance = value; }
        }
        public PetListDAO() { }

        public List<PetList> LoadPetList()
        {
            List<PetList> petlist = new List<PetList>();

            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetPetList");
            foreach (DataRow item in data.Rows)
            {
                PetList table = new PetList(item);
                petlist.Add(table);
            }
            return petlist;
        }




    }
}
