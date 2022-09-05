using System;
using System.Threading;
using System.Threading.Tasks;
namespace MultiThreadingDemoConsole
{
    class Program
    {
        public async static void Method()
        {
            await Task.Run(new Action(longTask));
            Console.WriteLine("New Thread");
            Console.ReadLine();
        }
        public static void longTask()
        {
            Thread.Sleep(20000);
            Console.WriteLine("Second Thread");
        }
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }
    }
}
