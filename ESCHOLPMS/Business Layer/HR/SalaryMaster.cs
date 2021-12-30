using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SQLHelper;
using ESHCOLPMS;

namespace ESCHOLPMS
{
    class SalaryMaster
    {
        private	int	_salaryMasterCode;
        private	int	_empID;
        private	decimal	_basic_DA;
        private decimal _da;
        private decimal _hra;       
        private	decimal	_otherAllowance;
        private	decimal	_ded_PF;
        private	decimal	_ded_ESI;
        private	decimal	_ded_IncomeTax;
        private	decimal	_ded_ProfessionalTax;
        private	decimal	_ded_OtherAdvance;
        private	decimal	_takeHomeSalary;
        private	decimal	_grossSalary;
        private	DateTime _enterdOn;
        private	DateTime _modifiedOn;
        private	int	_statusCode;
        private	int	_userID;




        public	int	SalaryMasterCode
        {
            get{return _salaryMasterCode;}
            set{_salaryMasterCode=value;}
        }
        public	int	EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }
        public	decimal	Basic_DA
        {
            get { return _basic_DA; }
            set { _basic_DA = value; }
        }
        public decimal Da
        {
            get { return _da; }
            set { _da = value; }
        }
        public decimal Hra
        {
            get { return _hra; }
            set { _hra = value; }
        }
        public decimal OtherAllowance
        {
            get { return _otherAllowance; }
            set {_otherAllowance = value; }
        }
        public	decimal	Ded_PF
        {
            get { return _ded_PF; }
            set { _ded_PF = value; }
        }
        public	decimal	Ded_ESI
        {
            get { return _ded_ESI; }
            set { _ded_ESI = value; }
        }
        public	decimal	Ded_IncomeTax
        {
            get { return _ded_IncomeTax; }
            set { _ded_IncomeTax = value; }
        }
        public	decimal	Ded_ProfessionalTax
        {
            get { return _ded_ProfessionalTax; }
            set { _ded_ProfessionalTax = value; }
        }
        public	decimal	Ded_OtherAdvance
        {
            get { return _ded_OtherAdvance; }
            set { _ded_OtherAdvance = value; }
        }
        public	decimal	TakeHomeSalary
        {
            get { return _takeHomeSalary; }
            set { _takeHomeSalary = value; }
        }
        public	decimal	GrossSalary
        {
            get { return _grossSalary; }
            set { _grossSalary = value; }
        }
        public	DateTime EnterdOn
        {
            get { return _enterdOn; }
            set { _enterdOn = value; }
        }
        public	DateTime ModifiedOn
        {
            get { return _modifiedOn; }
            set { _modifiedOn = value; }
        }
        public	int	StatusCode
        {
            get { return _statusCode; }
            set { _statusCode = value; }
        }
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
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
                _qr.OrderBy = "SalaryMasterCode";
            else
                _qr.OrderBy = orderby;
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "HR.spSelectSalaryMaster", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectSalaryMaster", parameters);
            return ds;
        }

        public DataSet Fetch()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectSalaryMaster");
            return ds;
        }

        public void Import()
        {
            QueryString _qr = new QueryString();
            _qr.FieldList = " * ";
            _qr.Criteria = "SalaryMasterCode=" + this.SalaryMasterCode.ToString();
            _qr.OrderBy = "SalaryMasterCode";
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "HR.spSelectSalaryMaster", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectSalaryMaster", parameters);
            ImportProperty.ImportData(this, ds);
        }

        public int Update()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(this, "HR.spAddEditSalaryMaster", _connectionString);
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "HR.spAddEditSalaryMaster", parameters);
            SalaryMasterCode = Convert.ToInt32(parameters[0].Value);
            return _success;
        }





    }
}
