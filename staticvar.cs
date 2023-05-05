using System;
class staticvar{
    static string company;
    string ename;
    int eid;
    public static void initialize(){
        company="Invia Learning Center";
    }
  public static void Main(){
staticvar obj=new staticvar();
staticvar.company="Invia pvt ltd";
obj.ename="Aditya";
obj.eid=101;
  }  
}