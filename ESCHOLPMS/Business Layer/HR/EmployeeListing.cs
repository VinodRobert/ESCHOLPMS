using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCHOLPMS
{
    class EmployeeListing
    {
         

        private int _employeeCode;
        public int EmployeeCode
        {
            get { return _employeeCode; }
            set { _employeeCode = value; }
        }

        private string _employeeName;
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        private string _designation;
        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        private string _department;
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        private string _unitName;
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        private string _employeeNumber;
        public string EmployeeNumber
        {
            get { return _employeeNumber; }
            set { _employeeNumber = value; }
        }

        private string _currentStatus;
        public string CurrentStatus
        {
            get { return _currentStatus; }
            set { _currentStatus = value; }
        }

    }
}
