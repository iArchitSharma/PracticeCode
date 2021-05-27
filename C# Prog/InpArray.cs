//To input Array in c#
using System;

namespace code
{
    class ArrayLoop
    {
        static void Main(string[] args)
        {
            //Array of x element
            Console.WriteLine("Specify the size of Array");
            int size = int.Parse(Console.ReadLine());
            int[] numb = new int[size];
            for(int i=0;i<numb.Length;i++){
                Console.WriteLine($"Enter number for {i} position");
                numb[i]= int.Parse(Console.ReadLine());

            }
            Console.WriteLine("No. inside you arrays are : ");
            foreach(int j in numb){
                Console.WriteLine(j);
            }


            
        }
    }
}
