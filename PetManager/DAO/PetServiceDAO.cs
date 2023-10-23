using System;
using System.Collections.Generic;
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


       
    }
}
