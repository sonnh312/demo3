using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class PetCusDAO
    {

        private static PetCusDAO instance;



        public static PetCusDAO Instance
        {
            get { if (instance == null) instance = new PetCusDAO(); return PetCusDAO.instance; }
            private set { PetCusDAO.instance = value; }
        }


        private PetCusDAO() { }
        public List<PetCus> GetPetName()
        {
            List<PetCus> petlist = new List<PetCus>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT NamePet,Price FROM dbo.Pet");
            foreach (DataRow item in data.Rows)
            {
                PetCus pet = new PetCus(item);
                petlist.Add(pet);
            }
            return petlist;
        }



    }
}
