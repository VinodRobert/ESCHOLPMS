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
    class Labour
    {
        public int ResetAttachments(Int64 labourID)
        {
             string _connectionString = SqlHelper.GetConnectionString(1);
             string sql = "update LABOURATTACHMENTS SET IDPROOF=NULL,IDPROOFFILENAME='',ENROLLMENTFILENAME='',ENROLLMENTFORM=NULL,TRADECERTIFICATE=NULL,TRADECERTIFICATEFILENAME='' WHERE WORKERID = ";
             sql = sql + Convert.ToString(labourID);
             int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
             _connectionString = SqlHelper.GetConnectionString(2);
             sql = "Update LabourDetails Set STATUS='New' WHERE LABOURID=" + Convert.ToString(labourID);
             int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
             return k;
             
        }

        public int UpdateLabourStatus(string status, Int64 labourID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "Update LabourDetails set Status='"+Convert.ToString(status)+"' WHERE LABOURID=" + Convert.ToString(labourID);
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return j;
        }
        public DataSet FetchSingleLabour(Int64 labourID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT * FROM LABOURDETAILS WHERE LABOURID=" + Convert.ToString(labourID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet CreateNewLabour(string name,string gender,DateTime dob,string parentName,string bloodGroup,string permanentAddress,
                                       string currentAddress,string state,string pinCode,string mobileNumber,string currentNumber,
                                       string idProofSubmitted,string idProofNumber,string typeOfLabour,string skillType,
                                       int subContractorID, int currentCostCentreID,string accessCardNumber)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] arParms = new SqlParameter[18];
            arParms[0] = new SqlParameter("@LABOURNAME", SqlDbType.Text);
            arParms[0].Value = name;
            arParms[1] = new SqlParameter("@GENDER", SqlDbType.Text);
            arParms[1].Value = gender;
            arParms[2] = new SqlParameter("@DATEOFBIRTH", SqlDbType.DateTime);
            arParms[2].Value = dob;
            arParms[3] = new SqlParameter("@PARENTNAME", SqlDbType.Text);
            arParms[3].Value = parentName;
            arParms[4] = new SqlParameter("@BLOODGROUP", SqlDbType.Text);
            arParms[4].Value = bloodGroup;
            arParms[5] = new SqlParameter("@PERMANENTADDRESS", SqlDbType.Text);
            arParms[5].Value = permanentAddress;
            arParms[6] = new SqlParameter("@CURRENTADDRESS", SqlDbType.Text);
            arParms[6].Value = currentAddress;
            arParms[7] = new SqlParameter("@STATE", SqlDbType.Text);
            arParms[7].Value = state;
            arParms[8] = new SqlParameter("@PINCODE", SqlDbType.Text);
            arParms[8].Value = pinCode;
            arParms[9] = new SqlParameter("@MOBILENUMBER", SqlDbType.Text);
            arParms[9].Value = mobileNumber;
            arParms[10] = new SqlParameter("@PHONENUMBER", SqlDbType.Text);
            arParms[10].Value = currentNumber;
            arParms[11] = new SqlParameter("@IDPROOFSUBMITTED", SqlDbType.Text);
            arParms[11].Value = idProofSubmitted;
            arParms[12] = new SqlParameter("@IDPROOFNUMBER", SqlDbType.Text);
            arParms[12].Value = idProofNumber;
            arParms[13] = new SqlParameter("@TYPEOFLABOUR", SqlDbType.Text);
            arParms[13].Value = typeOfLabour;
            arParms[14] = new SqlParameter("@SKILLTYPE", SqlDbType.Text);
            arParms[14].Value = skillType;
            arParms[15] = new SqlParameter("@SUBCONTRACTORID", SqlDbType.Int);
            arParms[15].Value = subContractorID;
            arParms[16] = new SqlParameter("@CURRENTCOSTCENTREID", SqlDbType.Int);
            arParms[16].Value = currentCostCentreID;
            arParms[17] = new SqlParameter("@ACCESSCARDNUMBER", SqlDbType.Text);
            arParms[17].Value = accessCardNumber;
            

            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[spNewLabour]", arParms);
            return ds;
        }


        public int UpdateLabour(Int64 labourID, string name, string gender, DateTime dob, string parentName, string bloodGroup,
                                string permanentAddress, string currentAddress, string state, string pinCode,
                                string mobileNumber, string currentNumber, string idProofSubmitted, string idProofNumber, string typeOfLabour,
                                string skillType, int subContractorID, int currentCostCentreID, string accessCardNumber  
                                )
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] arParms = new SqlParameter[19];
            arParms[0] = new SqlParameter("@LABOURNAME", SqlDbType.Text);
            arParms[0].Value = name;
            arParms[1] = new SqlParameter("@GENDER", SqlDbType.Text);
            arParms[1].Value = gender;
            arParms[2] = new SqlParameter("@DATEOFBIRTH", SqlDbType.DateTime);
            arParms[2].Value = dob;
            arParms[3] = new SqlParameter("@PARENTNAME", SqlDbType.Text);
            arParms[3].Value = parentName;
            arParms[4] = new SqlParameter("@BLOODGROUP", SqlDbType.Text);
            arParms[4].Value = bloodGroup;
            arParms[5] = new SqlParameter("@PERMANENTADDRESS", SqlDbType.Text);
            arParms[5].Value = permanentAddress;
            arParms[6] = new SqlParameter("@CURRENTADDRESS", SqlDbType.Text);
            arParms[6].Value = currentAddress;
            arParms[7] = new SqlParameter("@STATE", SqlDbType.Text);
            arParms[7].Value = state;
            arParms[8] = new SqlParameter("@PINCODE", SqlDbType.Text);
            arParms[8].Value = pinCode;
            arParms[9] = new SqlParameter("@MOBILENUMBER", SqlDbType.Text);
            arParms[9].Value = mobileNumber;
            arParms[10] = new SqlParameter("@PHONENUMBER", SqlDbType.Text);
            arParms[10].Value = currentNumber;
            arParms[11] = new SqlParameter("@IDPROOFSUBMITTED", SqlDbType.Text);
            arParms[11].Value = idProofSubmitted;
            arParms[12] = new SqlParameter("@IDPROOFNUMBER", SqlDbType.Text);
            arParms[12].Value = idProofNumber;
            arParms[13] = new SqlParameter("@TYPEOFLABOUR", SqlDbType.Text);
            arParms[13].Value = typeOfLabour;
            arParms[14] = new SqlParameter("@SKILLTYPE", SqlDbType.Text);
            arParms[14].Value = skillType;
            arParms[15] = new SqlParameter("@SUBCONTRACTORID", SqlDbType.Int);
            arParms[15].Value = subContractorID;
            arParms[16] = new SqlParameter("@CURRENTCOSTCENTREID", SqlDbType.Int);
            arParms[16].Value = currentCostCentreID;
            arParms[17] = new SqlParameter("@ACCESSCARDNUMBER", SqlDbType.Text);
            arParms[17].Value = accessCardNumber;
            arParms[18] = new SqlParameter("@LABOURID", SqlDbType.BigInt);
            arParms[18].Value = labourID;
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "spUpdateLabour", arParms);
            return j;
        }
        public DataSet FetchCompleteLabours(int costCentre)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT LABOURID LabourID,PROJECTNAME,LABOURROLLNO,LABOURNAME,MOBILENUMBER,TYPEOFLABOUR,SKILLTYPE,SUBCONTRACTORNAME,STATUS";
            sql = sql + " FROM  LABOURDETAILS WHERE STATUS NOT IN ('Archived') AND CURRENTCOSTCENTREID= ";
            sql = sql +   Convert.ToString(costCentre)     +"  ORDER BY LABOURROLLNO DESC ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds; 
        }

        public DataSet FetchCompleteLaboursForCertificate(int costCentre)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT LABOURID LabourID,PROJECTNAME,LABOURROLLNO,LABOURNAME,DATEOFJOINING,TYPEOFLABOUR,SKILLTYPE,SUBCONTRACTORNAME,STATUS";
            sql = sql + " FROM  LABOURDETAILS WHERE STATUS in ('New','Certificate Uploaded. Not Approved') AND CURRENTCOSTCENTREID= ";
            sql = sql + Convert.ToString(costCentre) + "  ORDER BY LABOURROLLNO DESC ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchContractors(int costCentre)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT S.CONTRACTORCODE,UPPER(S.CONTRACTORNAME) CONTRACTORNAME FROM EXT.SUBCONTRACTORS S ";
            sql = sql + " WHERE CONTRACTORCODE IN(SELECT CONTRACTORID FROM EXT.PROJECTCONTRACTORS  ";
            sql = sql + " WHERE COSTCENTREID = " + Convert.ToString(costCentre) + " ) ORDER BY CONTRACTORNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

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

        public int DuplicateMobileNumber(string mobileNumber)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT * FROM LABOURDETAILS WHERE MOBILENUMBER ='" + Convert.ToString(mobileNumber) + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            if ((ds.Tables[0].Rows.Count == 0))
                return 0;
            else
                return 1;

        }

        public int DuplicateIDProofNumber(string idProofNumber)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT * FROM LABOURDETAILS WHERE IDProofNumber ='" + Convert.ToString(idProofNumber) + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            if (ds.Tables[0].Rows.Count == 0)
                return 0;
            else
                return 1;

        }



    }
}
