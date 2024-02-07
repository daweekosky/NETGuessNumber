using GuessNumber;
using System.Text.Json;

var rand = new Random();
//Number is randomly selected
var value = rand.Next(1, 101);
int guess = 0;
int trials = 0;
Console.WriteLine("Welcome to Guess the Number! Try to guess the number in the fewest number of tries");
//Logic responsible for guessing the number
while(guess != value)
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
}

//Inserting name
Console.WriteLine("Insert your name to save your score");
string name = Console.ReadLine();
//HighScore initialization
var hs = new HighScore { Name = name, Trials = trials };

List<HighScore> highScores;
//Filename with scores
const string FileName = "highscores.json";
//Logic responsible for creating file if not exist or loading high scores from existing file
if(File.Exists(FileName))
    highScores = JsonSerializer.Deserialize<List<HighScore>>(File.ReadAllText(FileName));
else
    highScores = new List<HighScore>();
//Adding new high score and writing to file
highScores.Add(hs);
File.WriteAllText(FileName,JsonSerializer.Serialize(highScores));
//High scores display in app
foreach(var score in highScores)
{
    Console.WriteLine($"{score.Name} - {score.Trials} trials");
}