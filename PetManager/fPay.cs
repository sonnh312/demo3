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

namespace PetManager
{
    public partial class fPay : Form
    {

        BindingSource dataToDisplay = new BindingSource();
        
        public fPay()
        {
            InitializeComponent();
            LoadListPet();
            LoadCus();
            LoadPet();
            dgvHistoryBill.DataSource = dataToDisplay;
        }

        #region Method
       

         void LoadDataToListView()
        {
            // Get selected customer
            CusPay selectedCustomer = (CusPay)cbIdCus.SelectedItem;
            string customerName = selectedCustomer.Fullname;

            // Get selected pet
            Pet selectedPet = (Pet)cbPetName.SelectedItem;
            string petName = selectedPet.Namepet;
            int price = selectedPet.Price;

            // Get Count and calculate TotalPrice
            int count = (int)nmCount.Value;
            int totalPrice = count * price;

            // Add data to ListView
            ListViewItem lvItem = new ListViewItem(customerName);
            lvItem.SubItems.Add(petName);
            lvItem.SubItems.Add(price.ToString());
            lvItem.SubItems.Add(count.ToString());
            lvItem.SubItems.Add(totalPrice.ToString());

            lvBill.Items.Add(lvItem);

            // Update total price
            int currentTotalPrice = int.Parse(txtTotalPrice.Text);
            txtTotalPrice.Text = (currentTotalPrice + totalPrice).ToString();
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTotalPrice.Text = totalPrice.ToString("c", culture);
        }


        void LoadCus()
        {
            List<CusPay> listId = CusPayDAO.Instance.GetListId();
            cbIdCus.DataSource = listId;
            cbIdCus.DisplayMember = "FullName"; 

         
            cbIdCus.SelectedIndexChanged += (sender, e) =>
            {
                if (cbIdCus.SelectedIndex >= 0)
                {
                    CusPay selectedCustomer = (CusPay)cbIdCus.SelectedItem;
                    txtCusName.Text = selectedCustomer.Idcus.ToString();
                }
            };
        }

        void LoadPet()
        {
            List<PetCus> listName = PetCusDAO.Instance.GetPetName();
            cbPetName.DataSource = listName;
            cbPetName.DisplayMember = "NamePet";

            cbPetName.SelectedIndexChanged += (sender, e) =>
            {
                if (cbPetName.SelectedIndex >= 0)
                {
                    PetCus selectedCustomer = (PetCus)cbPetName.SelectedItem;
                    txtPrice.Text = selectedCustomer.Price.ToString();
                }
            };
        }

        
        

        private void AddToBill()
        {
            
            CusPay selectedCustomer = (CusPay)cbIdCus.SelectedItem;
            string customerName = selectedCustomer.Fullname;

            PetCus selectedPet = (PetCus)cbPetName.SelectedItem;
            string petName = selectedPet.Namepet;
            int price = selectedPet.Price;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(petName))
            {
                //customer or pet names are empty
                MessageBox.Show("Customer or pet names cannot be empty.");
                return;
            };

            int count = (int)nmCount.Value;
            int totalPrice = count * price;

            ListViewItem lvItem = new ListViewItem(customerName);
            lvItem.SubItems.Add(petName);
            lvItem.SubItems.Add(price.ToString());
            lvItem.SubItems.Add(count.ToString());
            lvItem.SubItems.Add(totalPrice.ToString());

            lvBill.Items.Add(lvItem);

            int currentTotalPrice = 0;
            if (!string.IsNullOrEmpty(txtTotalPrice.Text))
            {
                currentTotalPrice = int.Parse(txtTotalPrice.Text);
            }
            txtTotalPrice.Text = (currentTotalPrice + totalPrice).ToString();

            // Clear after adding to the bill
            cbIdCus.SelectedIndex = -1;
            cbPetName.SelectedIndex = -1;
            txtCusName.Text = "";
            txtPrice.Text = "";
            nmCount.Value = 0;
        }


        void LoadPetIntoCb(ComboBox cb)
        {
            cbIdCus.DataSource = CustomerDAO.Instance.LoadCus();
            cbIdCus.DisplayMember = "IdCus";
        }
        

        void LoadListPet()
        {

            List<Pet> list = new List<Pet>();
            dgvPetList.DataSource = PetDAO.Instance.LoadPetListToDesign();

        }

        void LoadBill()
        {
            // Create a DataTable to store bill records
            DataTable dt = new DataTable();
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("NamePet", typeof(string));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("Count", typeof(int));
            dt.Columns.Add("TotalPrice", typeof(int));

            int total = 0;

            foreach (ListViewItem item in lvBill.Items)
            {
                string namecus = item.SubItems[0].Text;
                string namepet = item.SubItems[1].Text;
                int price = int.Parse(item.SubItems[2].Text);
                int count = int.Parse(item.SubItems[3].Text);
                int totalPrice = int.Parse(item.SubItems[4].Text);

                // Add the data to the DataTable
                dt.Rows.Add(namecus, namepet, price, count, totalPrice);

                // Update the total
                total += totalPrice;
            }

            // Set the DataTable as the DataSource for dgvHistoryBill
            dgvHistoryBill.DataSource = dt;

            // Update the total price textbox
            txtTotalPrice.Text = total.ToString();
        }







        #endregion





        #region Event

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            LoadBill();
            lvBill.Items.Clear();
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            AddToBill();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvBill.Items.Clear();
        }

    
        #endregion









        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
