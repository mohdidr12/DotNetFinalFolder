using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    class MyCustomException :Exception
    {
       public MyCustomException()
        {
            Console.WriteLine("errors");
        }
    }
}
