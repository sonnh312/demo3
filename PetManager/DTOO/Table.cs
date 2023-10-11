using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DTOO
{
    public class Table
    {
        private int iD;
        private string name;
        private int status;

        public void table(int id,string name, int status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        
        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
