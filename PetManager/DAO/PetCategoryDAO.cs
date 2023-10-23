﻿        using PetManager.DTO;
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

        public static PetCategoryDAO Instance
        { get { if(instance==null) instance = new PetCategoryDAO();return PetCategoryDAO.instance; }
            private set { PetCategoryDAO.instance = value; }
        }
        private PetCategoryDAO() { }

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
            
        
        


    }
}
