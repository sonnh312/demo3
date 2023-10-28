using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class PetCateCus
    {

        
        private int idpetcategory;
        private string categorypet;

        public PetCateCus(int idpetcategory, string categorypet)
        {
          
            this.Idpetcategory = idpetcategory;
            this.Categorypet = categorypet;

        }
        public PetCateCus(DataRow row)
        {
            
            this.Idpetcategory = (int)row["SoLuong"];
            this.Categorypet = row["CategoryPet"].ToString();

        }

        
        public int Idpetcategory { get => idpetcategory; set => idpetcategory = value; }
        public string Categorypet { get => categorypet; set => categorypet = value; }
    }
}
