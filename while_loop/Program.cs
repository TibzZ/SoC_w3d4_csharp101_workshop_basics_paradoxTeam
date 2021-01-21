using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 15)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }

        }
    }
}
