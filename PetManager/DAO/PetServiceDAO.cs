using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class PetServiceDAO
    {
        private static PetServiceDAO instance;

        public static PetServiceDAO Instance
        { get { if (instance == null) instance = new PetServiceDAO(); return PetServiceDAO.instance; }
             private set { PetServiceDAO.instance = value; } }
        

        private PetServiceDAO() { }



        public List<PetService> LoadPetService()
        {
            List<PetService> list = new List<PetService>();

            string query = "SELECT * FROM dbo.PetService";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PetService pet = new PetService(item);
                list.Add(pet);
            }
            return list;
        }
        public List<PetService> GetPetServiceByName(string name)
        {
            List<PetService> list = new List<PetService>();

            string query = string.Format("SELECT * FROM dbo.PetService WHERE NamePet like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PetService pet = new PetService(item);
                list.Add(pet);
            }
            return list;
        }
        public bool InsertService(int idservice, string nameservice, int price)
        {
            string query = string.Format("INSERT INTO PetService (IdService , NameService , Price ) VALUES ({0} , N'{1}' , {2})", idservice, nameservice, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateService(int idservice, string nameservice, int price)
        {
            string query = string.Format("UPDATE PetService SET NameService = N'{0}' , Price = {1} WHERE IdService = {2}", nameservice, price, idservice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteService(int idservice)
        {
           // BillInfoDAO.Instance.DeleteBillInfoById(idservice);

            string query = string.Format("DELETE PetService WHERE IdService = {0}", idservice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }






    }
}
