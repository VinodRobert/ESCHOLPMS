using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;

namespace ESCHOLPMS 
{
	public class PRIVATEWORKS
	{

		private int _PRIVATEWORKID;
		public int PRIVATEWORKID
		{
			get { return _PRIVATEWORKID; }
			set { _PRIVATEWORKID = value; }
		}

		private string _WORKSHORTNAME;
		public string WORKSHORTNAME
		{
			get { return _WORKSHORTNAME; }
			set { _WORKSHORTNAME = value; }
		}

		private string _WORKNAME;
		public string WORKNAME
		{
			get { return _WORKNAME; }
			set { _WORKNAME = value; }
		}

		private string _LOCATION;
		public string LOCATION
		{
			get { return _LOCATION; }
			set { _LOCATION = value; }
		}

		private DateTime _STARTDATE;
		public DateTime STARTDATE
		{
			get { return _STARTDATE; }
			set { _STARTDATE = value; }
		}

		private DateTime _ENDDATE;
		public DateTime ENDDATE
		{
			get { return _ENDDATE; }
			set { _ENDDATE = value; }
		}


		public DataSet GetLastTransferID()
        {
			string _connectionString = SqlHelper.GetConnectionString(2);
			string sql = "SELECT ISNULL(MAX(PRIVATETRANSFERID),0) TransferID FROM LOOKUPS ";
			DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
			return ds;
		}

		public void IncrementTransferID()
        {
			string _connectionString = SqlHelper.GetConnectionString(2);
			string sql = "UPDATE LOOKUPS SET PRIVATETRANSFERID=PRIVATETRANSFERID+1 ";
			int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
			return;
		}
		public DataSet Fetch()
        {
			string _connectionString = SqlHelper.GetConnectionString(2);
			string sql = "Select * from PrivateWorks order by location";
			DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
			return ds;
		}

		public void  Issue(int transferID,int privateJobID,DateTime  issueDate, Decimal issueQty, int materialID)
        {
			string _connectionString = SqlHelper.GetConnectionString(2);
			SqlParameter[] parameters = new SqlParameter[5];
			parameters[0] = new SqlParameter("@JOBID",privateJobID);
			parameters[1] = new SqlParameter("@ISSUEDATE", issueDate);
			parameters[2] = new SqlParameter("@MATERIALID", materialID);
		    parameters[3] = new SqlParameter("@ISSUEQTY", issueQty);
			parameters[4] = new SqlParameter("@TRANSFERID", transferID);
			int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "IssueStock", parameters);
		}

		public void Return(int privateJobID, DateTime returnDate, Decimal returnQty, int materialID,int lastTransferID)
		{
			string _connectionString = SqlHelper.GetConnectionString(2);
			SqlParameter[] parameters = new SqlParameter[5];
			parameters[0] = new SqlParameter("@JOBID", privateJobID);
			parameters[1] = new SqlParameter("@RETURNDATE", returnDate);
			parameters[2] = new SqlParameter("@MATERIALID", materialID);
			parameters[3] = new SqlParameter("@RETURNQTY", returnQty);
			parameters[4] = new SqlParameter("@LASTTRANSFERID", lastTransferID);
			int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "ReturnStock", parameters);
		}


		public DataSet getStockIssued(int privateJobID)
		{
			string _connectionString = SqlHelper.GetConnectionString(2);
			SqlParameter[] parameters = new SqlParameter[1];
			parameters[0] = new SqlParameter("@PRIVATEJOB", privateJobID);
			DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "PrivateStockIssued", parameters);
			return ds;

		}

		public DataSet LoadClosingStock()
        {
			string _connectionString = SqlHelper.GetConnectionString(2);
			SqlParameter[] parameters = new SqlParameter[1];
			parameters[0] = new SqlParameter("@STORECODE", 7);
			DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "LiveStock", parameters);
			return ds;

		}
		public void Import()
		{
			string _connectionString = SqlHelper.GetConnectionString(2);
			string sql = "Select * from PrivateWorks order by location";
			DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text,sql);
			ESHCOLPMS.ImportProperty.ImportData(this, ds);
		}
		public int Save()
        {
			 
			string _connectionString = SqlHelper.GetConnectionString(2);
			SqlParameter[] parameters = SqlHelper.BindParameters(this, "spInsertPrivateWorks", _connectionString);
			int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "spInsertPrivateWorks", parameters);
			PRIVATEWORKID = Convert.ToInt32(parameters[0].Value);
			return _success;

		}
	}
}
