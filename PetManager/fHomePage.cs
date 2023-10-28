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
        private Staff loginAccount;
        public Staff LoginAccount { get => this.loginAccount; set { this.loginAccount = value;ChangeAccount(LoginAccount.Type); } }

        
        public fHomePage(Staff acc)
        {
            InitializeComponent();
            //LoadPet();
            this.LoginAccount = acc;
            LoadHomePage();
           

        }

        #region Method




        //check role
        void ChangeAccount(int type)
        {
                adminToolStripMenuItem.Enabled = type ==1 ;
                thànhViênToolStripMenuItem.Text += "(" + loginAccount.Displayname + ")";

        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            
            f.ShowDialog();
        }

        void LoadHomePage()
        {

            List<PetCateCus> petList = PetCateCusDAO.Instance.LoadPetList();

            foreach (PetCateCus item in petList)
            {
               
                Button btn = new Button()
                {
                    Width = PetCateCusDAO.TableWidth,
                    Height = PetCateCusDAO.TableHeigh,
                    Text = item.Categorypet + Environment.NewLine + item.Idpetcategory,
                    Tag = item
                };

                
                if (item.Categorypet == "Dog")
                {
                    btn.BackColor = Color.Blue;
                }
                else
                {
                    btn.BackColor = Color.Aqua;
                }
                flpPet.Controls.Add(btn);
            }

            dgvDoanhThu.DataSource = BillDAO.Instance.LoadBill();
        }




        #endregion

        #region Event

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
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.ShowDialog();
        }


        private void takecareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPetService f = new fPetService();
            f.ShowDialog();
        }
        private void petToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPet f = new fPet();
            f.ShowDialog();
        }


        #endregion

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
