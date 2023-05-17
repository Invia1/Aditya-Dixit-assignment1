using System;
using System.Security.Cryptography.X509Certificates;
using HospitalManagementTest.Model;
using HospitalManagementTest.UI;

namespace HospitalManagementTest.Service
{
    public class Patientservice
    {
        List<Patient> d = new List<Patient>();
      
        public int addPatient(Patient p)
        {
            d.Add(p);
            Console.WriteLine("Patient added Successfully: ");
            return 1;
        }
        public int removePatient(Patient p)
        {
            d.Remove(p);
            return 1;
        }
        public List<Patient> getPatientList()
        {
            foreach (var data in d)
            {
                Console.WriteLine(data.id+" "+data.fname+" "+data.lname+" "+data.phone+" "+data.gender+" "+data.age+" "+data.address+" "+data.adharno+" "+data.speciality);
            }
            return d;
        }
    }
}
