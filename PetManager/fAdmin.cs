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
        List<Pet> SeachPetByName(string name)
        {
            List<Pet> list = PetDAO.Instance.GetPetByPetName(name);

            return list;
        }

        void AddPetBinding()
        {
            txtId.DataBindings.Add(new Binding("Text", petlist, "IdPetCategory", true, DataSourceUpdateMode.Never));
            txtNamepet.DataBindings.Add(new Binding("Text", petlist, "NamePet", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Value", petlist, "Price", true, DataSourceUpdateMode.Never));
        }
         
        void LoadCategoryIntoCb(ComboBox cb)
        {
            cb.DataSource = PetCategoryDAO.Instance.GetListPetCategory();
            cb.DisplayMember = "CategoryPet";
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
            int id = Convert.ToInt32(txtId.Text);

            if (PetDAO.Instance.DeletePet(id))
            {
                MessageBox.Show("Xoa thanh cong");
                LoadListPet();
                if (deletePet != null)
                    deletePet(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Xoa that bai ");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtNamepet.Text;
            int idcategory = (cbPetCategory.SelectedItem as PetCategory).Idpetcategory;
            int price = (int)nmPrice.Value;
            int idpet = Convert.ToInt32(txtId);
            
            if (PetDAO.Instance.UpdatePet(idpet,name, idcategory, price))
            {
                MessageBox.Show("Sua thanh cong");
                LoadListPet();
                if (updatePet != null)
                    updatePet(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Loi khi sua lai");
            }
        }

        private void txtNamepet_TextChanged(object sender, EventArgs e)
        {
            int id = (int)dgvPetList.SelectedCells[0].OwningRow.Cells["IdPetCategory"].Value;
            PetCategory category = PetCategoryDAO.Instance.GetListPetCategoryById(id);
            cbPetCategory.SelectedItem = category;
            int index = -1;
            int i = 0;
            foreach(PetCategory item in cbPetCategory.Items)
            {
                if(item.Idpetcategory==category.Idpetcategory)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cbPetCategory.SelectedIndex = index;
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            petlist.DataSource = SeachPetByName(txtNamepet.Text);
        }



        #endregion


    }
}
