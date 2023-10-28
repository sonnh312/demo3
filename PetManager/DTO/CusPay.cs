using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTO
{
    public class CusPay
    {
        
            private int idcus;
            private string fullname;


        public int Idcus { get => idcus; set => idcus = value; }
        public string Fullname { get => fullname; set => fullname = value; }

        public CusPay(int idcus, string fullname)
            {
            this.Fullname = fullname;
                this.Idcus = idcus;
            }

            public CusPay(DataRow row)
            {
                this.Idcus = (int)row["IdCus"];
            this.Fullname = row["FullName"].ToString();
            }
     
    }
}
