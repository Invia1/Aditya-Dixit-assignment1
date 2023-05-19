using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ3
{
    public class LINQ3_PROGRAM3
    {
        public static void Main(string[] args)
        {
            string[] str = new string[5];
            Console.WriteLine("enter the 5 employee names: ");
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            var x = from item in str where str.Length>4 select item;
            foreach (var data in x)
            {
                Console.WriteLine(data);
            }

          
        }
    }
 }

