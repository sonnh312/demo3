using PetManager.DTOO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        { get { if (instance == null) instance = new BillDAO();return BillDAO.instance;     }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }

        /// <summary>
        /// thanh cong bill id
        /// that bai -1
        /// </summary>
        /// <returns></returns>
        public int UnCheckGetBillIdByTableId()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE iDTable=" +id+" AND status = 0     ")
            if (data.Rows.Count >0)
            {
                BillInfo bill = new BillInfo(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
    }
}
