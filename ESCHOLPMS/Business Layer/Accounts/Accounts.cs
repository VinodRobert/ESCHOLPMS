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
