using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlLinqDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xelement = XElement.Load(@"C:\Users\mohd.idris\source\repos\DotNetFinalFolder\Day 21\XmlLinqDemo2\Customers.xml");
            var dict = (from element in xelement.Descendants("Customer")
                        let name = (string)element.Attribute("Name")
                        orderby name
                        select new
                        {
                            CustID = element.Attribute("CustId").Value,
                            CustName = name
                        }).ToDictionary(c => c.CustID, c => c.CustName);

            foreach(var item in dict)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();
        }
    }
}
