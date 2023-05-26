using System;

public class Solution
{
    public class Person
    {
        private int age;

        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if (initialAge > 0)
            {
                age = initialAge;
            }
            else
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                age = 0;
            }
        }

        public void amIOld()
        {
            // Write code determining if this person's age is old and print the correct statement:
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            // Increment this person's age.
            age++;
        }
    }

    public static void Main(string[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            Person p = new Person(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
    }
}
