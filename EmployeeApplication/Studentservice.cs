using System;
using assignment5.Model;

namespace assignment5.Service
{
    public class Studentservice
    {
        List<Student> objst = new List<Student>();
        public int StudentAdmission(Student s)
        {
            objst.Add(s);
          
            return 1;
        }
      
        public int removestudent(Student s)
        {
            objst.Remove(s);
            Console.WriteLine("Removed Successfully");
           
            return 1;
        }
        public List<Student> GetStudent()
        {
            return objst;
        }
    }
}
