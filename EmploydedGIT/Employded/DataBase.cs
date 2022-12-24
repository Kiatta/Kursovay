using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Employded
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-8MJSR08\SQLEXPRESS01; Initial Catalog = Employes_View; Integrated Security =  True");
        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed) {
                sqlConnection.Open();
            }
            
        }
        public void closeConnection() 
        { 
            if (sqlConnection.State!= System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            
            return sqlConnection;
        }
    }

}
