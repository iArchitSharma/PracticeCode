using System;

namespace code
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //Arrays in c#
            String[] cars = {"BMW","Audi","Mercedes","Volvo","Ford"};
            cars[2] = "Maruti";//To change the value of a specific element
            Console.WriteLine(cars.Length);//Length of Array
            Console.WriteLine(cars[3]);
            
        }
    }
}
