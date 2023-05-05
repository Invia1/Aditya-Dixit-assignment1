using System;
class Character{
    public static void Main(){
       
        string n=Console.ReadLine();

        for (int i=0;i<n.Length;i++){
             int c=0;
            for (int j=0;j<n.Length;j++){
if (n[i]==n[j]){
    c++;
}
            }
            Console.WriteLine(n[i]+" is repeated "+ c +" times");
        }
    }
}