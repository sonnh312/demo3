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
            dgvPetList.DataSource = petlist;
        }

        void LoadListPet()
        {
            petlist.DataSource = PetDAO.Instance.LoadPetListToDesign();
        }

        List<Pet> SeachPet(string name)
        {
            List<Pet> list = PetDAO.Instance.GetPetByName(name);

            return list;
        }

        private void btnSeachPet_Click(object sender, EventArgs e)
        {
            petlist.DataSource = SeachPet(txtNamePet.Text);

        }
    }
}
