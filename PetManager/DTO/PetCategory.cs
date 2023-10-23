using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class PetCategory
    {
        private int idpet;
        private int idpetcategory;
        private string categorypet;

        public PetCategory(int idpet, int idpetcategory, string categorypet)
        {
            this.Idpet = idpet;
            this.Idpetcategory = idpetcategory;
            this.Categorypet = categorypet;

        }
        public PetCategory(DataRow row)
        {
            this.Idpet = (int) row["IdPet"];
            this.Idpetcategory = (int)row["IdPetCategory"];
            this.Categorypet = row["CategoryPet"].ToString();

        }

        public int Idpet { get => idpet; set => idpet = value; }
        public int Idpetcategory { get => idpetcategory; set => idpetcategory = value; }
        public string Categorypet { get => categorypet; set => categorypet = value; }
    }
}
