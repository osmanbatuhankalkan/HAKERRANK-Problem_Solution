using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int sonuc1;
        double degisken2;
        
        // Declare second integer, double, and String variables.
        Console.WriteLine("Lütfen ilk int degeri giriniz ");
        int degisken1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen ikinci olarak double degeri giriniz ");
         degisken2 = double.Parse(Console.ReadLine());
         
         string k = "is the best place to learn and practice coding!";
        // string degisken = Console.ReadLine();
        
         sonuc1 = i + degisken1;
         
        Console.WriteLine(sonuc1);
        
        Console.WriteLine(String.Format("{0:0.0}"+ d + degisken2));
        Console.WriteLine(s + k);
        // Read and save an integer, double, and String to your variables.
        
        // Print the sum of both integer variables on a new line.
        
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

    }
    }