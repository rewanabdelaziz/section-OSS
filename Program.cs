using System;
namespace Rewan;
public class Rewan{
    private static void Main()
    {  
         //task 1
        Console.WriteLine("Enter a string");
         string str=Console.ReadLine();
         var rev="";
         int j;
         for(j=str.Length-1; j>=0 ;j--){
            rev+=str[j];
         }
          Console.WriteLine(rev);

       
    }
}
