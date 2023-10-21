using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using PetManager.DAO;

namespace PetManager
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadListAccount();
            LoadListAccount();
            LoadListPet();
            AddPetBinding();
            LoadCategoryIntoCb(cbPet);

        }
        #region Method

        //load to set account
        void LoadListAccount()
        {
            string query = "EXEC USP_GetAccountByUserName @username";
            DataProvider provider = new DataProvider();
            dtgvAccount.DataSource = provider.ExecuteQuery(query, new object[] { "hs" });

        }

        void LoadQuestionType()
        {
            // tao list do du lieu vao chinh display member and value member
            //List<QuestionType>
            //  list = 
        }
        void LoadListPet()
        {
            dgvPetList.DataSource = PetDAO.Instance.LoadPetListToDesign();
        }
        void AddPetBinding()
        {
            txtIDpet.DataBindings.Add(new Binding("IdPet", dgvPetList, "IdPet"));
            txtNamepet.DataBindings.Add(new Binding("Namepet", dgvPetList, "NamePet"));
            txtKindpet.DataBindings.Add(new Binding("PetKind", dgvPetList, "PetKind"));
            txtStatuspet.DataBindings.Add(new Binding("Status", dgvPetList, "Status"));
        }

        void LoadCategoryIntoCb(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Namepet";
        }

        #endregion

        #region Event


        //public void ResetInput()
        //{

        //}

        private void lvPet_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem item;
            item = e.Item;
            txtIDpet.Text = item.Text;
            txtNamepet.Text = item.SubItems[1].Text;
            txtKindpet.Text = item.SubItems[2].Text;
            txtStatuspet.Text = item.SubItems[3].Text;
            
            

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            //item = 
            //ResetInput();
            txtIDpet.Focus();
        }
        //load pet to add,del..
        void btnSelect_Click(object sender, EventArgs e)
        {
            LoadListPet();
        }


        #endregion
        

        
    }
}
