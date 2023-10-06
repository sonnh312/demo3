using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetManager.DAO
{
    public class DataProvider
    {
        //using singleton to use just one time only 1 string to connect database
        private static DataProvider instance;

        private string connectionSTR = "Data Source=LAPTOP-ISEILDT0;Initial Catalog=PetManager;Integrated Security=True";
        public static DataProvider Instance
        { get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; } }

        //user couldn't access to 
        private DataProvider() { }


        public int ExecuteNonQuery(string query,object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //to multi query by exec to parameter
                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach(string item in listParameter)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                data = command.ExecuteNonQuery();

                connection.Close();
                
            }
            //return number of row susscess
            return data;
        }
        
        

    }
}
