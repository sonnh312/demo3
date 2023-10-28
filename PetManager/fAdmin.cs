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
        BindingSource bill = new BindingSource();
        BindingSource petlist = new BindingSource();
        BindingSource stafflist = new BindingSource();
        BindingSource petservice = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            LoadListStaff();
            LoadListPet();
            AddBinding();
            AddBindingService();
            AddBindingBill();
            LoadPetService();
            LoadBill();
            dgvPetList.DataSource = petlist;
            dgvStaff.DataSource = stafflist;
            dgvPetService.DataSource = petservice;
            dgvRevenue.DataSource = bill;



        }
        #region Method
        
         void AddBindingBill()
        {
           
            dtpBill.DataBindings.Add(new Binding("Value", bill, "DateCheckIn", true, DataSourceUpdateMode.Never));
            txtCountPet.DataBindings.Add(new Binding("Text", bill, "Price", true, DataSourceUpdateMode.Never));
            txtTotalPrice.DataBindings.Add(new Binding("Text", bill, "Count", true, DataSourceUpdateMode.Never));

        }



        void LoadBill()
        {
            
            bill.DataSource = BillDAO.Instance.LoadBill();
        }

        void AddBindingService()
        {
            txtIdPetService.DataBindings.Add(new Binding("Text", petservice, "IdService", true, DataSourceUpdateMode.Never));
            txtNameService.DataBindings.Add(new Binding("Text", petservice, "NameService", true, DataSourceUpdateMode.Never));
            nmPriceService.DataBindings.Add(new Binding("Value", petservice , "Price", true, DataSourceUpdateMode.Never));


        }


        void AddBindingStaff()
        {
            txtNameStaff.DataBindings.Add(new Binding("Text", stafflist, "Displayname", true, DataSourceUpdateMode.Never));
            txtPhone.DataBindings.Add(new Binding("Text", stafflist, "Phone", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", stafflist, "Address", true, DataSourceUpdateMode.Never));
            txtAccStaff.DataBindings.Add(new Binding("Text", stafflist, "Username", true, DataSourceUpdateMode.Never));
            txtPassStaff.DataBindings.Add(new Binding("Text", stafflist, "Password", true, DataSourceUpdateMode.Never));
            

        }

        void LoadPetService()
        {
            List<PetService> list = new List<PetService>();
            petservice.DataSource = PetServiceDAO.Instance.LoadPetService();

        }
        // account
        void SeachStaffByUsername()
        {
            string query = "EXEC USP_GetAccountByUserName @username";
            stafflist.DataSource = DataProvider.Instance.ExecuteQuery(query,new object[] {"hs"});
        }

        void LoadListStaff()
        {
            List<Staff> list = new List<Staff>();
            stafflist.DataSource = StaffDAO.Instance.LoadStaff();
        }
        // list pet
        void LoadListPet()
        {
            List<Pet> list = new List<Pet>();
            petlist.DataSource = PetDAO.Instance.LoadPetListToDesign();
        }

        
        //binding 
        void AddBinding()
        {
            txtIdPet.DataBindings.Add(new Binding("Text", petlist, "IdPet", true, DataSourceUpdateMode.Never));
            txtIdCategory.DataBindings.Add(new Binding("Text", petlist, "IdPetCategory", true, DataSourceUpdateMode.Never));
            txtNamepet.DataBindings.Add(new Binding("Text", petlist, "NamePet", true, DataSourceUpdateMode.Never));
            txtCategoryPet.DataBindings.Add(new Binding("Text", petlist, "CategoryPet", true, DataSourceUpdateMode.Never));
            txtCount.DataBindings.Add(new Binding("Text", petlist, "Count", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Value", petlist, "Price", true, DataSourceUpdateMode.Never));

        }
        
        /// <summary>
        /// PetEdit
        /// </summary>
        /// <param name="idpet"></param>
        /// <param name="idpetcategory"></param>
        /// <param name="namepet"></param>
        /// <param name="categorypet"></param>
        /// <param name="count"></param>
        /// <param name="price"></param>
        void AddPet(int idpet, int idpetcategory, string namepet,string categorypet, int count, int price)
        {
            if(PetDAO.Instance.InsertPet(idpet, idpetcategory, categorypet,  namepet,  count,  price))
            {
                MessageBox.Show("Them Thu cung thanh cong");
            }
            else
            {
                MessageBox.Show("them that bai");
            }
            LoadListPet();
        }

        void UpdatePet(int idpet,int idpetcategory, string namepet,string categorypet, int count, int price)
        {
            if (PetDAO.Instance.UpdatePet(idpet, idpetcategory,categorypet, namepet, count, price))
            {
                MessageBox.Show("Sua thu cung thanh cong");
            }
            else
            {
                MessageBox.Show("sua that bai");
            }
            LoadListPet();
        }

        void DeletePet( string namepet)
        {
            if (PetDAO.Instance.DeletePet(namepet))
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("xoa that bai");
            }
            LoadListPet();
        }
        /// <summary>
        /// ServiceEdit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSer(int idservice, string nameservice, int price)
        {
            if (PetServiceDAO.Instance.InsertService( idservice,  nameservice,  price))
            {
                MessageBox.Show("Them Thu cung thanh cong");
            }
            else
            {
                MessageBox.Show("them that bai");
            }
            LoadPetService();
        }

        void UpSer(int idservice, string nameservice, int price)
        {
            if (PetServiceDAO.Instance.UpdateService( idservice,  nameservice,  price))
            {
                MessageBox.Show("Sua thu cung thanh cong");
            }
            else
            {
                MessageBox.Show("sua that bai");
            }
            LoadPetService();
        }

        void DelSer(int idservice)
        {
            if (PetServiceDAO.Instance.DeleteService(idservice))
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("xoa that bai");
            }
            LoadPetService();
        }




        #endregion

        #region Event

        private void btnSeach_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int idpet = Int32.Parse(txtIdPet.Text);
            int idpetcategory = Int32.Parse(txtIdCategory.Text);
            string namepet = txtNamepet.Text;
            string categorypet = txtCategoryPet.Text;
            int count = Int32.Parse(txtCount.Text);
            int price = (int) nmPrice.Value;

            AddPet(idpet, idpetcategory,categorypet, namepet, count, price);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idpet = Int32.Parse(txtIdPet.Text);
            int idpetcategory = Int32.Parse(txtIdCategory.Text);
            string namepet = txtNamepet.Text;
            string categorypet = txtCategoryPet.Text;
            int count = Int32.Parse(txtCount.Text);
            int price = (int)nmPrice.Value;

            UpdatePet( idpet,idpetcategory, namepet, categorypet, count, price);
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            string namepet = txtNamepet.Text;
            DeletePet(namepet);
        }

        private void btnAddSer_Click(object sender, EventArgs e)
        {
            int idser = Int32.Parse(txtIdPetService.Text);
            
            string name = txtNameService.Text;
            
            int price = (int)nmPriceService.Value;
            AddSer(idser, name, price);
        }

        private void btnDelSer_Click(object sender, EventArgs e)
        {
            int idser = Int32.Parse(txtIdPetService.Text);
            DelSer(idser);

        }

        private void btnUpdateSer_Click(object sender, EventArgs e)
        {
            int idser = Int32.Parse(txtIdPetService.Text);

            string name = txtNameService.Text;

            int price = (int)nmPriceService.Value;
            UpSer(idser, name, price);
        }



        void btnSelect_Click(object sender, EventArgs e)
        {
            LoadListPet();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            

        }

        

        private void btnSeach_Click(object sender, EventArgs e)
        {
            
        }




        #endregion

        private void cbPrice_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIdPetService_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
