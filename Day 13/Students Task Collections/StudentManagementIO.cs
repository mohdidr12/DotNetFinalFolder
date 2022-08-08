﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Task_Collection
{
    class StudentManagementIO
    {
        StudentService studentservice = new StudentService();
        
        public byte Menu()
        {
            Console.WriteLine("Press 1 to Add Student");
            Console.WriteLine("Press 2 to View All Students");
            Console.WriteLine("Press 3 to Update Student");
            Console.WriteLine("Press 4 to Delete Student");
            Console.WriteLine("Press 5 to Exit");
            Console.WriteLine("Enter Your choice:");
            try
            {
                byte option = Convert.ToByte(Console.ReadLine());
                return option;
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a Valid Input\n");
                return Menu();
            }
        }

        public void AddStudent()
        {
            try
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter ID:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                byte age = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter Class:");
                byte standard = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter City:");
                string city = Console.ReadLine();
                Student student = studentservice.AddStudent(name, id, age, standard, city);
                Display(student);
                Console.WriteLine("".PadLeft(15, '-'));
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a Valid Input\n");
                AddStudent();
            }
            
        }

        private void Display(Student student)
        {
            if(student == null)
            {
                Console.WriteLine("Student Not Found");
            }
            else
            {
                Console.WriteLine("".PadLeft(15, '-'));
                Console.WriteLine("ID: " + student.ID);
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Age: " + student.Age);
                Console.WriteLine("Class: " + student.Standard);
                Console.WriteLine("City: " + student.City);
            }
        }
        
        public void DisplayAll()
        {
            Console.WriteLine();
            studentservice.DisplayAll();
            Console.WriteLine();
        }

        public void DeleteStudent()
        {
            try 
            {
                Console.WriteLine("Enter Id:");
                string id = Console.ReadLine();
                if (studentservice.DeleteStudent(id))
                {
                    Console.WriteLine("Student deleted successfully");
                }
                else
                {
                    Console.WriteLine("Student Not Found!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a Valid Input\n");
                DeleteStudent();
            }
        }

        public void UpdateStudent()
        {
            Console.WriteLine("Press 1 to update age");
            Console.WriteLine("Press 2 to update city");
            Console.WriteLine("Enter Your Choice");
            try
            {

                switch (Convert.ToByte(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter Id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Age:");
                        byte age = Convert.ToByte(Console.ReadLine());
                        Display(studentservice.UpdateStudentAge(id, age));
                        break;

                    case 2:
                        Console.WriteLine("Enter Id:");
                        string Id = Console.ReadLine();
                        Console.WriteLine("Enter Age:");
                        string city = Console.ReadLine();
                        Display(studentservice.UpdateStudentCity(Id, city));
                        break;

                    default:
                        Console.WriteLine("Enter a Valid Option");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a Valid Input\n");
                UpdateStudent();
            }
        }
    }
}
