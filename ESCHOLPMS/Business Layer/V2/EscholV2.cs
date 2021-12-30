using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;
using System.Data;
using System.Data.SqlClient;

namespace ESCHOLPMS.Business_Layer.V2
{
    class EscholV2
    {
        public DataSet fetchActiveLogins()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "select  EmployeeNumber,EmployeeName from  hr.EmployeeMaster";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int updateLoginDetails(int loginID,string loginName, string password,int loginStatus )
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql1 = "Update LOGINS SET LOGINNAME='" + Convert.ToString(loginName).Trim() + "' WHERE LOGINID='" + Convert.ToString(loginID) + "'";
            string sql2 = "Update LOGINS SET PASSWORD='"+Convert.ToString(password) + "' WHERE LOGINID='" + Convert.ToString(loginID) + "'";
            string sql3 = "UPDATE LOGINS SET STATUS="+Convert.ToString(loginStatus) + "' WHERE LOGINID='" + Convert.ToString(loginID) + "'";
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql1);
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql2);
            int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql3);
            return 1;
        }

        public int addLoginDetails(string userID, string loginName, int loginStatus)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "INSERT INTO LOGINS(USERID,LOGINNAME,PASSWORD,STATUS) VALUES ('" + Convert.ToString(userID).Trim() + "','";
            sql = sql + Convert.ToString(loginName).Trim() + "'," + Convert.ToString(loginStatus) + ")";
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }

        public int deleteLoginDetails(int loginID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "Delete LOGINS WHERE LOGINID=" + Convert.ToString(loginID);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }

        //public int checkDuplicateUserID(string userID)
        //{
        //    string _connectionString = SqlHelper.GetConnectionString();
        //    string sql = "Select isnull(loginID) from Logins"
        //}
    }
}
