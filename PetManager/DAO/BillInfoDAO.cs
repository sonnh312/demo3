using PetManager.DTOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PetManager.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        { get { if (instance == null) instance = new BillInfoDAO();return BillInfoDAO.instance       ; }
           private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO()
        {

        }

        public List<BillInfo> GetListBillInfo()
        {
            List<BillInfo> lsBillinfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill=" + iD);
            foreach(DataRow in item data.Rows)
               {
                BillInfo info = new BillInfo();
                lsBillinfo.Add(info);
            }




            return List<BillInfo>;
            
        }
    }
}
