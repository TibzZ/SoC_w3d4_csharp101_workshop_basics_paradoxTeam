﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // print 0-100
        for(int i=0; i < 101; i++)
        {
            // make some conditions/
            // to print Fizz and/or Buzz
            // based on divisibility
            if(i % 3 == 0 && i % 5 ==0) 
            {
                Console.Write("Fizz");

                if(i % 5 ==0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            else if(i % 5 ==0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }



    }
}
