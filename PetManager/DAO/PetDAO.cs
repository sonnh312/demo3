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

        public List<Menu> LoadPetToBill()
        {
            List<Menu> petlist = new List<Menu>();

            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetPetList");
            foreach (DataRow item in data.Rows)
            {
                Menu table = new Menu(item);
                petlist.Add(table);
            }
            return petlist;
        }



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

        

        public List<Pet> GetPetByName(string name)
        {
            List<Pet> list = new List<Pet>();
            string query = string.Format("SELECT * FROM dbo.Pet WHERE NamePet like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {   
                Pet pet = new Pet(item);
                list.Add(pet);
            }
            return list;

            
        }

        // get pet by idcategory 

        

        public List<Pet> GetPetLoadToBill()
        {
            List<Pet> petlist = new List<Pet>();
            string query = "SELECT NamePet, Price FROM Pet";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Pet pet = new Pet(item);
                petlist.Add(pet);
            }
            return petlist;
        }


        public bool InsertPet(int idpet, int idpetcategory,string categorypet, string namepet,int count, int price)
        {
            string query = string.Format("INSERT INTO Pet (IdPet , IdPetCategory , NamePet, CategoryPet , Price ,Count)VALUES({0} , {1}, N'{2}' , N'{3}' , {4} , {5})", idpet , idpetcategory, namepet, categorypet , price,count);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0; 
        }

        public bool UpdatePet(int idpet,int idpetcategory, string namepet, string categorypet, int count, int price)
        {
            string query = string.Format("UPDATE Pet SET IdPetCategory = {0}, NamePet = N'{1}' ,CategoryPet = N'{2}', Price = {3}, Count = {4} WHERE IdPet = {5} ", idpetcategory, namepet, categorypet, price, count,idpet );
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeletePet(string namepet)
        {
            string query = string.Format("DELETE Pet WHERE NamePet = N'{0}'",namepet);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }




    }
}
