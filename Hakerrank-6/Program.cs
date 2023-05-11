using System;
namespace HakerRank_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //kaç tane string deger alacağımızı yazalım
            System.Console.WriteLine("Değer Girin");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<10; i++ )
            {   
                for(int a=0; a<n.Length; a++)
                {
                    if(n%2==0)
                    {
                        System.Console.WriteLine(n);
                    }
                    else
                        System.Console.WriteLine(n);
                }
                System.Console.WriteLine(n);
                //Console.ReadKey();
            }
        }
    }
}