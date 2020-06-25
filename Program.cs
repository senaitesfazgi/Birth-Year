using System;

namespace BirthYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting user to enter age
            Console.WriteLine("Enter your age");
            //Allowing user to input their age
            int age = int.Parse(Console.ReadLine());

            //Calculating birth year
            int birthYear = 2020 - age;
            Console.WriteLine("Your birth year is {0}", birthYear);
        }
    }
}
