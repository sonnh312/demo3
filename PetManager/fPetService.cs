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
    

    public partial class fPetService : Form
    {

        BindingSource petser = new BindingSource();
        public fPetService()
        {
            InitializeComponent();
            LoadPetService();
            dgvPetService.DataSource = petser;
        }

        void LoadPetService()
        {
            petser.DataSource = PetServiceDAO.Instance.LoadPetService();
        }

       
        
        List<PetService> SeachPetSer(string name)
        {
            List<PetService> list = PetServiceDAO.Instance.GetPetSerByName(name);

            return list;
        }

        

        private void btnSeachSer_Click(object sender, EventArgs e)
        {
            petser.DataSource = SeachPetSer(txtPetService.Text);
        }
    }
}
