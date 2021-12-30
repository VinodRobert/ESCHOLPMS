//===================================================================================
//  Project		:  ESHCOL
//  Module		:  HR
//  Class		:  AddressBook.cs
//  Purpose		:  Business Logic related with table(Sql DB) AddressBook
//  Created On	:  30 Mar 2008
//  Created By	:  Vinod Robert
//===================================================================================

#region Using
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SQLHelper;
using ESHCOLPMS;
#endregion

namespace ESCHOLPMS
{
    public class AddressBook
    {
        #region Variables

        private Int32 _addressCode;
        private string _presentHouse;
        private string _presentStreet;
        private string _presentPostOffice;
        private string _presentPlace;
        private string _presentDistrict;
        private string _presentState;
        private string _presentPincode;
        private string _permanentHouse;
        private string _permanentStreet;
        private string _permanentPostOffice;
        private string _permanentPlace;
        private string _permanentDistrict;
        private string _permanentState;
        private string _permanentPincode;

        #endregion

        #region Properties

        public Int32 AddressCode
        {
            get
            {
                return _addressCode;
            }
            set
            {
                _addressCode = value;
            }
        }
        public string PresentHouse
        {
            get
            {
                return _presentHouse;
            }
            set
            {
                _presentHouse = value;
            }
        }
        public string PresentStreet
        {
            get
            {
                return _presentStreet;
            }
            set
            {
                _presentStreet = value;
            }
        }
        public string PresentPostOffice
        {
            get
            {
                return _presentPostOffice;
            }
            set
            {
                _presentPostOffice = value;
            }
        }
        public string PresentPlace
        {
            get
            {
                return _presentPlace;
            }
            set
            {
                _presentPlace = value;
            }
        }
        public string PresentDistrict
        {
            get
            {
                return _presentDistrict;
            }
            set
            {
                _presentDistrict = value;
            }
        }
        public string PresentState
        {
            get
            {
                return _presentState;
            }
            set
            {
                _presentState = value;
            }
        }
        public string PresentPincode
        {
            get
            {
                return _presentPincode;
            }
            set
            {
                _presentPincode = value;
            }
        }
        public string PermanentHouse
        {
            get
            {
                return _permanentHouse;
            }
            set
            {
                _permanentHouse = value;
            }
        }
        public string PermanentStreet
        {
            get
            {
                return _permanentStreet;
            }
            set
            {
                _permanentStreet = value;
            }
        }
        public string PermanentPostOffice
        {
            get
            {
                return _permanentPostOffice;
            }
            set
            {
                _permanentPostOffice = value;
            }
        }
        public string PermanentPlace
        {
            get
            {
                return _permanentPlace;
            }
            set
            {
                _permanentPlace = value;
            }
        }
        public string PermanentDistrict
        {
            get
            {
                return _permanentDistrict;
            }
            set
            {
                _permanentDistrict = value;
            }
        }
        public string PermanentState
        {
            get
            {
                return _permanentState;
            }
            set
            {
                _permanentState = value;
            }
        }
        public string PermanentPincode
        {
            get
            {
                return _permanentPincode;
            }
            set
            {
                _permanentPincode = value;
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
                _qr.OrderBy = "AddressCode";
            else
                _qr.OrderBy = orderby;
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "HR.spSelectAddressBook", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectAddressBook", parameters);
            return ds;
        }

        public DataSet Fetch()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectAddressBook");
            return ds;
        }

        public void Import()
        {
            QueryString _qr = new QueryString();
            _qr.FieldList = " AddressCode,PresentHouse,PresentStreet,PresentPostOffice,PresentPlace,PresentDistrict,PresentState,PresentPincode,PermanentHouse,PermanentStreet,PermanentPostOffice,PermanentPlace,PermanentDistrict,PermanentState,PermanentPincode ";
            _qr.Criteria = "AddressCode=" + this.AddressCode.ToString();
            _qr.OrderBy = "AddressCode";
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(_qr, "HR.spSelectAddressBook", _connectionString);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "HR.spSelectAddressBook", parameters);
            ImportProperty.ImportData(this, ds);
        }

        public int Update()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(this, "HR.spAddEditAddressBook", _connectionString);
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "HR.spAddEditAddressBook", parameters);
            AddressCode = Convert.ToInt16(parameters[0].Value);
            return _success;
        }

        public int Delete()
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = SqlHelper.BindParameters(this, "HR.spDeleteAddressBook", _connectionString);
            int _success = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "HR.spDeleteAddressBook", parameters);
            return _success;
        }

        public bool CheckDuplicate(string criteria)
        {
            string _connectionString = SqlHelper.GetConnectionString(2);
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Criteria", criteria);
            int _duplicateCount = (int)SqlHelper.ExecuteScalar(_connectionString, CommandType.StoredProcedure, "HR.spCheckAddressBook", parameters);
            if (_duplicateCount > 0)
                return true;
            else
                return false;
        }


        #endregion

    }
}
