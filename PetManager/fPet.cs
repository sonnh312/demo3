using PetManager.DAO;
using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManager
{
    public partial class fPet : Form
    {

        BindingSource petlist = new BindingSource();
        public fPet()
        {
            InitializeComponent();
            LoadListPet();
        }

        void LoadListPet()
        {

            List<Pet> list = new List<Pet>();
            petlist.DataSource = PetDAO.Instance.LoadPetListToDesign();
        }

        public List<Pet> SeachPetByName(string name)
        {
            List<Pet> list = PetDAO.Instance.GetPetByPetName(name);

            return list;
        }
        private void btnSeach_Click(object sender, EventArgs e)
        {
           
            petlist.DataSource = SeachPetByName(txtNamePet.Text);
        }

    }
}
