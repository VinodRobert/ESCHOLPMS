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
    class Accounts
    {
        public DataSet fetchLastFinYears()
        {
            string _connectionString = SqlHelper.GetConnectionString(4);
            string sql = "SELECT FINYEAR FROM ESHCOL.FINANCIALYEAR  ";
            sql = sql + " WHERE FINYEAR>= (SELECT FINYEAR - 2 FROM ESHCOL.FINANCIALYEAR WHERE ACTIVE = 1) ORDER BY FINYEAR ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchExistingLedgers(Int16 finYear)
        {
            string _connectionString = SqlHelper.GetConnectionString(3);
            string sql = "SELECT LEDGERCODE,LTRIM(STR(LEDGERIDENTIFIER))+ ' - ' + UPPER(LEDGER) LEDGER ";
            sql = sql + " FROM ACCOUNTS.LEDGERS WHERE CONTROLACCOUNTID<>0 AND ";
            sql = sql + " LEDGERCODE IN (SELECT LEDGERID FROM ACCOUNTS.LEDGERSANDSUBLEDGERSOPENINGANDCLOSING WHERE FINYEAR= ";
            sql = sql + Convert.ToString(finYear) + " ) ORDER BY LEDGERIDENTIFIER ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public Int32 fetchControlAccountCode(Int32 ledgerCode)
        {
            string _connectionString = SqlHelper.GetConnectionString(3);
            string sql = "SELECT ISNULL(CONTROLACCOUNTID,0) CONTROLACCOUNT FROM ACCOUNTS.LEDGERS where ledgercode=" + Convert.ToString(ledgerCode);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            Int32 controlAccountCode = Convert.ToInt32(ds.Tables[0].Rows[0]["CONTROLACCOUNT"]);
            return controlAccountCode;
        }

        public DataSet fetchSubLedgersOfControlAccount(Int32 controlAccountCode,int finYear)
        {
            string _connectionString = SqlHelper.GetConnectionString(3);
            string sql = "SELECT SUBLEDGERCODE,UPPER(SUBLEDGER) SUBLEDGER ";
            sql = sql + " FROM ACCOUNTS.SUBLEDGERS WHERE CONTROLACCOUNTID = " + Convert.ToString(controlAccountCode);
            sql = sql + " AND SUBLEDGERCODE NOT IN(SELECT SUBLEDGERID FROM ACCOUNTS.LedgersAndSubLedgersOpeningAndClosing WHERE FINYEAR= ";
            sql = sql + Convert.ToString(finYear) + " )    ORDER BY SUBLEDGER ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
           return ds;
        }

        public int addLedgerSubLedgerForOB(Int32 ledgerCode, Int32 subLedgerCode, int finYear)
        {
            string _connectionString = SqlHelper.GetConnectionString(3);
            SqlParameter[] arParms = new SqlParameter[3];
            arParms[0] = new SqlParameter("@LEDGERCODE", SqlDbType.BigInt);
            arParms[0].Value = ledgerCode;
            arParms[1] = new SqlParameter("@SUBLEDGERCODE", SqlDbType.BigInt);
            arParms[1].Value = subLedgerCode;
            arParms[2] = new SqlParameter("@FINYEAR", SqlDbType.Int);
            arParms[2].Value = finYear;
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "[EXT].[spAddLedgerSubLedgerOB]", arParms);
            return 1;
        }

        public DataSet FetchMissingLedgers(Int16 finYear)
        {
            string _connectionString = SqlHelper.GetConnectionString(3);
            string sql = "SELECT LEDGERCODE,LTRIM(STR(LEDGERIDENTIFIER)) + ' - ' + UPPER(LEDGER) LEDGER ";
            sql = sql + " FROM ACCOUNTS.LEDGERS WHERE CONTROLACCOUNTID=0 AND ";
            sql = sql + " LEDGERCODE NOT IN (SELECT LEDGERID FROM ACCOUNTS.LEDGERSANDSUBLEDGERSOPENINGANDCLOSING WHERE FINYEAR= ";
            sql = sql + Convert.ToString(finYear) + " )  ORDER BY LEDGERIDENTIFIER ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet fetchLedgersSubLedgersForOB(Int16 finYear)
        {
            string _connectionString = SqlHelper.GetConnectionString(3);
            string sql = " SELECT L.LedgerIdentifier LEDGERID, UPPER(L.LEDGER) LEDGER, O.SUBLEDGERID , UPPER(SL.SUBLEDGER) SUBLEDGER ";
            sql = sql + " FROM ACCOUNTS.LedgersAndSubLedgersOpeningAndClosing O ";
            sql = sql + " INNER JOIN ACCOUNTS.LEDGERS L ON O.LEDGERID = L.LEDGERCODE ";
            sql = sql + " LEFT OUTER JOIN ACCOUNTS.SUBLEDGERS SL ON O.SUBLEDGERID = SL.SUBLEDGERCODE ";
            sql = sql + " WHERE O.FINYEAR = " + Convert.ToString(finYear);
            sql = sql + " ORDER BY LEDGER, SUBLEDGER  ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet fetchLedgerIDWhichIsZero()
        {
            string _connectionString = SqlHelper.GetConnectionString(3);
            string sql = "SELECT FINYEAR, GROUPINDEX, TRANSACTIONDATE, TRANSACTIONTYPEID, LEDGERID, DEBITAMOUNT, CREDITAMOUNT ";
            sql = sql + " FROM ACCOUNTS.TRANSACTIONS WHERE LEDGERID = 0 ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet fetchOutofBalanceGroups(Int16 finYear)
        {
            string _connectionString = SqlHelper.GetConnectionString(3);
            string sql = "SELECT TRANSACTIONTYPEID, GROUPINDEX, SUM(DEBITAMOUNT - CREDITAMOUNT) BALANCE ";
            sql = sql + " FROM ACCOUNTS.TRANSACTIONS WHERE FINYEAR = " + Convert.ToString(finYear);
            sql = sql + " GROUP BY TRANSACTIONTYPEID, GROUPINDEX  HAVING SUM(DEBITAMOUNT - CREDITAMOUNT) <> 0 ";
            sql = sql + " ORDER BY TRANSACTIONTYPEID,GROUPINDEX ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet fetchSingleTransactionGroup(Int64 groupIndexID)
        {
            string _connectionString = SqlHelper.GetConnectionString(3);
            string sql = "SELECT T.TRANSACTIONCODE RowID,VT.VoucherType,L.LEDGER Ledger,T.DEBITAMOUNT Debit,T.CREDITAMOUNT Credit,0 AS EDITSTATUS ";
            sql = sql + " FROM ACCOUNTS.TRANSACTIONS T INNER JOIN ACCOUNTS.LEDGERS L ON T.LEDGERID = L.LEDGERCODE ";
            sql = sql + " INNER JOIN ACCOUNTS.VoucherTypeLookUp VT ON T.TransactionTypeID = VT.VoucherPrefix ";
            sql = sql + " WHERE T.GROUPINDEX = " + Convert.ToString(groupIndexID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int  updateTransactions(Int64 transactionCode,decimal debitAmount, decimal creditAmount)
        {
            string _connectionString = SqlHelper.GetConnectionString(3);
            string sql = "Update ACCOUNTS.TRANSACTIONS SET DebitAmount=" + Convert.ToString(debitAmount) + " , ";
            sql = sql + " CreditAmount = " + Convert.ToString(creditAmount) + " where transactionCode=" + Convert.ToString(transactionCode);
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }

    }
}
