using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Magic Number Game! Try to guess the magic number between 1 and 100.");

        int magicNumber = new Random().Next(1, 100);
        // Console.WriteLine($"The magic number is: {magicNumber}");

        while (true)
        {
            Console.WriteLine("What is your guess? ");

            int guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }
}