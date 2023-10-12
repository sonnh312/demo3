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
    public partial class fPetManager : Form
    {
        private Account loginAccount;
        public List<BillInfo> GetListBillInfo { get; private set; }
        public Account LoginAccount { get => loginAccount; set => loginAccount = value; }

        public fPetManager()
        {
            InitializeComponent();
            //LoadTableIm();
        }
        #region Method

        public void LoadTableIm()
        {
            try
            {
                List<Table> tablelist = TableDAO.Instance.LoadTableList();
                foreach (Table item in tablelist)
                {
                    Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                    //btn.Text = item.Name + Environment.NewLine + item.Status;

                    //btn.Tag = item;
                    flpPet.Controls.Add(btn);
                }
            }
            catch ( Exception)
            {
               
                //log
            }

            
        }
        void ShowBill(int id)
        {
            List<BillInfo> lsBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUnCheckGetBillIdByTableId(id));
            


        }

        void ChangeAccount(int type)
        {
            
        }

        #endregion

        #region Event
        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAccountProfile f = new FAccountProfile();
            f.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FLogin f = new FLogin();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hotlineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }

}
