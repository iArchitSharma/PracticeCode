using System;
using System.Linq; //.Min .Max .Sum value in Array
namespace code
{
    class ArrayMethods
    {
        static void Main(string[] args)
        {
            //Arrays Methods
            // 1) Sort Array - Sort alphabetically or in an ascending order
            int[] numbs = {44,67,23,4,2,9,1,12};
            Array.Sort(numbs);
            foreach(int i in numbs){
                Console.WriteLine(i);
            }
            //System.Linq namespace
            int[] myNumbers = {5, 1, 8, 9};
             Console.WriteLine(myNumbers.Max());  // returns the largest value
             Console.WriteLine(myNumbers.Min());  // returns the smallest value
             Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            
        }
    }
}
