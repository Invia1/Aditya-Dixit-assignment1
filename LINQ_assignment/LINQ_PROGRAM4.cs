using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ4
{
    public class LINQ4_PROGRAM4
    {
       public static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            var x = from value in arr where value> 0 select value;
            foreach (var item in x)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item + " is even");
                }
                else
                {
                    Console.WriteLine(item + " is odd");
                }
            }
          
        }
    }
}
