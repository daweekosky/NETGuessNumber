using GuessNumber;
using System.Text.Json;

var rand = new Random();
var value = rand.Next(1, 101);int guess = 0;int trials = 0;Console.WriteLine("Welcome to Guess the Number! Try to guess the number in the fewest number of tries");while(guess != value)
{
    Console.WriteLine("Insert your number");
    guess = Convert.ToInt32(Console.ReadLine());
    trials++;
    if (guess == value)
    {
        Console.WriteLine("Congratulations! You did it in " + trials + " trials");
    }
    else if(guess < value)
    {
        Console.WriteLine("The number your looking for is higher");
    }
    else if (guess > value)
    {
        Console.WriteLine("The number your looking for is lower");
    }
}Console.WriteLine("Insert your name to save your score");string name = Console.ReadLine();var hs = new HighScore { Name = name, Trials = trials };List<HighScore> highScores;const string FileName = "highscores.json";if(File.Exists(FileName))    highScores = JsonSerializer.Deserialize<List<HighScore>>(File.ReadAllText(FileName));else    highScores = new List<HighScore>();highScores.Add(hs);File.WriteAllText(FileName,JsonSerializer.Serialize(highScores));foreach(var score in highScores)
{
    Console.WriteLine($"{score.Name} - {score.Trials} trials");
}