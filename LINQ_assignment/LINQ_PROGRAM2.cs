using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQ2
{
    public class LINQ2_PROGRAM2
    {
        public static void Main()
        {
            int[] array = { -1, -2, -3, 4, 5, 6, 7, 8, 9 };
            var a = from x in array where x > 0 select x;
            foreach (var x in a)
            {
                Console.WriteLine(x);
            }
        }
    }
}
