using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCHOLPMS 
{
    public class EInvoiceList
    {
        private string _invoiceNumber;
        private DateTime _invoiceDate;
        private string _partyCode;
        private string _partyName;
        private string _invoiceType;
        private decimal _invoiceAmount;
        private string _ackNumber;
        private DateTime _ackDate;
        private string _irn;
        private int _invoiceIndex;
        private int _invoiceCategory;

        public string InvoiceNumber
        {
            get { return _invoiceNumber; }
            set { _invoiceNumber = value; }
        }
        public DateTime InvoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; }
        }

        public string PartyCode
        {
            get { return _partyCode; }
            set { _partyCode = value; }
        }

        public string PartyName
        {
            get { return _partyName; }
            set { _partyName = value; }
        }

        public string InvoiceType
        {
            get { return _invoiceType; }
            set { _invoiceType = value; }
        }
        public Decimal InvoiceAmount
        {
            get { return _invoiceAmount; }
            set { _invoiceAmount = value; }
        }
        public string AckNumber
        {
            get { return _ackNumber; }
            set { _ackNumber = value; }
        }
        public DateTime AckDate
        {
            get { return _ackDate; }
            set { _ackDate = value; }
        }
        public string IRN
        {
            get { return _irn; }
            set { _irn = value; }
        }
        public int InvoiceIndex
        {
            get { return _invoiceIndex; }
            set { _invoiceIndex = value; }
        }

        public int InvoiceCategory
        {
            get { return _invoiceCategory; }
            set { _invoiceCategory = value; }
        }

    }
    public class LabourList
    {
   
        private Int64 _labourID;
        private string _projectName;
        private string _labourRollNo;
        private string _labourName;
        private string _mobileNumber;
        private string _typeOfLabour;
        private string _skillType;
        private string _subContractorName;
        private string _status;
        private DateTime _dateOfJoining;
        private int _due;

        public  int Due
        {
            get { return _due; }
            set { _due = value; }
        }

        public DateTime DateOfJoining
        {
            get { return _dateOfJoining; }
            set { _dateOfJoining = value; }
        }
        public Int64 LabourID
        {
            get { return _labourID; }
            set { _labourID = value; }
        }

        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        public string LabourRollNo
        {
            get { return _labourRollNo; }
            set { _labourRollNo = value; }
        }

        public string LabourName
        {
            get { return _labourName; }
            set { _labourName = value; }
        }

        public string MobileNumber
        {
            get { return _mobileNumber; }
            set { _mobileNumber = value; }
        }

        public string TypeOfLabour
        {
            get { return _typeOfLabour; }
            set { _typeOfLabour = value; }
        }

        public string SkillType
        {
            get { return _skillType; }
            set { _skillType = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string SubContractorName
        {
            get { return _subContractorName; }
            set { _subContractorName = value; }
        }

       
    }
}
