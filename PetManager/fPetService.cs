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
        public fPetService()
        {
            InitializeComponent();
            LoadPetService();
        }

        void LoadPetService()
        {

            List<PetService> list = new List<PetService>();
            dgvPetService.DataSource = PetServiceDAO.Instance.LoadPetService();
        }

       
        private void btnSeach_Click(object sender, EventArgs e)
        {

            
        }

    }
}
