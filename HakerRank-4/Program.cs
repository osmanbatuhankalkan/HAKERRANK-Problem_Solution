using System;
using System.Collections.Generic;
using System.IO;

namespace Person
{
class program
        {
    static void Main(String[] args) {
        System.Console.WriteLine("a");
        int age=int.Parse(Console.ReadLine());
            
        if(age<=0)
        {
            System.Console.WriteLine("Age is not valid, setting age to 0.");
        } 
        else if(age<13)
        {
            System.Console.WriteLine("You are young");
        }
        else if(age>=13 && age<18)
        {
            System.Console.WriteLine("you are a teenager");
            
        } 
        else
            System.Console.WriteLine("You are old");
            
        }

    }
}
