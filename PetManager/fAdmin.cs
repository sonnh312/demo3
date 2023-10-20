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

namespace PetManager
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadListAccount();
            LoadListAccount();

        }
        #region Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem itempet = new System.Windows.Forms.ListViewItem(new string[] { txtIDpet.Text, txtNamepet.Text, txtKindpet.Text, txtStatuspet.Text });
            lvPet.Items.Add(itempet);
            txtIDpet.Text = "";
            txtKindpet.Text = "";
            txtNamepet.Text = "";
            txtStatuspet.Text = "";
            txtIDpet.Focus();
        }

         //public void ResetInput()
        //{
            
        //}

        private void lvPet_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem item;
            item = e.Item;
            txtIDpet.Text = item.Text;
            txtNamepet.Text = item.SubItems[1].Text;
            txtKindpet.Text = item.SubItems[2].Text;
            txtStatuspet.Text = item.SubItems[3].Text;
            
            

        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            //item = 
            //ResetInput();
            txtIDpet.Focus();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int total = lvPet.Items.Count;
            for (int i = 0; i < total; i++)
            {
                if (lvPet.Items[i].Text == txtIDpet.Text)
                {
                    lvPet.Items[i].SubItems[1].Text = txtNamepet.Text;
                    lvPet.Items[i].SubItems[2].Text = txtKindpet.Text;
                    lvPet.Items[i].SubItems[3].Text = txtStatuspet.Text;
                    return;
                }
            }
        }
        #endregion
        #region Method
        public void LoadListAccount()
        {
            string query = "EXECUTE getAccountByUserName @username";
            DataProvider provider = new DataProvider();

            dtgvAccount.DataSource = provider.ExecuteQuery(query, new object[] { "hoangson" });

        }

        private void LoadQuestionType()
        {
            // tao list do du lieu vao chinh display member and value member
            //List<QuestionType>
              //  list = 
        }


        #endregion
    }
}
