using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQ1
{
    public class LINQ_Program1
    {
        public static void Main()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            var a = from i in arr where i > 10 select i;
            foreach (var data in a)
            {
                Console.WriteLine(data);
            }
        }
    }
}
