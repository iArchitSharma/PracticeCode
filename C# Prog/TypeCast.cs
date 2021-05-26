using System;

namespace code
{
    class TypeCast
    {
        static void Main(string[] args)
        {
            //TypeCasting in c#
            //Two types of TypeCasting 
            // 1) Implicit TypeCasting :- char to int to long to float to double
            int a = 50;
            double b = a; //Automaticaly typcasted from int into double

            //2) Explict Typecasting :- 
            int x = (int)5.5;      //Typecasting done manually
            Console.WriteLine(x);

            //Typecasting Using Methods :-
            float varr = Convert.ToInt32(3.55);
            //Convert.ToDouble
            //Convert.ToString
            Console.WriteLine(varr);


            
        }
    }
}
