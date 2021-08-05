using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;
using System.Data;
using System.Data.SqlClient;
namespace ESCHOLPMS  
{
    public class AMS
    {

        public  DataSet Login(string userName ,string password )
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT * FROM LOGINS WHERE LOGINID='"+Convert.ToString(userName).Trim()+"' AND PASSWORD='"+Convert.ToString(password)+"' AND STATUS=1";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
    }
}
