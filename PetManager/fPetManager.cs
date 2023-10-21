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
using static PetManager.fAccountProfile;

namespace PetManager
{
    public partial class fPetManager : Form
    {
        private Account loginAccount;
        public Account LoginAccount { get => this.loginAccount; set { this.loginAccount = value;ChangeAccount(loginAccount.Role); } }

        public List<BillInfo> GetListBillInfo { get; private set; }
        public fPetManager(Account acc)
        {
            InitializeComponent();
            LoadPet();
            this.loginAccount = acc;

        }

        #region Method
        void ChangeAccount(string role)
        {
            userToolStripMenuItem.Enabled = role == "admin";
            thànhViênToolStripMenuItem.Text += "(" + loginAccount.Displayname + ")";
        }

        void LoadPet()
        { 
            List<Pet> petList = PetDAO.Instance.LoadPetList();
                foreach (Pet item in petList)
                {
                Button btn= new Button() { Width = PetDAO.TableWidth, Height = PetDAO.TableHeigh };
               btn.Text = item.Name + Environment.NewLine + item.Status;
               btn.Click += btn_Click ;
                switch(item.Status)
                {
                    case "0":
                        btn.BackColor = Color.Black;
                        break;
                    default:
                        btn.BackColor = Color.Aqua;
                        break;
                }


                btn.Tag = item;
                flpPet.Controls.Add(btn);
                }
            }
            

       void ShowBill(int id)
        {
           
            lvBill.Items.Clear();
            List<BillInfo> lsBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUnCheckGetBillIdByTableId(id));     
            foreach(BillInfo item in lsBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.FoodID.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvBill.Items.Add(lvItem);
            }

       }
        void btn_Click(object sender, EventArgs e)
        {
           //string petID = ((sender as Button).Tag as Pet).Name;
           //ShowBill(petID);

        }

        

        #endregion

        #region Event
        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAccountInfo f = new FAccountInfo(loginAccount);
            f.ShowDialog();
        }

        

        // private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        //  {

        // FLogin f = new FLogin();
        //  this.Hide();
        // }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hotlineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void cácDịchVụChămSócToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTakeCarePet f = new fTakeCarePet();
            f.ShowDialog();
        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        #endregion

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();

        }
        public void f_UpdateAccount(object sender, AccountEvent e)
        {
            thànhViênToolStripMenuItem.Text = "Thông Tin Tài Khoản ( " + e.Acc.Displayname + ")";
        }





    }
}
