

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static void solve(double Ürünün_Fiyatı, int Bahşiş_Yüzdesi, int Vergi_Yüzdesi)
    {
        
        var tip= Bahşiş_Yüzdesi * Ürünün_Fiyatı / 100;
        var Vergi= Vergi_Yüzdesi * Ürünün_Fiyatı / 100;
       
        var Toplam= Math.Round(Ürünün_Fiyatı + tip + Vergi);
       
        Console.WriteLine($"{Toplam}");
       

    }

}

class Solution
{
    public static void Main(string[] args)
    {   Console.WriteLine("Ürünün Fiyatını Giriniz");
        double Ürünün_Fiyatı = Convert.ToDouble(Console.ReadLine().Trim());

        Console.WriteLine("Ürünün Bahşiş Yüzdesini Giriniz");
        int Bahşiş_Yüzdesi = Convert.ToInt32(Console.ReadLine().Trim());

        Console.WriteLine("Ürünün Vergi Yüzdesi Giriniz");
        int Vergi_Yüzdesi = Convert.ToInt32(Console.ReadLine().Trim());
        
        Console.WriteLine("Ürünün Toplamı");
        Result.solve(Ürünün_Fiyatı, Bahşiş_Yüzdesi, Vergi_Yüzdesi);
    }
}
