using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ5
{
    public class LINQ_PROGRAM5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the names of employees");
            string[] arr = new string[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("The sorted list of names is :     ");
            var x = from i in arr orderby i ascending select i;
            foreach(var data in x)
            {
                Console.WriteLine(data);
            }
        }
    }
}
