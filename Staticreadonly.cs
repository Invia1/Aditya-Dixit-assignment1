class Staticreadonlyvar
{
     static readonly int employeeid;
    string ename;
    string edept;

    static Staticreadonlyvar()
    {
        employeeid = 299;
            }
    public static void Main()
    {
        Staticreadonlyvar obj = new Staticreadonlyvar();
        obj.ename = "Ramesh";
        obj.edept = "computers";
        Console.WriteLine(employeeid);
        Console.WriteLine(obj.ename);
        Console.WriteLine(obj.edept);


    }


}