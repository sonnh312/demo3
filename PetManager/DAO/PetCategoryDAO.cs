        using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class PetCategoryDAO
    {
        private static PetCategoryDAO instance;

        public static int TableWidth ;
        public static int TableHeigh ;


        public static PetCategoryDAO Instance
        { get { if(instance==null) instance = new PetCategoryDAO();return PetCategoryDAO.instance; }
            private set { PetCategoryDAO.instance = value; }
        }
        private PetCategoryDAO() { }
        //get pet category

        




        public List<PetCategory> LoadPetList()
        {
            List<PetCategory> petlist = new List<PetCategory>();

            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT COUNT(*) AS SoLuong, CategoryPet FROM PetCategory GROUP BY CategoryPet");
            foreach (DataRow item in data.Rows)
            {
                PetCategory table = new PetCategory(item);
                petlist.Add(table);
            }
            return petlist;
        }


        public List<PetCategory> GetListPetCategory()
        {
            List<PetCategory> lsCategory = new List<PetCategory>();
            string query = "SELECT * FROM dbo.PetCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
               PetCategory category = new PetCategory(item);
               lsCategory.Add(category);
            }

            return lsCategory;
        }


        public PetCategory GetListPetCategoryById(int id)
        {
            PetCategory category = null;
            string query = "SELECT * FROM dbo.PetCategory WHERE IdPetCategory ="+id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new PetCategory(item);
                return category;
            }

            return category;
        }




    }
}
