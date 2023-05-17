using System;
using HospitalManagementTest.Model;
using HospitalManagementTest.Service;

namespace HospitalManagementTest.UI
{
    public class Mainapp
    {

        public static void Main()
        {
            Patient obj = new Patient();
            
            Patientservice ps = new Patientservice();
            Console.WriteLine("Press 'y' to Start: ");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == 'y')
            {

                while (c == 'y')
                {
                    Console.WriteLine("Press 1 for Adding new Patient: ");
                    Console.WriteLine("Press 2 for display all Patients: ");
                    Console.WriteLine("Enter your Choice: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int i = 0;


                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Enter first name of Patient: ");
                            obj.fname = Console.ReadLine();
                            Console.WriteLine("Enter last name of Patient: ");
                            obj.lname = Console.ReadLine();
                            obj.id = i++;
                            Console.WriteLine("Enter phone no. of Patient: ");
                            obj.phone = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter gender of Patient: ");
                            obj.gender =Console.ReadLine();
                            Console.WriteLine("Enter age of Patient: ");
                            obj.age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter address of Patient: ");
                            obj.address = Console.ReadLine();
                            Console.WriteLine("Enter adharno of Patient: ");
                            obj.adharno = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter speciality of Patient: \n");
                            obj.speciality = Console.ReadLine();

                            Console.WriteLine("Unique Id of " + obj.fname + " " + obj.lname + " is: " + i);
                            ps.addPatient(obj);

                            Console.WriteLine("These are the patients list of Hospital: ");


                            break;

                        case 2:
                          
                            ps.getPatientList();
                            break;
                        
                         
                       



                    }
                    Console.WriteLine("Press 'y' to continue or other key to stop..");
                    Console.WriteLine("\n");

                }
            }
            else
            {
                Console.WriteLine("Wrong button pressed,again restart the program....");
            }



        }
    }
}
