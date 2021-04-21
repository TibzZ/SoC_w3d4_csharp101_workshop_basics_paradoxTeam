using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Task 2!");

        Console.Write("I will need to ask your name again, sorry, what is it please?: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Your name is {userName}, that sounds so cool!");

        if(userName.Length % 2 == 0 ){
            Console.WriteLine($"Hello {userName}, you'll soon be a dotnet EVENgelist");

        } else {
        Console.WriteLine($"Hello {userName} you'll soon be an dODDnet Evangelist");
        }

    }
}