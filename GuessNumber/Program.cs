var rand = new Random();
var value = rand.Next(1, 101);int guess = 0;int triesCount = 0;Console.WriteLine("Welcome to Guess the Number! Try to guess the number in the fewest number of tries");while(guess != value)
{
    Console.WriteLine("Insert your number");
    guess = Convert.ToInt32(Console.ReadLine());
    triesCount++;
    if (guess == value)
    {
        Console.WriteLine("Congratulations! You did it in " + triesCount + " tries");
    }
    else if(guess < value)
    {
        Console.WriteLine("The number your looking for is larger");
    }
    else if (guess > value)
    {
        Console.WriteLine("The number your looking for is smaller");
    }
}