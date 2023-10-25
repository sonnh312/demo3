using PetManager.DAO;
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
    public partial class fPay : Form
    {
        public fPay()
        {
            InitializeComponent();
            LoadPetList();
            LoadBillHistory();
            LoadBill();
        }
        #region Method
        void LoadCus()
        {
            
        }
            
   

        void LoadPetList()
        {
            dgvPetList.DataSource = PetDAO.Instance.LoadPetListToDesign();
        }

        void LoadBillHistory()
        {
           
        }

        void LoadBill()
        {

        }

        #endregion





        #region Event



        #endregion










        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPetName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
