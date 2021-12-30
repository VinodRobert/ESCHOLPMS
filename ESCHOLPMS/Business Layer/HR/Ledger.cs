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
    public class Ledgers
    {
        int _ledgerCode;

        public int LedgerCode
        {
            get { return _ledgerCode; }
            set { _ledgerCode = value; }
        }
        string _ledger;

        public string Ledger
        {
            get { return _ledger; }
            set { _ledger = value; }
        }
        int _ledgerIdentifier;

        public int LedgerIdentifier         
        {
            get { return _ledgerIdentifier; }
            set { _ledgerIdentifier = value; }
        }
        private int _groupID;
        public int GroupID
        {
            get { return _groupID; }
            set { _groupID = value; }
        }
          
        string _openingBalanceDRCR;

        public string OpeningBalanceDRCR
        {
            get { return _openingBalanceDRCR; }
            set { _openingBalanceDRCR = value; }
        } 
        decimal _openingBalance;

        public decimal OpeningBalance
        {
            get { return _openingBalance; }
            set { _openingBalance = value; }
        }

        DateTime _openingBalanceAsOn;

        public DateTime OpeningBalanceAsOn
        {
            get { return _openingBalanceAsOn; }
            set { _openingBalanceAsOn = value; }
        }
        string _accountType;
        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }
        int _controlAccountID;
        public int ControlAccountID
        {
            get { return _controlAccountID; }
            set { _controlAccountID = value; }
        }
        string _ledgerName;
        public string LedgerName
        {
            get { return _ledgerName; }
            set { _ledgerName = value; }
        }
        private int _userID;
        //public int UserID
        //{
        //    get { return _userID; }
        //    set { _userID = Convert.ToInt32(ApplicationSettings._loginUserID); }
        //}

        //public int update()
        //{
        //    string _connectionString = SqlHelper.GetConnectionString();
        //    this.UserID = ApplicationSettings._loginUserID;
        //    SqlParameter[] parameters = SqlHelper.BindParameters(this, "Accounts.spAddEditLedgers", _connectionString);
        //    int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "Accounts.spAddEditLedgers", parameters);
        //    this.LedgerCode = Convert.ToInt32(parameters[0].Value);
        //    return _success;
        //}

        public DataSet Fetch(string _groupName)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter parameter = new SqlParameter("@GroupName",_groupName);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[Accounts].[spGetLedgersUnderGroup]", parameter);
            return ds;
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
                _qr.OrderBy = "GroupName,Ledger";
            else
                _qr.OrderBy = orderby;


            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "Accounts.spSelectLedgers", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "Accounts.spSelectLedgers", parameters);
            return ds;
        }

        public DataSet Fetch(string fieldList, string criteria, string orderby, ref DataSet formDataSet, string dataTableName)
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
                _qr.OrderBy = "GroupName,LEdger";
            else
                _qr.OrderBy = orderby;


            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "Accounts.spSelectLedgers", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "Accounts.spSelectLedgers", parameters);
            DataTable _dt;
            _dt = ds.Tables[0];
            _dt.TableName = dataTableName;
            formDataSet.Tables.Add(_dt.Copy());
            return formDataSet;
        }

        public DataSet FetchControlAccounts(string fieldList, string criteria, string orderby)
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
                _qr.OrderBy = "ControlAccountName";
            else
                _qr.OrderBy = orderby;


            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "Accounts.spSelectControAccount", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "Accounts.spSelectControAccount", parameters);
            return ds;
        }

        public DataSet FetchLedgersUnderSubLedgers(string fieldList, string criteria, string orderby)
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
                _qr.OrderBy = "LedgerIdentifier";
            else
                _qr.OrderBy = orderby;


            string _connectionString = SqlHelper.GetConnectionString(22);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "Accounts.spSelectLedgersUnderSubLedger", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "Accounts.spSelectLedgersUnderSubLedger", parameters);
            return ds;
        }

        public DataSet Fetch()
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.GetConnectionString(2), CommandType.StoredProcedure, "Accounts.spSelectLedgers", new SqlParameter("GroupUnder",this.GroupID));
            return ds;
        }
        
        public decimal getCurrentBalance()
        {
            decimal _cb =Convert.ToDecimal( SqlHelper.ExecuteScalar(SqlHelper.GetConnectionString(2), CommandType.StoredProcedure, "Accounts.spSelectLedgerCurrentBalance", new SqlParameter("LedgerCode", this.LedgerCode)));
            return _cb;
        }

        public string  getLedgerCategory()
        {
            string _lc = Convert.ToString(SqlHelper.ExecuteScalar(SqlHelper.GetConnectionString(2), CommandType.StoredProcedure, "[Accounts].[spLedgerCategory]", new SqlParameter("LedgerCode", this.LedgerCode)));
            return _lc;
        }

        public Decimal getOpeningBalanceAsOn(int _ledgerID, DateTime _currentDate)
        {
            SqlParameter[] parameters = new  SqlParameter[2];
            parameters[0] = new SqlParameter("@LedgerCode", _ledgerID);
            parameters[1] = new SqlParameter("@StartDate", _currentDate);
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[Accounts].[spSelectLedgersOpeningBalanceAsOn]", parameters);
            return Convert.ToDecimal(ds.Tables[0].Rows[0]["OpeningBalance"]);
        }
        public void Import()
        {
            QueryString _qr = new QueryString();
            _qr.FieldList = " LedgerCode,Ledger,LedgerIdentifier,GroupID,OpeningBalance,OpeningBalanceDRCR,OpeningBalanceAsOn,AccountType,ControlAccountID,LedgerName";
            _qr.Criteria = "LedgerCode=" + this.LedgerCode.ToString();
            _qr.OrderBy = "LedgerCode";
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "Accounts.spSelectLedgers", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "Accounts.spSelectLedgers", parameters);
            ESHCOLPMS.ImportProperty.ImportData(this, ds);
        }

        public DataSet getTransactions(int _ledgerID, DateTime _currentDate)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@LedgerCode", _ledgerID);
            parameters[1] = new SqlParameter("@StartDate", _currentDate);
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[Accounts].[spSelectLedgerTransactionsOn]", parameters);
            return ds;
        }

        public DataSet getPettyCashAccounts()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "accounts.spFetchPettyCashLedgers");
            return ds;
        }
        public DataSet FetchOpening()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[ACCOUNTS].[spRptLedgerOpeningBalance]");
            return ds;
        }

        public DataSet getBankLedgers()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "accounts.spFetchBanks");
            return ds;
        }

        public DataSet getNonBankCashLedgers()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[Accounts].[spNonBankCashLedgers]");
            return ds;
        }
        
        public DataSet getBankCashLedgers()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "accounts.spFetchBankAndCashLedgers");
            return ds;
        }

        public DataSet FetchLedgerGroup(string fieldList, string criteria, string orderby)
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
                _qr.OrderBy = "GroupName";
            else
                _qr.OrderBy = orderby;


            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "[Accounts].[spSelectLedgerGroups]", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[Accounts].[spSelectLedgerGroups]", parameters);
            return ds;
        }

        public DataSet FetchContraLedgers(string fieldList, string criteria, string orderby)
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
                _qr.OrderBy = "GroupName,LEdger";
            else
                _qr.OrderBy = orderby;


            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "Accounts.spSelectContraLedgers", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "Accounts.spSelectContraLedgers", parameters);
            return ds;
        }


        public DataSet FetchPettyCashLedgers(string fieldList, string criteria, string orderby)
        {
            QueryString _qr = new QueryString();

            if (fieldList == null)
                _qr.FieldList = "*";
            else
                _qr.FieldList = fieldList;

            if (criteria == null)
                _qr .Criteria = "1=1";
            else
                _qr.Criteria = criteria;

            if (orderby == null)
                _qr.OrderBy = "GroupName,LEdger";
            else
                _qr.OrderBy = orderby;


            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "Accounts.spSelectPettyCashLedgers", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "Accounts.spSelectPettyCashLedgers", parameters);
            return ds;
        }
        public DataSet getAccountCode(string _criteria)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter parameter = new SqlParameter("@Criteria", _criteria);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[Accounts].[spLoadNextLedgerIdentifier]", parameter);
            return ds;
        }

        
    }
}
