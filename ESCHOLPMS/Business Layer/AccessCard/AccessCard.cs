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
    public  class AccessCard
    {
        public DataSet FetchAccessHistory(Int32 accessPointID,String dtTimeSheet)
        {
            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@ACCESSPOINTID", SqlDbType.BigInt);
            arParms[0].Value = accessPointID;
            arParms[1] = new SqlParameter("@TIMESHEETDATESTRING", SqlDbType.Text);
            arParms[1].Value = dtTimeSheet;
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[spExtractTimeSheet]", arParms);
            return ds;
        }
        public int AssignCardToUser(Int64 spintlyUserID,string  accessCardNumber)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql0 = "update AccessCard set status=1,custodian=" + Convert.ToString(spintlyUserID) + " where cardNumber='" + Convert.ToString(accessCardNumber).Trim() + "'";
            string sql1 = "Update LabourDetails set AccessCardNumber='" + Convert.ToString(accessCardNumber) + "' where spintlyUserID=" + Convert.ToString(spintlyUserID);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql0);
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql1);
            return 0;
        }
        public void DamageAccessCard(string accessCardNumber)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "Update AccessCard Set Status=2 where cardnumber=" + Convert.ToString(accessCardNumber);
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
        }
        public void TerminateWorker(int spintlyUserID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql0 = "UPDATE LABOURDETAILS SET ACCESSCARDNUMBER=-1, STATUSID=9,STATUS='Terminate From Project' WHERE SPINTLYUSERID=" + Convert.ToString(spintlyUserID);
            int j = SqlHelper.ExecuteNonQuery(_connectionString,CommandType.Text, sql0);
            string sql1 = "Update ACCESSCARD SET CUSTODIAN=0,STATUS=0 WHERE CUSTODIAN=" + Convert.ToString(spintlyUserID);
            int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql1);
        }
        public DataSet GetCardDetailsForAssign(string cardNumber, int costCentreID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT  A.CARDNUMBER  ";
            sql = sql + " FROM ACCESSCARD A  ";
            sql = sql + " WHERE A.COSTCENTREID = " + Convert.ToString(costCentreID) + " AND A.CARDNUMBER='" + Convert.ToString(cardNumber) + "' AND A.STATUS=0";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet GetCardDetails(string cardNumber,int costCentreID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT L.LABOURID, L.SPINTLYUSERID,A.CARDNUMBER,L.LABOURROLLNO WORKERNUMBER,LABOURNAME WORKERNAME,CASE WHEN A.STATUS=0 THEN 'Free' WHEN A.STATUS=1 THEN 'Active' WHEN A.STATUS=2 THEN 'Bad' END AS STATUS ";
            sql = sql + " FROM ACCESSCARD A LEFT OUTER JOIN LABOURDETAILS L ON A.CUSTODIAN = L.SPINTLYUSERID ";
            sql = sql + " WHERE A.COSTCENTREID = " + Convert.ToString(costCentreID) + " AND A.CARDNUMBER='"+Convert.ToString(cardNumber)+"' AND A.STATUS=1";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet ListOfAccessCard(int costCentreID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT L.SPINTLYUSERID,A.CARDNUMBER,L.LABOURROLLNO WORKERNUMBER,LABOURNAME WORKERNAME,CASE WHEN A.STATUS=0 THEN 'Free' WHEN  A.STATUS=1 THEN 'Active' WHEN A.STATUS=2 THEN 'Bad' END AS STATUS ";
            sql = sql + " FROM ACCESSCARD A INNER JOIN LABOURDETAILS L ON A.CUSTODIAN = L.SPINTLYUSERID ";
            sql = sql + " WHERE A.COSTCENTREID = " + Convert.ToString(costCentreID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet ValidateCardForUnAssign(Int64 cardNumber,int projectID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT ISNULL(MAX(PRIVATETRANSFERID),0) TransferID FROM LOOKUPS ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
    }
}
