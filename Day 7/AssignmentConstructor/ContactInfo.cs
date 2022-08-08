using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentConstructor
{
    public class ContactInfo
    {


        string _address, _city, _state, _country, _phoneNo, _mobileNo, _emailid;
        //public ContactInfo(string address, string city, string state, string country, string phoneNo, string mobileNo, string emailid)
        //{
        //    _address = address;
        //    _city = city;
        //    _state = state;
        //    _country = country;
        //    _phoneNo = phoneNo;
        //    _mobileNo = mobileNo;
        //    _emailid = emailid;

        //}
        public String Address { get { return _address; } set { _address = value; } }
        public String City { get { return _city; } set { _city = value; } }
        public String State{ get { return _state; } set { _address = value; } }
        public String Country { get { return _country; } set { _country = value; } }
        public String PhoneNo { get { return _phoneNo; } set { _phoneNo = value; } }
        public String MobileNo { get { return _mobileNo; } set { _mobileNo = value; } }
        public String EmailId { get { return _emailid; } set { _address = value; } }

       


    }
}
