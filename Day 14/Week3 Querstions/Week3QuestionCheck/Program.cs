using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3QuestionCheck
{
    class list
    {
        ArrayList array = new ArrayList();
        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Count)
                {
                    return null;
                }
                else
                {
                    return (array[index]);
                }
            }
            set
            {
                array[index] = value;
            }
        }
        public int Count
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            list list1 = new list();
            list1[0] = "123";
            list1[1] = " abc ";
            list1[2] = "xyz";
            for (int i = 0; i <= list1.Count; i++)
                Console.WriteLine(list1[i]);
            Console.ReadLine();
        }
    }
}
