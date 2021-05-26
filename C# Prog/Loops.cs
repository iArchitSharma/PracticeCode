using System;

namespace code
{
    class Loops
    {
        static void Main(string[] args)
        {
            //Loops in c#
            //While Loop
            //continue - Leave this particular iteration of loop forever
            //break - Leave this loop forever
            int i =1;
            while(i<=20){
                Console.WriteLine(i);
                i++;
            }

            //For Loops
            for(i=1;i<=20;i++){
                if(i==1){
                    continue;
                }
                Console.WriteLine(i);
            }

            //Do while loop - executes alteast one time
            do{
                Console.WriteLine(i+1);
                i++;
            }while(i<20);
            
        }
    }
}
