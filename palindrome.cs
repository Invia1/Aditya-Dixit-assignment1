using System;
class palindrome{
    int count=0;
    public static void Main(){
       palindrome obj=new palindrome(); 
        string n=Console.ReadLine();
        string x="";
        for (int i=n.Length-1;i>=0;i--){
            x=x+n[i];
        }
        for (int i=0;i<n.Length;i++){
            if (n[i]==x[i]){
                obj.count++;
            }
        }
        if (obj.count==n.Length){
            Console.WriteLine("Palindrome");
        }
        else{
            Console.WriteLine("Not a palindrome");
        }
    }
}