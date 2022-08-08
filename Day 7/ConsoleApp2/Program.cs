using System;

namespace ConsoleApp2
{
    interface Test1
    {
        void Testing();
        
    }
    interface Test2
    {
        void Testing();
    }

    class Test3 : Test1,Test2
    {
        // Imlicit interface demo
            public  void Testing()
        {
            Console.WriteLine("Demo of Abstract Class");
        }
        //Explicit interface calling
        void Test1.Testing()
        {
            Console.WriteLine("I am from the first interface");
        }
        void Test2.Testing()
        {
            Console.WriteLine("I am from the second interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = {5,45,32,100,677,2,6};

            //Console.WriteLine("Max No is "+arr.Max());
            //Console.WriteLine(arr.Sum());
            //Console.WriteLine(arr.Min());

            // string[] cars;
            // cars = new string[] { "BMW" ,"SUZUKI","MARSH"};
            //int[,] arr2 = new int[4, 2];
            //Console.WriteLine("enter the input values in 2D");
            //for(int i=0;i<4;i++)
            //{
            //    for(int j=0;j<2;j++)
            //    {
            //        arr2[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(arr2[i, j]);
            //    }
            //}
            //Console.WriteLine("enter the values in 3D");
            //   int[,,] arr3 = new int[2, 2, 2];
            //for(int i=0;i<2;i++)
            //{
            //    for(int j=0;j<2;j++)
            //    {
            //        for(int z=0;z<2;z++)
            //        {
            //            arr3[i, j, z] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        for (int z = 0; z < 2; z++)
            //        {
            //            Console.WriteLine(arr3[i,j,z]);
            //        }
            //    }
            //}


            //string firstName = "John ";
            //string lastName = "Doe";
            //string name = string.Concat(firstName, lastName);
            //Console.WriteLine(name);
            //String name = "\a\a\aHello guys How are you";
            //String[] name2 = name.Split(" ");
            //Console.WriteLine(name2[1]);
            //Program p1 = new Program();
            //p1.Test();
            Test3 t3 = new Test3();
            t3.Testing();
            Test1 t1 = new Test3();
            t1.Testing();
            Test2 t2 = new Test3();
            t2.Testing();
        }
            // void Test()
            //{
            //    Console.WriteLine("test the instance method ");
            //}
           

        }
    }
