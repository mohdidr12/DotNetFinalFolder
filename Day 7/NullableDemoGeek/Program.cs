using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableDemoGeek
{
    class Program
    {
      static void Main(string[] args)
        {
            Nullable<int> j = null;
            int? i = null;
            int? z = 456;
           Console.WriteLine( j.GetValueOrDefault());
           Console.WriteLine( i.GetValueOrDefault());
           Console.WriteLine(z.GetValueOrDefault());
            Console.ReadLine();
        }
    }
}
