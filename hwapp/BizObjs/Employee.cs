using System;
using System.IO;

namespace ConsoleApplication
{
    public class Employee
    {
        #region variable declarations

        private Int32 _employeeKey;
        private String _employeeCode;
        private String _firstName;
        private String _lastName;

        #endregion

        #region public properties

        public Int32 EmployeeKey
        {
            get { return _employeeKey; }
            set { _employeeKey = value; }
        }

        public String EmployeeCode
        {
            get { return _employeeCode; }
            set { _employeeCode = value; }
        }

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        #endregion

        #region constructor

        public Employee()
        {

        }

        #endregion

    }

}