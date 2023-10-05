using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win
namespace PetManager.DAO
{
    public class DataProvider
    {
        // add csdl private string connectStr = ;
        public DataTable ExecuteQuery(string query)
        {

            SQlConnection connection = new SQlConnection(connectStr);
            connection.Open();
            string query = "";
            SQLCommand command = new SQLCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(data);
            connection.Close();
            dtgvAccount.DataSource = data;
            
        }

    }
}
