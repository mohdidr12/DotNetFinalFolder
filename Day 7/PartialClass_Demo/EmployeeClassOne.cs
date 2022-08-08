using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Demo
{
    public partial class EmployeeClass
    {
        //    public string name { get; set; }
        //    public int  roll_no {get;set;}
        //    public string course { get; set; }
        string _firstName;
        string _lastName;
        double _salary;
        string _gender;
       
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
