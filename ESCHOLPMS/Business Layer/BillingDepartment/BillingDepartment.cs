using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SQLHelper;
using System.Data.SqlClient;

namespace ESCHOLPMS 
{
    public  class BillingDepartment
    {
        public DataSet FetchLinkedAccounts()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[ext].[LinkedAccounts]");
            return ds;
        }

        public DataSet FetchProjectsHavingBOQUploaded()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT P.COSTCENTREID,P.PROJECTNAME FROM EXT.PROJECTS P WHERE COSTCENTREID IN(";
            sql = sql + "SELECT DISTINCT COSTCENTREID FROM EXT.SCHEDULENEW) ORDER BY PROJECTNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet FetchWBSLoaded(int costCentredID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@COSTCENTREID", costCentredID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "EXT.spFetchWBS_2000", parameters);
            return ds;
        }

        public void UpdateDisplayOrder(Int32 scheduleCode,decimal originalNo,decimal newNo)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            String sql = "Update ext.ScheduleNew set NewDisplayOrder=" + Convert.ToString(newNo) + "  Where SCHEDULECODE=" + Convert.ToString(scheduleCode);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return;
        }
    }
}
