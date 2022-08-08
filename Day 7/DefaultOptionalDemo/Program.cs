using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultOptionalDemo
{
    class Program
    {
        static public void detail(string ename,int eid=12,string bgrp="A+",string dept="Review-Team")
        {
            Console.WriteLine("Employee name{0}", ename);
            Console.WriteLine("Employee ID:{0}",eid);
            Console.WriteLine("Blood Group:{0}",bgrp);
            Console.WriteLine("Department:{0}",dept);

        }
        private int Add(int x,int y,int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            detail("pqr");
            detail("ABCD", 14);
            detail("XYZ\n", 123);
            detail("ABC\n", 456, "A-");
            detail("DEF\n", 789, "B+", "Software Developer");

            Program ps = new Program();
            int result = ps.Add(y: 50, x: 20, z: 12);
            Console.WriteLine("instance Method output" + result);
            Console.ReadLine();
        }
    }
}
