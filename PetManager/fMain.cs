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
    public partial class fMain : Form
    {
        private Account loginAccount;
        BindingSource petlist = new BindingSource();
        public Account LoginAccount { get => this.loginAccount; set { this.loginAccount = value; ChangeAccount(LoginAccount.Type); } }

        public fMain(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            
        }
        #region Method

        void ChangeAccount(int type)
        {
            tpStaff.Enabled = type == 1;
            tpCustomer.Text += "(" + loginAccount.Displayname + ")";
        }
        #endregion
        #region Event
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }




        

       


        #endregion
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
