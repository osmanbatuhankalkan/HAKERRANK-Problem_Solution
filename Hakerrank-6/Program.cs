using System;

namespace HackerRank_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kaç tane string değer alacağımızı kullanıcıdan alalım
            Console.WriteLine("Değer Girin");
            int degerString = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                // Her bir string değeri kullanıcıdan alalım
                string str = Console.ReadLine();

                for (int a = 0; a < str.Length; a++)
                {
                    if (a % 2 == 0)
                    {
                        Console.WriteLine(str[a]);
                    }
                    else
                    {
                        Console.WriteLine(str[a]);
                    }
                }

                Console.WriteLine(str);
            }
        }
    }
}
