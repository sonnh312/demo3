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
    public partial class fAccountProfile : Form
    {
        public fAccountProfile(Staff acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            
        }

        private Staff loginAccount;
        public Staff LoginAccount { get => this.loginAccount; set { this.loginAccount = value; ChangeAccount(LoginAccount); } }

        public void ChangeAccount(Staff acc)
        {
            txtUsername.Text = LoginAccount.Username;
            txtDisplayName.Text = LoginAccount.Displayname;
            txtNameStaff.Text = LoginAccount.Displayname;
            txtPhone.Text = LoginAccount.Phone.ToString();
            txtAddress.Text = LoginAccount.Address;
            dtpBirthday.Value = LoginAccount.Birthday.Value;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }


        public void UpdateAccountInfo()
        {
            string displayname = txtDisplayName.Text;
            string password = txtPassword.Text; 
            string newpassword = txtNewPassword.Text;
            string reenterpassword = txtReEnterPass.Text;
            string username = txtUsername.Text;

            if(!newpassword.Equals(reenterpassword))
            {
                MessageBox.Show("Vui lòng nhập 2 mật khẩu giống nhau");
            }
            // event bac 2
            else
            {
                if(StaffDAO.Instance.UpdateAccount(username,displayname,password,newpassword))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if(updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(StaffDAO.Instance.GetAccountByUserName(username)));
                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu");
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        public class AccountEvent:EventArgs
        {
            private Staff acc;

            public Staff Acc { get => acc; set => acc = value; }

            public AccountEvent(Staff acc)
            {
                this.Acc = acc;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }


        
        public void UpdateInfo()
        {
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            DateTime birthday = dtpBirthday.Value;

            if (StaffDAO.Instance.UpdateInfo(phone, address, birthday))
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
                MessageBox.Show("Cap nhat that bai");
        }

    }
}
