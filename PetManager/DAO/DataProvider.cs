using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace PetManager.DAO
{
    public class DataProvider
    {
        string connectStr = "Data Source=LAPTOP-ISEILDT0;Initial Catalog=PetManager;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectStr);
        connection.Open();
            DataTable data = new DataTable();
        string query = "SELECT * FROM Account";

        SqlCommand command = new SqlCommand(query, connection);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        adapter.Fill(data);
        connection.Close();
        
    }
}
