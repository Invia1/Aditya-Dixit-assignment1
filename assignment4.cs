using System;


class employeeDetails
{
    List<string> o1 = new List<string>() {"aditya" ,"aman","ramesh","virat"};
    List<int> o2 = new List<int>() { 1,2,3,4};
    public void adddetails()
    {
        Console.WriteLine("Enter the name:");
        o1.Add(Console.ReadLine());
        Console.WriteLine("Enter the ID:");
        o2.Add(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("the list has follwoing names:");
        foreach (var item in o1)
        {
            Console.WriteLine(item+" ");
          
        }
        Console.WriteLine("The List has following IDS respectively:");
        foreach (var item1 in o2)
        {
            Console.WriteLine(item1);
        }

    }
    public void insertdetails()
    {
        Console.WriteLine("please specify index :");

        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please insert name:");
        o1.Insert(y, Console.ReadLine());
        Console.WriteLine("Please enter the ID:");
        o2.Insert(y,Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("the list has names-");
        foreach (var item in o1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("and their respective IDS are:");
        foreach(var item1 in o2)
        {
            Console.WriteLine(item1);
        }
    }
  
    public void removedetails()
    {
        Console.WriteLine("The List of employees is this: ");
        foreach (var item in o1)
        {
            Console.WriteLine(item + " ");

        }
        Console.WriteLine("The List has following IDS respectively:");
        foreach (var item1 in o2)
        {
            Console.WriteLine(item1);
        }
        Console.WriteLine("Enter the name which you want to remove:");
        string g = Console.ReadLine();
        Console.WriteLine("Enter the ID you want to remove:");
        int h = Convert.ToInt32(Console.ReadLine());
        o1.Remove(g);
        o2.Remove(h);
        Console.WriteLine("the list has following names:");
        foreach (var item in o1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("the list has following ID:");
        foreach (var item1 in o2)
        {
            Console.WriteLine(item1);
        }
    }
   
   
}
class employee
{
    public static void Main()
    {
        var ob = new employeeDetails();
        Console.WriteLine(" For adding the data,press 1");
        Console.WriteLine("For inserting the data,press 2");
        Console.WriteLine("For removing the data,press 3");

        Console.WriteLine("Please enter your choice:");
        int m = Convert.ToInt32(Console.ReadLine());

        switch (m)
        {
            case 1:
                {
                    ob.adddetails();
                    break;
                }
            case 2:
                {
                    ob.insertdetails();
                    break;
                }
            case 3:
                {
                    ob.removedetails();
                    break;
                }

        }
    }
}