using System;
using System.Data.SqlTypes;

namespace practice
{
    class person
    {
        string name;
        string job;
        int salary;
        public string NAME
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }
        }
        public string JOB
        {
            get
            {
                return job;
            }
            set
            {
                job = value;
            }
        }
        public int SAL
        {
            get
            {
                return salary;

            }
            set
            {
                salary = value;
                if (salary >= 10000)
                {
                    start();
                }
                else
                {
                     stop();
                }
            }
           


        }
   
 
        public void start()
        {
            Console.WriteLine("Wow You can go for shopping");
        }
        public void stop()
        {
            Console.WriteLine("Sorry You don't have sufficient amount for shopping! Better Luck next time");
        }
    }
    class shop
    {
        public static void Main()
        {
            person obj = new person();
            Console.WriteLine("To find whether the employee is eligible for shopping or not enter the below details");
            Console.WriteLine("=================================================================================================>");

            Console.WriteLine("Enter the name of the employee");
            obj.NAME =Console.ReadLine();
            Console.WriteLine("Enter the job profile of the employee");
            obj.JOB = Console.ReadLine();
            Console.WriteLine("Enter the salary of the employee");
            obj.SAL = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}