using System;

namespace Methods
{
    class MethodParameters
    {
        static void myMethod(String x){       //x is a Parameter
            Console.WriteLine($"Hi I am a {x}");

        }
        static int hi(int y = 10,int z = 10){
            return z*y;
        }
        static void Main(string[] args)
        {
            //Methods
            myMethod("Parameter");
            Console.WriteLine(hi());//It will use default value as not argument is passed

            Console.WriteLine(hi(z:42,y:2));//send arguments with the key: value syntax
            
        }
    }
}