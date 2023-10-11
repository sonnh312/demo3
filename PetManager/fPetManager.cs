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
        public List<BillInfo> GetListBillInfo { get; private set; }

        public fPetManager()
        {
            InitializeComponent();
            LoadTable();
        }
        #region method
        void LoadTable()
        {
            List<Table> tablelist =  TableDAO.Instance.LoadTableList(); 
            foreach(Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += BtnClick;
                btn.Tag = item;
                flpTable.Controls.Add(btn); 
            }
        }
        void ShowBill(int id)
        {
            List<BillInfo> lsBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUnCheckGetBillIdByTableId(id));
            


        }

        #endregion

        #region Event
        void BtnClick(object sender, EventArgs e)
        {
            int tableID = (sender as Table).ID;
            ShowBill(tableID);
        }   


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
        #endregion
    }
}
