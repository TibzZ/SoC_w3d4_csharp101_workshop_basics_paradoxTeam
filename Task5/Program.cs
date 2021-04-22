using System;

class Program
{
    static void Main(string[] args)
    {
        var rand = new Random();
        int computerChoice = rand.Next(0,6);
        Console.Write("Guess the number between 1 and 5, the computer generated: ");
        string userChoiceToConvert = Console.ReadLine();
        //method to convert userChoice to int from string
        int userChoice = Int32.Parse(userChoiceToConvert);

       
        if(computerChoice == userChoice)
        {
            Console.WriteLine("Congratulation you win! 🎉");
        }
        else
        {
            Console.WriteLine("Try again... !");
        }
        Console.WriteLine($"The computer generated {computerChoice}");
    }
}

