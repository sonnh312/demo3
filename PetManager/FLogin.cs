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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            string username = txtPass.Text;
            string passwork = txtLogin.Text;
           if(Login(username,passwork)==true)
           {
                
                fPetManager pet = new fPetManager();
                this.Hide();
                pet.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau");
            }
            txtPass.Focus();


        }
        bool Login(string username,string password)
        {

            return AccountDAO.Instance.Login(username,password);
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        