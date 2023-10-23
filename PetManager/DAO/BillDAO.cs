using PetManager.DTO;
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


        public void InserBill(int id )
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InserBill @idPet ", new object[] { id });
        }

        public void CheckOut(int id, int discount)
        {
            string query = "UPDATE dbo.Bill SET datecheckout = GETDATE(), Status =1  ," + "discount = "+ discount +"WHERE IdBill = " + id;   
            DataProvider.Instance.ExecuteNonQuery(query);
        }


        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }

        /// <summary>
        /// thanh cong bill id
        /// that bai -1
        /// </summary>
        /// <returns></returns>
        public int GetUnCheckGetBillIdByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable=" + id + " AND status = 0");
            if (data.Rows.Count >0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Idbill;
            }
            return -1;
        }
    }
}
