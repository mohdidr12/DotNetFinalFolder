using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassLibrary1Demo;

namespace ConsoleApp1
{
    
            /*   
               int i, fact = 1;
               Console.WriteLine("enter the number which you want calculate factorial ");
               int number = Convert.ToInt32(Console.ReadLine());
               for (i = 1; i <= number; i++)
               {
                   fact = fact * i;
               }
               Console.WriteLine("Factorial of " + number + " is: " + fact);
               Console.ReadLine();

             */
            // Fibonacci Series
            /*    
                int n1 = 0, n2 = 1, n3, i;
                Console.WriteLine("enter the range of series");
                 int count = Convert.ToInt32(Console.ReadLine());
                Console.Write(n1 + " " + n2); 

                for (i = 2; i < count; ++i)   
                {
                    n3 = n1 + n2;
                    Console.Write(" " + n3);
                    n1 = n2;
                    n2 = n3;
                }
                Console.ReadLine();
            

            const string name = "sdg";
            const string location = "Bangalore";
            const int age = 32;

            //const string name = "Rohini Iyengar";

            Console.WriteLine("Name "+ name);
          //  Console.WriteLine("Location:{0}",location);
          //  Console.WriteLine("Age:{0}",age);
            Console.WriteLine("\nPress Enter Key to Exit...{0},{1}",age,location);
            Console.ReadLine();
            
            string str = "1234";
            int n = int.Parse(str);
            Console.WriteLine(n);
            Console.ReadLine();
            
            int i = 1;
            do
            {
                
                Console.WriteLine(i);
                i++;

            }

            while (i <= 10);
            
            // palindrome program ---------------------------------------------------------------------------------------------

            Console.WriteLine("enter the number");
            
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int rem = 0, sum = 0;
            while(n>0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;


            }
            if(temp==sum)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not a palindrome");
            }
            Console.WriteLine("enter the string");
            String str = Console.ReadLine();
            String rev = "";
            for(int i=str.Length-1;i>=0;i--)
            {
                rev += str[i].ToString();
            }
            if(rev==str)
            {
                Console.WriteLine("string is  palindrome");
            }
            else
            {
                Console.WriteLine("string is not a palindrome");
            }
            Console.ReadKey();
             

            // Armstrong program -----------------------------

            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int temp = 0, digits = 0,last=0;
            double sum = 0;
            temp = n;
            while(temp>0)
            {
                temp = temp / 10;
                digits++;
            }
            temp = n;
            while(temp>0)
            {
                last = temp % 10;
                sum += (Math.Pow(last, digits));
                temp = temp / 10;
            }
            if(sum==n)
            {
                Console.WriteLine("number is armstrong");
            }
            else
            {
                Console.WriteLine("number is not a  armstrong");
            }
            Console.ReadKey();
            

              Class1 obj = new Class1();
              int n = obj.sum(3, 4);
              int m = obj.diff(5, 3);
              int j = obj.mul(5, 3);
              Console.WriteLine("sum is" + n);
              Console.WriteLine("diff is " + m);
              Console.WriteLine("mul is" + j);
              Console.ReadLine();
             
          
            //program to print array in reverse

            Console.WriteLine("enter the size of Array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
           
                    arr.Reverse();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



            //copy the elements of one array into another array
            
            Console.WriteLine("enter the size of Arrays");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr1 = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }
            Console.WriteLine("elements in Second Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
         

            // find the sum of all elements of the array

            Console.WriteLine("enter the size of Array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
            
     
            //count total no of duplicate elements in an array
            /*

            Console.WriteLine("enter the size of Array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the array values");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("duplicate elements in array");
            for(int i=0;i<arr.Length;i++)
            {
                for(int  j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        Console.WriteLine(arr[j]);
                    }
                }
            }
           
            // find the total no of occurence of each element of array
            Console.WriteLine("enter the size of Array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the array values");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("No of Occurence of  elements in array");
           
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                     }
                    
                }
                Console.WriteLine(arr[i] + " " + count);
            }
            
            public abstract class MyClass

        {
            public void aa()
            {
                Console.WriteLine("this is not abstract method");

            }
            public abstract void calculate(double x);
        }
        class Sub1 : MyClass
        {
            public override void calculate(double x)
            {
                base.aa();
                Console.WriteLine("Square root is " + Math.Sqrt(x));
                Console.ReadLine();
            }
        }
        public class Sub2 : MyClass
        {
            public override void calculate(double x)
            {
                base.aa();
                Console.WriteLine("Square is  " + (x * x));
                Console.ReadLine();
            }
        }
        public class Sub3 : MyClass
        {
            public override void calculate(double x)
            {
                base.aa();
                Console.WriteLine("Cube  is  " + (x * x * x));
                Console.ReadLine();
            }
        }
        public class Sub4 : MyClass
        {
            public override void calculate(double x)
            {
                Console.WriteLine("add is " + (x + x));
                Console.ReadLine();
            }
        }
            
        class Program
        {
            static void Main(String[] args)
            {
                Sub1 sb = new Sub1();
                Sub2 sb2 = new Sub2();
                Sub3 sb3 = new Sub3();
                Sub4 sb4 = new Sub4();
                sb.calculate(4);
                sb2.calculate(5);
                sb3.calculate(8);
                sb4.calculate(9);

            }
        }
            */
             
           
         










    }
    