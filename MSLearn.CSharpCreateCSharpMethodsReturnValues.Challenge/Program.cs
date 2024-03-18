Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = GetRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? readResult;
    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            readResult = readResult.Trim().ToLower();
        }
    } while (readResult != "y" && readResult != "n");

    return readResult == "y" ? true : false;
}

int GetTarget()
{
    return random.Next(1, 6);
}

int GetRoll()
{
    return random.Next(1, 7);
}

string WinOrLose(int target, int roll)
{
    return roll > target ? "You win!" : "You lose!";
}