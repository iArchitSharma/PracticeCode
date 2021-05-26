using System;

namespace code
{
    class StringMethods
    {
        static void Main(string[] args)
        {
            //String Methods
            String x = "Hello earth this is string Functions";
            Console.WriteLine(x.Length);
            Console.WriteLine(x.ToUpper());
            Console.WriteLine(x.ToLower());
            Console.WriteLine(x[2]);  //Accesing String characters
            Console.WriteLine(x.IndexOf("earth"));  //Gives the index
            Console.WriteLine(x.Substring(4));  //From index for print the string
            Console.WriteLine(string.Concat(x,", I hope you like it"));
            String name = "Iible";
            int marks = 40;
            Console.WriteLine($"{name} scored {marks} marks in Computer Science"); //String Interpolation
            
        }
    }
}
