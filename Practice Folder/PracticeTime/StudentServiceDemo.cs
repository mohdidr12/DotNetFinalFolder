using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTime
{
    class StudentServiceDemo : IStudentService
    {
        List<Student> list1 = new List<Student>();
        public Student AddStudent(string name, string id, byte age, byte standard, string city)
        {
            Student s = new Student(name, city, id, standard, age);
            list1.Add(s);
            return s;
        }
        public Student getStudentById(string id)
        {
            if(list1.Count!=0)
            {
                foreach(Student s in list1)
                {
                    if(s.ID==id)
                    {
                        return s;
                    }
                   
                }
                return null;
            }
            else
            {
                return null;
            }
        }
        public Student UpdateStudentAge(string id, byte age)
        {
            if (list1.Count != 0)
            {
                foreach (Student s in list1)
                {
                    if (s.ID == id)
                    {
                        s.Age = age;
                        return s;
                    }

                }
                return null;
            }
            else
            {
                return null;
            }
        }
        public Student UpdateStudentCity(string id, string city)
        {
            if (list1.Count != 0)
            {
                foreach (Student s in list1)
                {
                    if (s.ID == id)
                    {
                        s.City = city;
                        return s;
                    }

                }
                return null;
            }
            else
            {
                return null;
            }
        }
       public void DisplayAll()
        {
            if(list1.Count!=0)
            {
                foreach(Student s in list1)
                {
                    Console.WriteLine("Id is " + s.ID);
                    Console.WriteLine("Name is  " + s.Name);
                    Console.WriteLine("Age is  " + s.Age);
                    Console.WriteLine("Standard is " + s.Standard);
                    Console.WriteLine("City is " + s.City);
                }
            }
            else
            {
                Console.WriteLine("there is no students to display, please add some");
            }
        }
      public bool DeleteStudent(string id)
        {
            if(list1.Count!=0)
            {
                Student std = getStudentById(id);
                if (std != null)
                {
                    list1.Remove(std);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
