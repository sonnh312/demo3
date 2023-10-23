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
using PetManager.DTO;

namespace PetManager
{

    public partial class fAdmin : Form
    {

        BindingSource petlist = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            LoadListAccount();
            LoadListPet();
            AddPetBinding();
            LoadCategoryIntoCb(cbPetCategory);
            dgvPetList.DataSource = petlist;//data khong bi mat ket noi khi su dung binding

        }
        #region Method

        // account
        void LoadListAccount()
        {
            string query = "EXEC USP_GetAccountByUserName @username";
            dgvLoadAccount.DataSource = DataProvider.Instance.ExecuteQuery(query,new object[] {"hs"});
        }
        
        void LoadQuestionType()
        {
            // tao list do du lieu vao chinh display member and value member
            //List<QuestionType>
            //  list = 
        }

        // list pet
        void LoadListPet()
        {

            List<Pet> list = new List<Pet>();
            petlist.DataSource = PetDAO.Instance.LoadPetListToDesign();
        }


        void AddPetBinding()
        {
            txtId.DataBindings.Add(new Binding("Text", dgvPetList, "IdPetCategory", true, DataSourceUpdateMode.Never));
            txtNamepet.DataBindings.Add(new Binding("Text", dgvPetList, "NamePet", true, DataSourceUpdateMode.Never));
            cbPetCategory.DataBindings.Add(new Binding("Text", dgvPetList, "CategoryPet", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Price", dgvPetList, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCb(ComboBox cb)
        {
            cb.DataSource = PetCategoryDAO.Instance.GetListPetCategory();
            cb.DisplayMember = "Namepet";
        }

        #endregion

        #region Event

        private event EventHandler insertPet;
        public event EventHandler InsertPet
        {
            add { insertPet += value; }
            remove { insertPet -= value; }
        }
        private event EventHandler deletePet;
        public event EventHandler DeletePet
        {
            add { deletePet += value; }
            remove { DeletePet -= value; }
        }

        private event EventHandler updatePet;
        public event EventHandler UpdatePet
        {
            add { updatePet += value; }
            remove { UpdatePet -= value; }
        }


        //load pet to add,del..
        void btnSelect_Click(object sender, EventArgs e)
        {
            LoadListPet();
        }

        //check categorypet = id cate
        private void txtIDpet_TextChanged(object sender, EventArgs e)
        {
            if (dgvPetList.SelectedCells.Count > 0)
            {
                int id = (int)dgvPetList.SelectedCells[0].OwningRow.Cells["IdPetCategory"].Value;
                int i = 0;
                List<PetCategory> category = PetCategoryDAO.Instance.GetListPetCategory();
                cbPetCategory.SelectedItem = category;
                int index = -1;
                foreach (PetCategory item in cbPetCategory.Items)
                {
                    index = i;
                    break;
                }
                i++;


            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {


            string name = txtNamepet.Text;
            int idcategory = (cbPetCategory.SelectedItem as PetCategory).Idpetcategory;
            int price = (int)nmPrice.Value;
            if(PetDAO.Instance.InsertPet(name, idcategory, price))
            {
                MessageBox.Show("Them thanh cong");
                LoadListPet();
                if (insertPet != null)
                insertPet(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Loi them lai");
            }

        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtNamepet.Text);

            if (PetDAO.Instance.DeletePet(id))
            {
                MessageBox.Show("Them thanh cong");
                LoadListPet();
                if (deletePet != null)
                    deletePet(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Loi them lai");
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtNamepet.Text;
            int idcategory = (cbPetCategory.SelectedItem as PetCategory).Idpetcategory;
            int price = (int)nmPrice.Value;
            string idpet = txtId.Text;
            if (PetDAO.Instance.UpdatePet(name, idcategory, price, idpet))
            {
                MessageBox.Show("Sua thanh cong");
                LoadListPet();
                if (updatePet != null)
                    updatePet(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Loi them lai");
            }
        }





        #endregion

        private void txtNamepet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
