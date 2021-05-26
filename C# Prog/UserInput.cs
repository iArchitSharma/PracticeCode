using System;

namespace code
{
    class UserInput
    {
        static void Main(string[] args)
        {
            //Taking User Input in c#
            Console.WriteLine("Enter Your Name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            int year = DateTime.Now.Year;   //To get current year
            int born = year-age;
            Console.WriteLine("Your name is - "+name);
            Console.WriteLine("Your age is - "+age);
            Console.WriteLine("You were born  in this year - "+born);
            
        }
    }
}
