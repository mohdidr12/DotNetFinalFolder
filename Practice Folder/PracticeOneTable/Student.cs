using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOneTable
{
    class Student
    {
        string id, name, city;
        byte age, standard;
        public Student(string id,string name,byte age,byte standard,string city)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.standard = standard;
            this.city = city;
        }
        public string Id   // property
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public byte Age   // property
        {
            get { return age; }   // get method
            set { age = value; }  // set method
        }
        public byte Standard   // property
        {
            get { return standard; }   // get method
            set { standard = value; }  // set method
        }
        public string City   // property
        {
            get { return city; }   // get method
            set { city = value; }  // set method
        }
    }
}
