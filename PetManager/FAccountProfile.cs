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
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            
        }

        private Account loginAccount;
        public Account LoginAccount { get => this.loginAccount; set { this.loginAccount = value; ChangeAccount(LoginAccount); } }

        public void ChangeAccount(Account acc)
        {
            txtUsername.Text = LoginAccount.Username;
            txtDisplayName.Text = LoginAccount.Displayname;
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
                MessageBox.Show("Vui long nhap lai mat khau moi");
            }
            // event bac 2
            else
            {
                if(AccountDAO.Instance.UpdateAccount(username,displayname,password,newpassword))
                {
                    MessageBox.Show("Cap nhat thanh cong");
                    if(updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(username)));
                    }
                }
                else
                    MessageBox.Show("Vui long nhap dung mat khau");
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
            private Account acc;

            public Account Acc { get => acc; set => acc = value; }

            public AccountEvent(Account acc)
            {
                this.Acc = acc;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
