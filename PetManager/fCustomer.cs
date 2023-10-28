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
    public partial class fCustomer : Form
    {
        public fCustomer()
        {
            InitializeComponent();
            LoadCus();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        void AddCus(string fullname, string address, int phone)
        {
            if (CustomerDAO.Instance.InsertCus(fullname, address, phone))
            {
                MessageBox.Show("Them khach hang thanh cong");
            }
            else
            {
                MessageBox.Show("them that bai");
            }
            LoadCus();
        }

        void UpdateCus(string fullname, string address, int phone)
        {
            if (CustomerDAO.Instance.UpdateCus(fullname, address, phone))
            {
                MessageBox.Show("Sua khach hang thanh cong");
            }
            else
            {
                MessageBox.Show("sua that bai");
            }
            LoadCus();
        }

        void DeleteCus(string fullname)
        {
            if (CustomerDAO.Instance.DeleteCus(fullname))
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("xoa that bai");
            }
            LoadCus();
        }

        public void LoadCus()
        {
            dgvCus.DataSource = CustomerDAO.Instance.LoadCus();
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            
            string fullname = txtNameCus.Text;
            string address = txtAddressCus.Text;
            int phone = Int32.Parse(txtPhoneCus.Text);
            AddCus(fullname, address, phone);
        }

        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            string fullname = txtNameCus.Text;
            DeleteCus(fullname);
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            
            string fullname = txtNameCus.Text;
            string address = txtAddressCus.Text;
            int phone = Int32.Parse(txtPhoneCus.Text);
            UpdateCus(fullname, address, phone);
        }
    }
}
