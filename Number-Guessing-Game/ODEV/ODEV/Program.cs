// See https://aka.ms/new-console-template for more information
Random random = new Random();
int randomNumber = random.Next(1, 11);
int guessNumber = 0;
int guessCount = 0;

Console.WriteLine("The computer has picked a number between 1 and 10. Can you guess it?");


while (guessNumber != randomNumber)
{
    Console.Write("Your guess: ");
    guessNumber = Convert.ToInt32(Console.ReadLine());
    guessCount++;


    if (guessNumber < randomNumber)
    {
        Console.WriteLine("Try a bigger number!");
    }
    else if (guessNumber > randomNumber)
    {
        Console.WriteLine("Try a smaller number!");
    }
    else
    {
        Console.WriteLine($"Congratulations! You guessed the correct number in {guessCount} attempts.");
    }
}
