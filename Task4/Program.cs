using System;

class Program
{
    static void Main(string[] args)
    {
        
        // //Step 1 - Print numbers from 0 to 100 using a loop
        // for(int i = 0; i <= 100 ; i++){
        //     Console.WriteLine($".... and....{i}");
        // }

        //Step 2 - Recreate previous loop and iterate through it: 
        for (int i = 0; i <= 100; i++){
           
            if(i == 0){
                Console.WriteLine(i);
            } else if(i % 3 == 0 && i % 5 == 0){
                Console.WriteLine("FizzBuzz");
            } else if(i % 3 == 0){
                Console.WriteLine("Fizz");
            } else if (i % 5 == 0){
                Console.WriteLine("Buzz");
            } else {
                Console.WriteLine(i);
            };

        }        
        
        
        
        
        
        
        
        
        
        // print 0-100
        // for(int i=0; i < 101; i++)
        // {
        //     // make some conditions/
        //     // to print Fizz and/or Buzz
        //     // based on divisibility
        //     if(i % 3 == 0 && i % 5 ==0) 
        //     {
        //         Console.Write("Fizz");

        //         if(i % 5 ==0)
        //         {
        //             Console.WriteLine("Buzz");
        //         }
        //     }
        //     else if(i % 5 ==0)
        //     {
        //         Console.WriteLine("Buzz");
        //     }
        //     else
        //     {
        //         Console.WriteLine(i);
        //     }
        // }



    }
}
