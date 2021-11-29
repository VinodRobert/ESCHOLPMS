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

        public DataSet Login(string userName, string password)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT * FROM LOGINS WHERE LOGINID='" + Convert.ToString(userName).Trim() + "' AND PASSWORD='" + Convert.ToString(password) + "' AND STATUS=1";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet fetchDepartment()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT * FROM EXT.DEPARTMENT ORDER BY DEPARTMENTNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int chkDepartment(string departmentName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT * FROM EXT.DEPARTMENT WHERE DEPARTMENTNAME='" + Convert.ToString(departmentName).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return Convert.ToInt16(ds.Tables[0].Rows.Count);
        }


        public int addEditDepartment(int departmentID, string departmentName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
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
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT * FROM EXT.DESIGNATION  WHERE DEPARTMENTID = " + Convert.ToInt16(departmentID) + "  ORDER BY HIERARCHYORDER";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int chkDesignation(string designationName, int departmentID, int hierachyCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT * FROM EXT.DESIGNATION WHERE DESIGNATIONNAME='" + Convert.ToString(designationName).Trim() + "' AND DEPARTMENTID=";
            sql = sql + Convert.ToString(departmentID) + "  AND HIERARCHYORDER = " + Convert.ToString(hierachyCode);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return Convert.ToInt16(ds.Tables[0].Rows.Count);
        }


        public int addEditDesignation(int departmentID, int designationID, string designationName, int hierarchyOrder)
        {
            string _connectionString = SqlHelper.GetConnectionString();
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
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT  C.COSTCENTRECODE COSTCENTRECODE,UPPER(P.COSTCENTRE) PARENT,UPPER(C.COSTCENTRE) COSTCENTRE,UPPER(C.SHORTNAME) SHORTNAME ";
            sql = sql + " FROM EXT.COSTCENTRES C  INNER JOIN EXT.COSTCENTRES P  ON C.PARENTID = P.COSTCENTRECODE ORDER BY P.COSTCENTRE,C.COSTCENTRE";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet FetchActiveEmployeeDetails()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT EmployeeCode,EmployeeNumber,EmployeeName,DesignationName Designation,DepartmentName Department,COSTCENTRE AS UnitName,CURRENTSTATUS FROM EXT.VWEMPLOYEE WHERE CURRENTSTATUS<>'Resigned' ORDER BY EMPLOYEENAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchEmployeeDetails(int employeeCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT *  FROM EXT.VWEMPLOYEE WHERE EMPLOYEENUMBER=" + Convert.ToString(employeeCode);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet FetchDepartment()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT *  FROM EXT.DEPARTMENT ORDER BY DEPARTMENTNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet FetchDesignation()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT *  FROM EXT.DESIGNATION ORDER BY DESIGNATIONNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchCostCentre()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT *  FROM EXT.COSTCENTRES ORDER BY COSTCENTRE";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet FetchHRStatus()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT *  FROM EXT.HRSTATUS";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchBankLedgers()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT LEDGERID,BANKNAME FROM EXT.BANK ORDER BY BANKNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

    }

}