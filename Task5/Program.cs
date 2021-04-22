using System;

class Program
{
    static void Main(string[] args)
    {
        var rand = new Random();

        // Generate and display 5 random byte (integer) values.
       Console.WriteLine($"{rand.Next(0,6)}");

    }
}

