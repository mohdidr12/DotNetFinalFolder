using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentConstructor
{
    class ContactInfoManager
    {
        public static void createContact(ContactInfo cs)
        {
            Console.WriteLine("enter details");
            Console.WriteLine("enter address");
            cs.Address=Console.ReadLine();
            Console.WriteLine("enter city");
            cs.City= Console.ReadLine();
            Console.WriteLine("enter state");
           cs.State= Console.ReadLine();
            Console.WriteLine("enter country");
            cs.Country = Console.ReadLine();
            Console.WriteLine("enter phoneNo");
            cs.PhoneNo = Console.ReadLine();
            Console.WriteLine("enter mobileNo");
           cs.MobileNo= Console.ReadLine();
            Console.WriteLine("enter emailId");
            cs.EmailId = Console.ReadLine();

        }

        public  static void displayContactDetails(ContactInfo cs)
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("The details are");
            Console.WriteLine(cs.Address);
            Console.WriteLine(cs.City);
            Console.WriteLine(cs.State);
            Console.WriteLine(cs.Country);
            Console.WriteLine(cs.MobileNo);
            Console.WriteLine(cs.PhoneNo);
            Console.WriteLine(cs.EmailId);

        }
        static void Main(string[] args)
        {
            ContactInfo cs = new ContactInfo();
            createContact(cs);
            displayContactDetails(cs);
            
        }
    }
}
