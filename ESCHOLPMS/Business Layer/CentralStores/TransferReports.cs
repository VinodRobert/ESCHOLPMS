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
    public  class TransferReports
    {
		public DataSet getCSTMDetails()
		{
			string _connectionString = SqlHelper.GetConnectionString(3);
			DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "CSTRANSFERREPORT");
			return ds;

		}
		public DataSet getSSTMDetails()
		{
			string _connectionString = SqlHelper.GetConnectionString(3);
			DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[dbo].[STSTRANSFERREPORT]");
			return ds;

		}
		public DataSet getISTMDetails()
		{
			string _connectionString = SqlHelper.GetConnectionString(3);
			DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[dbo].[ISTREPORTCREATION]");
			return ds;

		}


		public DataSet FetchCostCentre()
        {
			string _connectionString = SqlHelper.GetConnectionString(3);
			string sql = "SELECT DISTINCT SR.COSTCENTREID,AC.COSTCENTRE FROM CENTRALSTORES.STOCKREGISTER SR INNER JOIN ACCOUNTS.COSTCENTRES AC ";
			sql = sql + " ON SR.CostCentreID = AC.COSTCENTRECODE ORDER BY COSTCENTRE ";
			DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
			return ds;
		}



		public DataTable FetchYears()
		{
	 
			DateTime dt = DateTime.Now;
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("YearID");
			int currentYear = Convert.ToInt16(dt.Year);
			for (int i = 2017; i <= currentYear; i++)
				dataTable.Rows.Add(i.ToString());
			return dataTable;
		}

		public DataTable FetchMonths()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("MonthID");
			dataTable.Columns.Add("MonthName");
			dataTable.Rows.Add(1, "January");
			dataTable.Rows.Add(2, "February");
			dataTable.Rows.Add(3, "March");
			dataTable.Rows.Add(4, "April");
			dataTable.Rows.Add(5, "May");
			dataTable.Rows.Add(6, "June");
			dataTable.Rows.Add(7, "July");
			dataTable.Rows.Add(8, "August");
			dataTable.Rows.Add(9, "September");
			dataTable.Rows.Add(10, "October");
			dataTable.Rows.Add(11, "November");
			dataTable.Rows.Add(12, "December");

			return dataTable;
		}


		public DataSet  FetchStock(int costCentreID,int  fromYear,int  fromMonth,int  toYear,int  toMonth)
        {
			string _connectionString = SqlHelper.GetConnectionString(3);
			SqlParameter[] arParms = new SqlParameter[5];
			arParms[0] = new SqlParameter("@COSTCENTREID", SqlDbType.Int);
			arParms[0].Value = costCentreID;

			arParms[1] = new SqlParameter("@FromYear", SqlDbType.Int);
			arParms[1].Value = fromYear;

			arParms[2] = new SqlParameter("@FromMonth", SqlDbType.Int);
			arParms[2].Value = fromMonth;

			arParms[3] = new SqlParameter("@ToYear", SqlDbType.Int);
			arParms[3].Value = toYear;

			arParms[4] = new SqlParameter("@ToMonth", SqlDbType.Int);
			arParms[4].Value = toMonth;


			DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "GenerateStockRegister", arParms);
			return ds;

		}

	}
}
