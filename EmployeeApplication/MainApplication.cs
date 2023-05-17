using System;
using assignment5.Model;
using assignment5.Service;

namespace assignment5.UI
{
    public class MainApplication
    {
        public static void Main()
        {
            Student obj1 = new Student();
            Studentservice ss = new Studentservice();


            Console.WriteLine("Press 1 for Add: ");
            Console.WriteLine("Press 2 for update: ");
            Console.WriteLine("Press 3 for search: ");
            Console.WriteLine("Press 4 for remove: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter the id of student: ");
                    obj1.sid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the name of student: ");
                    obj1.name = Console.ReadLine();
                    Console.WriteLine("Enter the age of student: ");
                    obj1.age = Convert.ToInt32(Console.ReadLine());
                   
                    ss.StudentAdmission(obj1);
                    Console.WriteLine("Added Successfully");
                    ss.GetStudent();

                    break;

                case 2:
                    Console.WriteLine("Enter the id of the student:");
                    obj1.sid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the name of the student:");
                    obj1.name = Console.ReadLine();

                    Console.WriteLine("Enter the age of the student:");
                    obj1.age = Convert.ToInt32(Console.ReadLine());
                    ss.removestudent(obj1);
                    Console.WriteLine("Removed Successfully...");
                    ss.GetStudent();

                    break;

              
                    








                    break;




            }

        }

    }
}
