using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using SQLHelper;
using System.Data.SqlClient;

namespace ESCHOLPMS 
{
    class General
    {

        public int CreateNewLogin(string loginName,int  roleID, int siteID,int  companyID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] arParms = new SqlParameter[4];
            arParms[0] = new SqlParameter("USERNAME", SqlDbType.Text);
            arParms[0].Value = loginName;
            arParms[1] = new SqlParameter("ROLEID", SqlDbType.Int);
            arParms[1].Value = roleID;

            arParms[2] = new SqlParameter("SITEID", SqlDbType.Int);
            arParms[2].Value = siteID;
            arParms[3] = new SqlParameter("COMPANYID", SqlDbType.Int);
            arParms[3].Value = companyID;

            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "[spNewLogin]", arParms);
            return 1;


        }
        public DataSet FetchListofCompany()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT COMPANYCODE,COMPANYNAME  FROM EXT.CONNECTIONSTRING WHERE COMPANYCODE IN (18,21) ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text,sql);
            return ds;
        }

        public DataSet FetchListofSites(int companyID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql;
            if (companyID == 18)
                sql = "SELECT COSTCENTREID,UPPER(PROJECTNAME) PROJECTNAME FROM EXT.PROJECTS WHERE PROJECTSTATUS='Open'  ORDER BY PROJECTNAME  ";
            else
                sql = "SELECT COSTCENTREID,UPPER(PROJECTNAME) PROJECTNAME FROM EXT.PROJECTSPERSONAL WHERE PROJECTSTATUS='Open'  ORDER BY PROJECTNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet FetchListofLoginRoles()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT USERROLECODE,UPPER(ROLENAME) ROLENAME   FROM EXT.USERROLES ORDER BY ROLENAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchListofProjects()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[spListOfProjects]");
            return ds;
        }
        public DataSet FetchEshcolLogins()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[spEshcolLoginUsers]");
            return ds;
        }
        public DataSet FetchSubContractorsAndLabours()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[spContractorLabourDetails]");
            return ds;
        }
    }
}
