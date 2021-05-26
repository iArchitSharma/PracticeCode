using System;

namespace code
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            //Switch Case Statment
            int age =50;

            switch (age)
            {
                case 18: 
                      Console.WriteLine("Please wait for an year");
                      break;
                case 20: 
                Console.WriteLine("You are 20");
                break;
                
                default:
                Console.WriteLine("Enjoy");
                break;
            }
            
        }
    }
}
