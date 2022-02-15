using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using SQLHelper;
using System.Data;

namespace ESCHOLPMS.Business_Layer.MIS
{
    class MIS
    {
        public DataSet FetchActiveProjects()
        {
            string _connectionString = SqlHelper.GetConnectionString(1);
            string sql = "SELECT COSTCENTREID,PROJECTNAME FROM PROJECTS.PROJECTS WHERE PROJECTSTATUS='Open' ORDER BY PROJECTNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchClientBills(int costCentreID)
        {
            string _connectionString = SqlHelper.GetConnectionString(1);
            string sql = "SELECT CLIENTBILLHEADERCODE, BILLNUMBER FROM PROJECTS.CLIENTBILLHEADER WHERE COSTCENTREID= ";
            sql = sql + Convert.ToString(costCentreID) + "  ORDER BY BILLSERIALNO DESC ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet LoadReports()
        {
            string _connectionString = SqlHelper.GetConnectionString(1);
            string sql = "SELECT 1 AS REPORTID,'Mesuarement Book-General'     REPORTNAME UNION   ";
            sql =  sql + "SELECT 2 AS REPORTID,'Measurement Book-Tripizoidal' REPORTNAME UNION   ";
            sql =  sql + "SELECT 3 AS REPORTID,'Measurement Book-Steel'       REPORTNAME UNION   ";
            sql =  sql + "SELECT 4 AS REPORTID,'Cumulative Bill Abstract'     REPORTNAME UNION   ";
            sql =  sql + "SELECT 5 AS REPORTID,'Additions/Deductions Report'  REPORTNAME UNION   ";
            sql =  sql + "SELECT 6 AS REPORTID,'Comparative Statement'        REPORTNAME UNION   ";
            sql =  sql + "SELECT 7 AS REPORTID,'BOQ Details'                  REPORTNAME    ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GenerateMeasurementBookGeneral(int clientBillID,int measurementType)
        {
            string _connectionString = SqlHelper.GetConnectionString(1);
            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@CLIENTBILLID", SqlDbType.Int);
            arParms[0].Value = Convert.ToInt16(clientBillID);
            arParms[1] = new SqlParameter("@MEASUREMENTTYPE", SqlDbType.Int);
            arParms[1].Value = measurementType;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[MIS].[spSelectClientBillMeasurements]", arParms);
            return ds;
        }
    }
}
