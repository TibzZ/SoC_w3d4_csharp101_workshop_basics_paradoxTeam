using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine($"The integer is {i}");
            }

            {
                for (char i = 'a'; i <= 'm'; i++)
                {
                    Console.WriteLine($"The letter is {i}");
                }
            }
        }
    }
}
