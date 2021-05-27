using System;

namespace Methods
{
    class Method
    {
        static void myMethod(){       //void: means that this method does not have a return value
            Console.WriteLine("I just got executed!");

        }
        static void Main(string[] args)
        {
            //Methods
            myMethod();
            myMethod(); //Method can be called multiple times
        }
    }
}