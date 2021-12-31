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
    public class PMS
    {
        #region Logins

        public DataSet FetchAccessControlUsers()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = " SELECT * FROM ACCESSSTAFF ORDER BY SPINTLYID ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchAccessPoints()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT 0 AS SPINTLYACCESSPOINTID,' ---ALL ACCESS POINTS-- ' ACCESSPOINT UNION";
            sql = sql + " SELECT AP.SPINTLYACCESSPOINTID,(S.SITENAME+'-'+AP.ACCESSPOINTNAME+'('+S.LOCATION+')' ) ACCESSPOINT ";
            sql = sql + " FROM ACCESSPOINTS AP INNER JOIN ACCESSSITES S ON AP.SITEID = S.SPINTLYSITEID ORDER BY ACCESSPOINT ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet Login(string userName, string password)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT * FROM LOGINS WHERE USERID='" + Convert.ToString(userName).Trim() + "' AND PASSWORD='" + Convert.ToString(password) + "' AND STATUS=1";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetAccessKeyDetails()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "Select * From Authorize";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int DeleteAllSites()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "DELETE FROM AccessSites";
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return i;
        }

        public int DeleteAllAccessPoints()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "DELETE FROM ACCESSPOINTS";
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return i;
        }


        public int InsertSite(int siteID,string siteName,string siteLocation)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "INSERT INTO AccessSites(SPINTLYSITEID,SITENAME,LOCATION) VALUES(";
            sql = sql + Convert.ToString(siteID) + ",'" + Convert.ToString(siteName).Trim() + "','" + Convert.ToString(siteLocation) + "')";
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return i;
        }

        public int InsertAccessPoint(int siteID,int accessPointID, string accessPointName)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "INSERT INTO ACCESSPOINTS(SITEID,SPINTLYACCESSPOINTID,ACCESSPOINTNAME) VALUES(";
            sql = sql + Convert.ToString(siteID) + "," + Convert.ToString(accessPointID).Trim() + ",'" + Convert.ToString(accessPointName) + "')";
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return i;
        }

        public DataSet GetAccessSites()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT * FROM AccessSites";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetAccessPoints()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT AP.ACCESSPOINTSID,AP.SITEID,S.SITENAME,AP.SPINTLYACCESSPOINTID,AP.ACCESSPOINTNAME ";
            sql = sql + " FROM ACCESSPOINTS  AP INNER JOIN ACCESSSITES S ON AP.SITEID = S.SPINTLYSITEID ORDER BY AP.SITEID,AP.SPINTLYACCESSPOINTID";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetAccessUsers(int category)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT 0  SPINTLYID ,' --ALL USERS--  ' NAME UNION SELECT SPINTLYID,NAME FROM ACCESSSTAFF ";
            if (category != 0)
                sql = sql + " WHERE CATEGORY= " + Convert.ToString(category) + "  ORDER BY NAME";
            else
                sql = sql + "  ORDER BY NAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;



        }
        public int InsertAccessUsers(int id,string userName,string createdAt,bool cardAssigned,string accessExpiresAt,
                       bool accessExpired, string deactivatedOn,string employeeCode,string credentialId)
        {

            SqlParameter[] arParms = new SqlParameter[9];
            
            arParms[0] = new SqlParameter("@SPINTLYID", SqlDbType.Int);
            arParms[0].Value = id;
            arParms[1] = new SqlParameter("@NAME", SqlDbType.Text);
            arParms[1].Value = userName;
            arParms[2] = new SqlParameter("@CREATED", SqlDbType.Text);
            arParms[2].Value = createdAt;
            arParms[3] = new SqlParameter("@CARDASSIGNED", SqlDbType.Bit);
            arParms[3].Value = cardAssigned;
            arParms[4]= new SqlParameter("@ACCESSEXPIREDAT", SqlDbType.Text);
            arParms[4].Value = accessExpiresAt;
            arParms[5] = new SqlParameter("@ACCESSEXPIRED", SqlDbType.Bit);
            arParms[5].Value = accessExpired;
            arParms[6] = new SqlParameter("@DEACTIVATEDON", SqlDbType.Text);
            arParms[6].Value = deactivatedOn;
            arParms[7] = new SqlParameter("@EMPLOYEECODE", SqlDbType.Text);
            arParms[7].Value = employeeCode;
            arParms[8] = new SqlParameter("@ACCESSCARDID", SqlDbType.Text);
            arParms[8].Value = credentialId;
            // Execute the stored procedure
            string _connectionString = SqlHelper.GetConnectionString(2);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "InsertAccessUsers", arParms);
            return i;
        }
        #endregion

        #region API
        public int UpdateAuthorizationKey(string authKey)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql =  "UPDATE Authorize Set AuthorizationKey='" + Convert.ToString(authKey).ToString() + "'";
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }

        public int UpdateAuthorizationKey(int organizationID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "UPDATE Authorize Set OrganizationID=" + Convert.ToString(organizationID).ToString();
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }
        #endregion

        public int DeleteAccessHistory(int accessPointID,DateTime swipeDate)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "DELETE FROM ACCESSHISTORY WHERE ACCESSID=" + Convert.ToString(accessPointID) + "  AND ACCESSTIME='";
            sql = sql + Convert.ToDateTime(swipeDate) + "'";
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return j;
        }

        public DataSet  UpdateAttendanceHistory(string startDate,string endDate,int selectedUser)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] arParms = new SqlParameter[3];
            arParms[0] = new SqlParameter("@STARTDATESTRING", SqlDbType.Text);
            arParms[0].Value = startDate;
            arParms[1] = new SqlParameter("@ENDDATESTRING", SqlDbType.Text);
            arParms[1].Value = endDate;
            arParms[2] = new SqlParameter("@USERSELECTED", SqlDbType.Int);
            arParms[2].Value = selectedUser;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "UpdateAttendanceHistory",arParms);
            return ds;
        }

        public int InsertAccessHistory(int accessPointID,int userID,string revisedDateString)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "INSERT INTO AccessHistory(ACCESSID,USERID,ACCESSTIME) VALUES(";
            sql = sql + Convert.ToString(accessPointID) + "," + Convert.ToString(userID) + ",'" + revisedDateString + "')";
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return i;
        }

        public DataSet fetchDepartment()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT * FROM EXT.DEPARTMENT ORDER BY DEPARTMENTNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int chkDepartment(string departmentName)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT * FROM EXT.DEPARTMENT WHERE DEPARTMENTNAME='" + Convert.ToString(departmentName).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return Convert.ToInt16(ds.Tables[0].Rows.Count);
        }


        public int addEditDepartment(int departmentID, string departmentName)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "Select max(departmentCode) lastDepartmentID from ext.Department";
            if (departmentID == 0)
            {
                DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
                departmentID = Convert.ToInt16(ds.Tables[0].Rows[0]["lastDepartmentID"]) + 1;
                sql = "INSERT INTO EXT.DEPARTMENT(DEPARTMENTCODE,DEPARTMENTNAME) VALUES (" + Convert.ToString(departmentID) + ",'" + Convert.ToString(departmentName).Trim() + "')";
                int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            }
            else
            {
                sql = "Update EXT.Department SET DEPARTMENTNAME='" + Convert.ToString(departmentName).Trim() + "'  WHERE DEPARTMENTCODE=" + Convert.ToString(departmentID);
                int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            }
            return 1;
        }









        public DataSet fetchDesignation(int departmentID)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT * FROM EXT.DESIGNATION  WHERE DEPARTMENTID = " + Convert.ToInt16(departmentID) + "  ORDER BY HIERARCHYORDER";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int chkDesignation(string designationName, int departmentID, int hierachyCode)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT * FROM EXT.DESIGNATION WHERE DESIGNATIONNAME='" + Convert.ToString(designationName).Trim() + "' AND DEPARTMENTID=";
            sql = sql + Convert.ToString(departmentID) + "  AND HIERARCHYORDER = " + Convert.ToString(hierachyCode);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return Convert.ToInt16(ds.Tables[0].Rows.Count);
        }


        public int addEditDesignation(int departmentID, int designationID, string designationName, int hierarchyOrder)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "Select max(designationCode) lastDesignationID from ext.Designation";
            if (designationID == 0)
            {
                DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
                designationID = Convert.ToInt16(ds.Tables[0].Rows[0]["lastDesignationID"]) + 1;
                sql = "INSERT INTO EXT.DESIGNATION(DESIGNATIONCODE,DEPARTMENTID,DESIGNATIONNAME,HIERARCHYORDER) VALUES (";
                sql = sql + Convert.ToString(designationID) + "," + Convert.ToString(departmentID) + ",'" + Convert.ToString(designationName) + "',";
                sql = sql + Convert.ToString(hierarchyOrder) + ")";
                int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            }
            else
            {
                sql = "Update EXT.DESIGNATION SET DESIGNATIONNAME='" + Convert.ToString(designationName).Trim() + "',HIERARCHYORDER=";
                sql = sql + Convert.ToString(hierarchyOrder) + "  WHERE DESIGNATIONCODE=" + Convert.ToString(designationID);
                int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            }
            return 1;
        }

        public DataSet fetchCostCentre()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT  C.COSTCENTRECODE COSTCENTRECODE,UPPER(P.COSTCENTRE) PARENT,UPPER(C.COSTCENTRE) COSTCENTRE,UPPER(C.SHORTNAME) SHORTNAME ";
            sql = sql + " FROM EXT.COSTCENTRES C  INNER JOIN EXT.COSTCENTRES P  ON C.PARENTID = P.COSTCENTRECODE ORDER BY P.COSTCENTRE,C.COSTCENTRE";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet FetchActiveEmployeeDetails()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT EmployeeCode,EmployeeNumber,EmployeeName,DesignationName Designation,DepartmentName Department,COSTCENTRE AS UnitName,CURRENTSTATUS FROM EXT.VWEMPLOYEE WHERE CURRENTSTATUS<>'Resigned' ORDER BY EMPLOYEENAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchEmployeeDetails(int employeeCode)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT *  FROM EXT.VWEMPLOYEE WHERE EMPLOYEENUMBER=" + Convert.ToString(employeeCode);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet FetchDepartment()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT *  FROM EXT.DEPARTMENT ORDER BY DEPARTMENTNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet FetchDesignation()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT *  FROM EXT.DESIGNATION ORDER BY DESIGNATIONNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchCostCentre()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT *  FROM EXT.COSTCENTRES ORDER BY COSTCENTRE";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet FetchHRStatus()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT *  FROM EXT.HRSTATUS";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchBankLedgers()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            string sql = "SELECT LEDGERID,BANKNAME FROM EXT.BANK ORDER BY BANKNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

    }

}