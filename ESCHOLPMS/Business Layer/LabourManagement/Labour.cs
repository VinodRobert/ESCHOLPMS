using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SQLHelper;

namespace ESCHOLPMS 
{
    class Labour
    {

        public DataSet FetchAccessCards(int costCentre)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT  CARDNUMBER  FROM ACCESSCARD where status=0 and COSTCENTREID= ";
            sql = sql + Convert.ToString(costCentre) + "  ORDER BY CARDNUMBER ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchIDProofS()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT 'Voters ID' AS IDPROOF UNION SELECT 'Aadhar' AS IDPROOF UNION ";
            sql = sql +  "SELECT 'PAN Card' AS IDPROOF UNION SELECT 'Passport' AS IDPROOF UNION ";
            sql = sql +  "SELECT 'Others'  AS IDPROOF ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet FetchLabourTypes()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT 'CompanyLabour' AS LabourType UNION SELECT 'SubContractor Labour' AS LabourType ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchJobTypes()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT 'General' AS JobType UNION SELECT 'RCC' AS JobType UNION SELECT 'Masonry' AS JOBTYPE ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public  DataSet FetchStates()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "select * from states  order by statename ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        
        public DataSet FetchSex()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT 'MALE' AS SEX UNION SELECT 'FEMALE' AS SEX ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchBloodGroup()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT 'O+' BLOODGROUP UNION SELECT 'O-' BLOODGROUP UNION SELECT 'A+' BLOODGROUP UNION ";
            sql = sql + " SELECT 'A-' BLOODGROUP UNION SELECT 'B+' BLOODGROUP UNION SELECT 'B-' BLOODGROUP UNION ";
            sql = sql + " SELECT 'AB+' BLOODGROUP UNION SELECT 'AB-' BLOODGROUP  ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
    }
}
