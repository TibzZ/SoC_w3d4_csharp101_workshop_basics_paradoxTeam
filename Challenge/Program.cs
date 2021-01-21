using System;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int sum = 0;
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
