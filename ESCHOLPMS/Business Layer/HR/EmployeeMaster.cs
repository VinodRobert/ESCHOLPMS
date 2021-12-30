using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SQLHelper;

namespace ESCHOLPMS
{
    class EmployeeMaster
    {
        private int _employeeCode;
                
        public int EmployeeCode
        {
            get { return _employeeCode; }
            set { _employeeCode = value; }
        }
        private string _employeeNumber;
        public string EmployeeNumber
        {
            get { return _employeeNumber; }
            set { _employeeNumber = value; }
        }
        private string _employeeName;
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }
        private DateTime _dateofBirth;
        public DateTime DateOfBirth
        {
            get { return _dateofBirth; }
            set { _dateofBirth = value; }
        }
        private DateTime _dateJoinOrganization;
        public DateTime DateJoinOrganization
        {
            get { return _dateJoinOrganization; }
            set { _dateJoinOrganization = value; }
        }
        private DateTime _dateJoinGrade;

        public DateTime DateJoinGrade
        {
            get { return _dateJoinGrade; }
            set { _dateJoinGrade = value; }
        }
        private string _bloodGroup;
        public string BloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value; }
        }
        private string _sex;
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private string _photoFileName;
        public string PhotoFileName
        {
            get { return _photoFileName; }
            set { _photoFileName = value; }
        }
        private string _landLine;
        public string LandLine
        {
            get { return _landLine; }
            set { _landLine = value; }
        }
        private string _mobile;
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private int _departmentID;
        public int DepartmentID
        {
            get { return _departmentID; }
            set { _departmentID = value; }
        }
        private int _designationID;
        public int DesignationID
        {
            get{return _designationID;}
            set { _designationID = value; }
        }
        private string _panNumber;
        public string PANNumber
        {
            get {return _panNumber; }
            set { _panNumber = value; }
        }
        private string _pfNumber;
        public string PFNumber
        {
            get { return _pfNumber; }
            set { _pfNumber = value; }
        }

        private string _esiNumber;
        public string ESINumber
        {
            get { return _esiNumber; }
            set { _esiNumber = value; }
        }
        private int _bankID;
        public int BankID
        {
            get { return _bankID; }
            set { _bankID = value; }
        }
        private string _bankAccountNumber;
        public string BankAccountNumber
        {
            get { return _bankAccountNumber; }
            set { _bankAccountNumber = value; }
        }
        private int _subLedgerID;
        public int SubLedgerID
        {
            get { return _subLedgerID; }
            set { _subLedgerID = value; }
        }
        private int _costcentreID;
        public int CostCentreID
        {
            get { return _costcentreID; }
            set { _costcentreID = value; }
        }

        private int _addressID;
        public int AddressID
        {
            get { return _addressID; }
            set { _addressID = value; }
        }
        private int _leaveDetailsID;
        public int LeaveDetailsID
        {
            get { return _leaveDetailsID; }
            set { _leaveDetailsID = value; }
        }
        private int _status;
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private string _aadhaarNo;
        public string AadhaarNo
        {
            get { return _aadhaarNo; }
            set { _aadhaarNo = value; }
        }
        private string _eligibleForPF;
        public string EligibleForPF
        {
            get { return _eligibleForPF; }
            set { _eligibleForPF = value; }
        }
        private string _eligibleForESI;
        public string EligibleForESI
        {
            get { return _eligibleForESI; }
            set { _eligibleForESI = value; }
        }
            
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
                _qr.OrderBy = "EmployeeCode";
            else
                _qr.OrderBy = orderby;
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "HR.spSelectEmployeeMaster", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectEmployeeMaster", parameters);
            return ds;
        }

        public void Import()
        {
            QueryString _qr = new QueryString();
            _qr.FieldList = "EmployeeCode,EmployeeNumber,EmployeeName,DateOfBirth,DateJoinOrganization,DateJoinGrade,BloodGroup,Sex,PhotoFileName,LandLine,Mobile,Email,DepartmentID,DesignationID,PANNumber,PFNumber,ESINumber,BankID,BankAccountNumber,SubLedgerID,CostCentreID,AddressID,LeaveDetailsID,Status,AadhaarNo,EligibleForPF,EligibleForESI";
            _qr.Criteria = "EmployeeCode=" + this.EmployeeCode.ToString();
            _qr.OrderBy = "EmployeeCode";
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "HR.spSelectEmployeeMaster", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectEmployeeMaster", parameters);
            ESHCOLPMS.ImportProperty.ImportData(this, ds);
        }

        public int Update()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(this, "HR.spAddEditEmployeeMaster", _connectionString);
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "HR.spAddEditEmployeeMaster", parameters);
            EmployeeCode = Convert.ToInt32(parameters[0].Value);
            return _success;
        }

        public int Delete()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(this, "HR.spDeleteEmployee", _connectionString);
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "HR.spDeleteEmployee", parameters);
            return _success;
        }
        public DataSet FetchHRStatus(string fieldList, string criteria, string orderby)
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
                _qr.OrderBy = "EmployeeCode";
            else
                _qr.OrderBy = orderby;
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "[HR].[spSelectHRStatusDetails]", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[HR].[spSelectHRStatusDetails]", parameters);
            return ds;
        }

        public int AddNewEmployee(string employeeNumber,string employeeName)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@EMPLOYEENUMBER", SqlDbType.Text);
            arParms[0].Value = employeeNumber.ToString();
            arParms[1] = new SqlParameter("@EMPLOYEENAME", SqlDbType.Text);
            arParms[1].Value = employeeName.ToString();
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spAddNewEmployee", arParms);
            int success = Convert.ToInt16(ds.Tables[0].Rows[0]["Success"]);
            return success;
        }
    }
}
