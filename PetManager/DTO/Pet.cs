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

            this.Idpet = (int)row["IdPet"];
            this.Categorypet = row["CategoryPet"].ToString();
            this.Namepet = row["NamePet"].ToString();
            this.Price = (int)row["Price"];
            this.Idpetcategory =(int) row["IdPetCategory"];
            this.Count = (int)row["Count"];



        }

        public Pet(int idpet, int idpetcategory, string categorypet, string namepet, int price,int count)
        {

            this.Idpet = idpet;
            this.Categorypet = categorypet;
            this.Namepet = namepet;
            this.Price = price;
            this.Idpetcategory = idpetcategory;
            this.Count = count;


        }

        private int idpet;
        private string categorypet;
        private int idpetcategory;
        private int price;
        private string namepet;
        private int count;



        public int Idpet { get => idpet; set => idpet = value; }
        public string Categorypet { get => categorypet; set => categorypet = value; }
        public string Namepet { get => namepet; set => namepet = value; }
        public int Price { get => price; set => price = value; }
        public int Idpetcategory { get => idpetcategory; set => idpetcategory = value; }
        public int Count { get => count; set => count = value; }
    }
}
