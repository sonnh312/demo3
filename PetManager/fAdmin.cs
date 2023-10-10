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

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
        

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lvPet.Columns.Add("ID");
                lvPet.Columns.Add("Tên");
                lvPet.Columns.Add("Loại");
                lvPet.Columns.Add("Trạng thái");
            
                ListViewItem itempet = new System.Windows.Forms.ListViewItem(new string[] { txtIDpet.Text, txtNamepet.Text, txtKindpet.Text, txtStatuspet.Text });
                lvPet.Items.Add(itempet);
            }
            catch { }
        }

        private void lvPet_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }
        public void LoadListAccount()
        {
            string query = "EXECUTE getAccountByUserName @username";
            DataProvider provider = new DataProvider();

            dtgvAccount.DataSource = provider.ExecuteQuery(query, new object[] {"hoangson"});

        }
    }
}
