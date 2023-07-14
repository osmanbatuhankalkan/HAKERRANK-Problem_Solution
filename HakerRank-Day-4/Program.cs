using System;
using System.Collections.Generic;
using System.IO;
public class Solution
{
    public class Person
    {
        private int age;

        public Person(int initialAge)
        {
            
            if(-5 <= initialAge &&  initialAge<= 30) 
            {
                age = initialAge;
            }
            if (1<= initialAge && initialAge<=4)
            {   
                age = initialAge;
                Console.WriteLine("Age is not valid, setting age to 0.");//1 ve 4 aralığına girilip 1. burası okunuyor ve yazılıyor
            }
            else if (initialAge > 0)
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
            
            if (1<= age && age <=4)
            {
                Console.WriteLine("You are young.");//4 ile -1 girildiğinde 2. you are young burdan geliyor
                
            }
             else if (age < 13)
            {
                Console.WriteLine("You are young.");//4 ile -1 girildiğinde 3. you are young burdan geliyor
            }
            else if (age >=13 && age < 18)
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


static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person p=new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}
