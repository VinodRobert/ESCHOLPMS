//===================================================================================
//  Project		:  ESHCOL
//  Module		:  HR
//  Class		:  Department.cs
//  Purpose		:  Business Logic related with table(Sql DB) Department
//  Created On	:  28 Mar 2008
//  Created By	:  Vinod Robert
//===================================================================================

#region Using
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SQLHelper;
#endregion

namespace ESCHOLPMS
{
    public class Department
    {
        #region Variables

        private Int32 _departmentCode;
        private string _departmentName;

        #endregion

        #region Properties

        public Int32 DepartmentCode
        {
            get
            {
                return _departmentCode;
            }
            set
            {
                _departmentCode = value;
            }
        }
        public string DepartmentName
        {
            get
            {
                return _departmentName;
            }
            set
            {
                _departmentName = value;
            }
        }

        #endregion

        #region Functions

        public DataSet Fetch(string fieldList, string criteria, string orderby)
        {
            QueryString _qr = new QueryString();
            if (fieldList == null)
                _qr.FieldList = " * ";
            else
                _qr.FieldList = fieldList;
            if (criteria == null)
                _qr.Criteria = "1=1";
            else
                _qr.Criteria = criteria;
            if (orderby == null)
                _qr.OrderBy = "DepartmentCode";
            else
                _qr.OrderBy = orderby;

            string _connectionString = SqlHelper.GetConnectionString(2);
            


            //SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "TWO", remoteConnectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "TWO");
            return ds;
        }

        public DataSet Fetch()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectDepartment");
            return ds;
        }

        public void Import()
        {
            QueryString _qr = new QueryString();
            _qr.FieldList = " DepartmentCode,DepartmentName ";
            _qr.Criteria = "DepartmentCode=" + this.DepartmentCode.ToString();
            _qr.OrderBy = "DepartmentCode";
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "HR.spSelectDepartment", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectDepartment", parameters);
            ESHCOLPMS.ImportProperty.ImportData(this, ds);
        }

        public int Update()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(this, "HR.spAddEditDepartment", _connectionString);
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "HR.spAddEditDepartment", parameters);
            DepartmentCode = Convert.ToInt32(parameters[0].Value);
            return _success;
        }

        public int Delete()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(this, "HR.spDeleteDepartment", _connectionString);
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "HR.spDeleteDepartment", parameters);
            return _success;
        }

        public bool CheckDuplicate(string criteria)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Criteria", criteria);
            int _duplicateCount = (int)SqlHelper.ExecuteScalar(_connectionString, CommandType.StoredProcedure, "HR.spCheckDepartment", parameters);
            if (_duplicateCount > 0)
                return true;
            else
                return false;
        }


        #endregion

    }
}
