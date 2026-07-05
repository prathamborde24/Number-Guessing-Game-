using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Number Guessing Game";

        Random random = new Random();
        int secretNumber = random.Next(1, 21); // Random number between 1 and 20
        int attempts = 5;

        Console.WriteLine("=================================");
        Console.WriteLine("      NUMBER GUESSING GAME");
        Console.WriteLine("=================================");
        Console.WriteLine("I am thinking of a number between 1 and 20.");
        Console.WriteLine($"You have {attempts} attempts to guess it.");

        while (attempts > 0)
        {
            Console.Write("\nEnter your guess: ");

            if (int.TryParse(Console.ReadLine(), out int guess))
            {
                if (guess == secretNumber)
                {
                    Console.WriteLine("\n🎉 Congratulations!");
                    Console.WriteLine($"You guessed the correct number: {secretNumber}");
                    Console.WriteLine("YOU WIN!");
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Too high!");
                }

                attempts--;
                Console.WriteLine($"Attempts remaining: {attempts}");
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            if (attempts == 0)
            {
                Console.WriteLine("\n💀 GAME OVER!");
                Console.WriteLine($"The correct number was {secretNumber}.");
            }
        }

        Console.WriteLine("\n=================================");
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}