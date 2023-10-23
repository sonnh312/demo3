using PetManager.DTO;
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

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> lsBillinfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idBillInfo= " + id);
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                lsBillinfo.Add(info);
            }
            return lsBillinfo;
            
        }

        public void InserBillInfo(int idbill,int idpet, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idbill , @idpet , @count", new object[] { idbill,idpet,count });
        }

        public void DeleteBillInfoById(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("DELETE dbo.Bill WHERE idBillInfo= " + id);
        }

        
    }
}
