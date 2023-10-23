using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class Pet
    {
        public Pet(DataRow row)
        {
            if (int.TryParse(row["IdPet"].ToString(), out int idPetValue))
            {
                this.Idpet = idPetValue;
            }
            
            this.Categorypet = row["CategoryPet"].ToString();
            this.Namepet = row["NamePet"].ToString();
            this.Price = (int)row["Price"];
            
            if (int.TryParse(row["IdPetCategory"].ToString(), out int IdpetcategoryValue))
            {
                this.Idpetcategory = IdpetcategoryValue;
            }

        }

        public Pet(int idpet, int idpetcategory, string categorypet, string namepet, int price)
        {

            this.Idpet = idpet;
            this.Categorypet = categorypet;
            this.Namepet = namepet;
            this.Price = price;
            this.Idpetcategory = idpetcategory;


        }

        private int idpet;
        private string categorypet;
        private int idpetcategory;
        private int price;
        private string namepet;



        public int Idpet { get => idpet; set => idpet = value; }
        public string Categorypet { get => categorypet; set => categorypet = value; }
        public string Namepet { get => namepet; set => namepet = value; }
        public int Price { get => price; set => price = value; }
        public int Idpetcategory { get => idpetcategory; set => idpetcategory = value; }
    }
}
