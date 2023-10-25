using PetManager.DAO;
using PetManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PetManager.fAccountProfile;


namespace PetManager
{
    public partial class fHomePage : Form
    {
        private Account loginAccount;
        public Account LoginAccount { get => this.loginAccount; set { this.loginAccount = value;ChangeAccount(LoginAccount.Type); } }

        public List<BillInfo> GetListBillInfo { get; private set; }
        public fHomePage(Account acc)
        {
            InitializeComponent();
            //LoadPet();
            this.LoginAccount = acc;
           

        }

        #region Method
        //check role
        void ChangeAccount(int type)
        {
                adminToolStripMenuItem.Enabled = type ==1 ;
                thànhViênToolStripMenuItem.Text += "(" + loginAccount.Displayname + ")";

        }
        // load btnpet
        void LoadPet()
        {
           // flpPet.Controls.Clear();
            List<PetList> petList = PetListDAO.Instance.LoadPetList();
                foreach (PetList item in petList)
                {
                Button btn= new Button() { Width = PetListDAO.TableWidth, Height = PetListDAO.TableHeigh };
                Label lbl = new Label() { Width = 50, Height = 50 };
                btn.Tag = item;
                btn.Text = item.Namepet;//+ Environment.NewLine + item.Price;
                btn.Click += btn_Click ;
                
                switch (item.Namepet)
                {
                    case "Dog":
                        btn.BackColor = Color.Blue;
                        break;
                    default:
                        btn.BackColor = Color.Aqua;
                        break;
                }

                lbl.Tag = item;
                btn.Tag = item;
                //flpPet.Controls.Add(btn);
                }
            }


        //custom show price
        void LoadCategory()
        {
            List<PetCategory> listCategory = PetCategoryDAO.Instance.GetListPetCategory();
            //cbCategory.DataSource = listCategory;
            //cbCategory.DisplayMember = "Price";
        }
        //custom show namepet
        void LoadPetListByCategory(int id)
        {
            List<Pet> listPet = PetDAO.Instance.GetPetByCategoryById(id);
            //cbPet.DataSource = listPet;
           // cbPet.DisplayMember = "NamePet"; 
        }
            
        //shop bill 
        void ShowBill(int id)
        {
            float totalPrice = 0;
            //lvBill.Items.Clear();
            List<PetManager.DTO.Menu> lsBillInfo = MenuDAO.Instance.GetListMenuByPetInstance(id);     
            foreach(PetManager.DTO.Menu item in lsBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.Petname.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.Totalprice.ToString());
                //lvBill.Items.Add(lvItem);
                totalPrice += item.Totalprice;  
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture; 
            //txtTotalPrice.Text = totalPrice.ToString("c",culture);
            LoadPet();

       }
        void btn_Click(object sender, EventArgs e)
        {
           int idpet = ((sender as Button).Tag as PetList).IdPet;
           ShowBill(idpet);
            //lvBill.Tag = (sender as Button).Tag;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.InsertPet += f_InsertPet;
            f.UpdatePet += f_UpdatePet;
            f.DeletePet += f_DeletePet;
            f.ShowDialog();
        }



        void f_InsertPet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        void f_UpdatePet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        void f_DeletePet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Event

        

        

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
           // PetList table = lvBill.Tag as PetList;
           // int idBill = BillDAO.Instance.GetUnCheckGetBillIdByTableId(table.IdPet);
           // int idpet = (cbPet.SelectedItem as Pet).Idpet;
            //int count = (int)nmCount.Value;
          //  if (idBill == -1)
            //{
               // BillDAO.Instance.InserBill(table.IdPet);
               // BillInfoDAO.Instance.InserBillInfo(BillDAO.Instance.GetMaxIdBill(), idpet, count);
            //}
            //else
           // {
               // BillInfoDAO.Instance.InserBillInfo(idBill, idpet, count);
            //}
            //ShowBill(table.IdPet);

            LoadPet();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
           // PetList pet = lvBill.Tag as PetList;

           // int idBill = BillDAO.Instance.GetUnCheckGetBillIdByTableId(pet.IdPet);

            //if (idBill == -1)
            //{
               // if (MessageBox.Show("Ban co chac muon thanh toan khong?", "ThongBao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
             //   {
               //     // BillDAO.Instance.CheckOut(idBill);
               //     ShowBill(pet.IdPet);
                //}
           // }

        }
        
        
        //load cb
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            PetCategory selected = cb.SelectedItem as PetCategory;
            id = selected.Idpetcategory;
            LoadPetListByCategory(id);


        }
        //load displayname
        public void f_UpdateAccount(object sender, AccountEvent e)
        {
            thànhViênToolStripMenuItem.Text = "Thông Tin Tài Khoản ( " + e.Acc.Displayname + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void thànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fPay f = new fPay();
            f.ShowDialog();
        }

        private void StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            f.ShowDialog();
        }

        private void takecareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            f.ShowDialog();
        }

        #endregion






        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
