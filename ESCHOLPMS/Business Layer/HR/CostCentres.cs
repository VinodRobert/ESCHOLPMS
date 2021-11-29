using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SQLHelper;

/// <summary>
/// Summary description for Clients
/// </summary>
namespace ESCHOLPMS
{
    public class CostCentres
    {

        private Int32 _costCentreCode;

        public Int32 CostCentreCode
        {
            get { return _costCentreCode; }
            set { _costCentreCode = value; }
        }

        int _costCentreIdentifier;
        public int CostCentreIdentifier
        {
            get { return _costCentreIdentifier; }
            set { _costCentreIdentifier = value; }
        }
        string _costCentre;

        public string CostCentre
        {
            get { return _costCentre; }
            set { _costCentre = value; }
        }
        string _shortName;

        public string ShortName
        {
            get { return _shortName; }
            set { _shortName = value; }
        }
        int _parentID;

        public int ParentID
        {
            get { return _parentID; }
            set { _parentID = value; }
        }
        int _editable;

        public int Editable
        {
            get { return _editable; }
            set { _editable = value; }
        }

        private int _pettyCashID;

        public int PettyCashID
        {
            get { return _pettyCashID; }
            set { _pettyCashID = value; }
        }

        private DateTime _lastModified;

        public DateTime LastModified
        {
            get { return _lastModified; }
            set { _lastModified = value; }
        }

        private Int32 _localityID;

        public Int32 LocalityID
        {
            get { return _localityID; }
            set { _localityID = value; }
        }
        private int _subLedgerID;

        public int SubLedgerID
        {
            get { return _subLedgerID; }
            set { _subLedgerID = value; }
        }

        public CostCentres()
        {
            this.Editable = 1;
        }

        public int update()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] parameters = SqlHelper.BindParameters(this, "Accounts.spAddEditCostCentres", _connectionString);
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "Accounts.spAddEditCostCentres", parameters);
            CostCentreCode = Convert.ToInt32(parameters[0].Value);
            return _success;
        }



        public DataSet Fetch(string fieldList, string criteria, string orderby)
        {
            QueryString _qr = new QueryString();

            if (fieldList == null)
                _qr.FieldList = "*";
            else
                _qr.FieldList = fieldList;

            if (criteria == null)
                _qr.Criteria = "1=1";
            else
                _qr.Criteria = criteria;

            if (orderby == null)
                _qr.OrderBy = "Parent,CostCentre";
            else
                _qr.OrderBy = orderby;


            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "Accounts.spSelectCostCentres", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "Accounts.spSelectCostCentres", parameters);
            return ds;
        }


        private DataSet FetchExpenditureSummary()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[Accounts].[spRptCostCentreExpenditure]");
            return ds;
        }

        public DataSet FetchProjectDetails(int _costCentreID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@CostCentreCode", _costCentreID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[Accounts].[spSelectProjectDetailsFromCostCentreCode]",parameters);
            return ds;
        }

        public void Import()
        {
            QueryString _qr = new QueryString();
            _qr.FieldList = " CostCentreCode,CostCentreIdentifier,CostCentre,ShortName,ParentID,Editable,PettyCashID,LastModified,LocalityID,SubLedgerID ";
            _qr.Criteria = "CostCentreCode=" + this.CostCentreCode.ToString();
            _qr.OrderBy = "CostCentreCode";
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "Accounts.spSelectCostCentres", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "Accounts.spSelectCostCentres", parameters);
            ESHCOLPMS.ImportProperty.ImportData(this, ds);
        }

        public DataSet getCostCentreCode(string _criteria)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter parameter = new SqlParameter("@Criteria", _criteria);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[Accounts].[spLoadNextCostCentreIdentifier]", parameter);
            return ds;
        }
    }
}

