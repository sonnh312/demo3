    using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class PetDAO
    {
        private static PetDAO instance;

        public static PetDAO Instance
        { get { if (instance == null) instance = new PetDAO();return PetDAO.instance   ; }
            private set { PetDAO.instance = value; }
        }


        private PetDAO() { }
        //load pet
        public List<Pet> LoadPetListToDesign()
        {
            List<Pet> list = new List<Pet>(); 

            string query = "SELECT * FROM dbo.Pet";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Pet pet = new Pet(item);
                list.Add(pet); 
            }
            return list;
        }


        // get pet by idcategory 

        public List<Pet> GetPetByCategoryById(int id)
        {
            List<Pet> petlist = new List<Pet>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT *  FROM dbo.Pet WHERE IdPetCategory = " + id);
            foreach (DataRow item in data.Rows)
            {
                Pet pet = new Pet(item);
                petlist.Add(pet);
            }
            return petlist;
        }   


        public bool InsertPet(string namepet,int idpetcategory, int price)
        {
            string query = string.Format("INSERT INTO Pet (NamePet , IdPetCategory , PRICE)VALUES(N'{0}' , {1} , '{2}')", namepet, idpetcategory, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0; 
        }
        public bool UpdatePet(string namepet, int idpetcategory, int price, string idPet)
        {
            string query = string.Format("UPDATE Pet SET NamePet = N'{0}', IdPetCategory = {1} , PRICE '{2}' WHERE IdPet = {3})", namepet, idpetcategory, price,idPet);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeletePet(int idPet)
        {
            BillInfoDAO.Instance.DeleteBillInfoById(idPet);

            string query = string.Format("DELETE WHERE IdPet = {0})",idPet);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }




    }
}
