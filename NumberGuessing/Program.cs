namespace NumberGuessing
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Random random = new Random();
                int secretNumber = random.Next(1, 101); // Generate a random number between 1 and 100
                int attempts = 0;
                int guess = 0;

                Console.WriteLine("Welcome to the Number Guessing Game!");
                Console.WriteLine("I have chosen a number between 1 and 100. Can you guess it?");

                while (guess != secretNumber)
                {
                    Console.Write("Enter your guess: ");
                    string input = Console.ReadLine();

                    // Attempt to parse user input
                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Please enter a valid number.");
                        continue;
                    }

                    attempts++;

                    if (guess < secretNumber)
                    {
                        Console.WriteLine("The number entered was too low! Please try again.");
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("The number entered was too high! Please try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You've guessed the number {secretNumber} correctly in {attempts} attempts!");
                    }
                }
            }
        }

    }

