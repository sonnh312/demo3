using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class PetInstanceDAO
    {
        private static PetInstanceDAO instance;

        public static int TableWidth = 300;
        public static int TableHeigh = 70;

        public static PetInstanceDAO Instance
        {
            get { if (instance == null) instance = new PetInstanceDAO(); return PetInstanceDAO.instance; }
            private set { PetInstanceDAO.instance = value; }
        }
        public PetInstanceDAO() { }

        public List<PetInstance> LoadPetList()
        {
            List<PetInstance> petlist = new List<PetInstance>();

            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetPetList");
            foreach (DataRow item in data.Rows)
            {
                PetInstance table = new PetInstance(item);
                petlist.Add(table);
            }
            return petlist;
        }




    }
}
