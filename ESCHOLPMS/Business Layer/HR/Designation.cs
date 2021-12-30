//===================================================================================
//  Project		:  ESHCOL
//  Module		:  HR
//  Class		:  Designation.cs
//  Purpose		:  Business Logic related with table(Sql DB) Designation
//  Created On	:  29 Mar 2008
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
    public class Designation
    {
        #region Variables

        private Int32 _designationCode;
        private string _designationName;
        private Int32 _hierarchyOrder;
        private Int32 _departmentID;

        #endregion

        #region Properties

        public Int32 DesignationCode
        {
            get
            {
                return _designationCode;
            }
            set
            {
                _designationCode = value;
            }
        }
        public string DesignationName
        {
            get
            {
                return _designationName;
            }
            set
            {
                _designationName = value;
            }
        }
        public Int32 HierarchyOrder
        {
            get
            {
                return _hierarchyOrder;
            }
            set
            {
                _hierarchyOrder = value;
            }
        }
        public Int32 DepartmentID
        {
            get { return _departmentID; }
            set { _departmentID = value; }
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
                _qr.OrderBy = "DesignationCode";
            else
                _qr.OrderBy = orderby;
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "HR.spSelectDesignation", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectDesignation", parameters);
            return ds;
        }

        public DataSet Fetch()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectDesignation");
            return ds;
        }

        public void Import()
        {
            QueryString _qr = new QueryString();
            _qr.FieldList = " DesignationCode,DepartmentID,DesignationName,HierarchyOrder ";
            _qr.Criteria = "DesignationCode=" + this.DesignationCode.ToString();
            _qr.OrderBy = "DesignationCode";
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "HR.spSelectDesignation", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectDesignation", parameters);
            ESHCOLPMS.ImportProperty.ImportData(this, ds);
        }

        public int Update()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(this, "HR.spAddEditDesignation", _connectionString);
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "HR.spAddEditDesignation", parameters);
            DesignationCode = Convert.ToInt16(parameters[0].Value);
            return _success;
        }

        public int Delete()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(this, "HR.spDeleteDesignation", _connectionString);
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "HR.spDeleteDesignation", parameters);
            return _success;
        }

        public bool CheckDuplicate(string criteria)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Criteria", criteria);
            int _duplicateCount = (int)SqlHelper.ExecuteScalar(_connectionString, CommandType.StoredProcedure, "HR.spCheckDesignation", parameters);
            if (_duplicateCount > 0)
                return true;
            else
                return false;
        }


        #endregion

    }
}
