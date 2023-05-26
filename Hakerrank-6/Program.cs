using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string str = Console.ReadLine();

            for (int j = 0; j < str.Length; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(str[j]);
                }
            }

            Console.Write(" ");

            for (int j = 0; j < str.Length; j++)
            {
                if (j % 2 != 0)
                {
                    Console.Write(str[j]);
                }
            }

            Console.WriteLine();
        }
    }
}
