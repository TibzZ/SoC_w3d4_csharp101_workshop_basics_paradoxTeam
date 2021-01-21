using System;

namespace using_and
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1 = 7.5f;
            float number2 = 9.5f;

            if (number1 > number2 && number1 + number2 >= 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}