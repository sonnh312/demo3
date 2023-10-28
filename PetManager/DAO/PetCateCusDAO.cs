using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class PetCateCusDAO
    {
        private static PetCateCusDAO instance;

        public static int TableWidth = 50;
        public static int TableHeigh = 70;


        public static PetCateCusDAO Instance
        {
            get { if (instance == null) instance = new PetCateCusDAO(); return PetCateCusDAO.instance; }
            private set { PetCateCusDAO.instance = value; }
        }
        private PetCateCusDAO() { }
       
        public List<PetCateCus> LoadPetList()
        {
            List<PetCateCus> petlist = new List<PetCateCus>();

            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT COUNT(*) AS SoLuong, CategoryPet FROM PetCategory GROUP BY CategoryPet");
            foreach (DataRow item in data.Rows)
            {
                PetCateCus table = new PetCateCus(item);
                petlist.Add(table);
            }
            return petlist;
        }


        

    }
}
