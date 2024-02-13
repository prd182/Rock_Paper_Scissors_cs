// See https://aka.ms/new-console-template for more information

Random random = new Random();

int playerScore = 0;
int computerScore = 0;

Console.WriteLine("Welcome to Rock Paper Scissors!");

while (playerScore != 3 && computerScore != 3)
{
    Console.WriteLine("(R)ock, (P)aper or (S)cissors?");
    string playerChoice = Console.ReadLine();

    int computerChoice = random.Next(0, 3);

    if (computerChoice == 0)
    {
        Console.WriteLine("Computer: Rock");

        switch (playerChoice)
        {
            case "r":
                Console.WriteLine("Tie!");
                break;

            case "p":
                playerScore ++;
                Console.WriteLine("You win this round!");
                Console.WriteLine("Player: " + playerScore + " --- Computer: " + computerScore);
                break;

            default:
                computerScore ++;
                Console.WriteLine("Computer wins this round!");
                Console.WriteLine("Player: " + playerScore + " --- Computer: " + computerScore);
                break;
        }
    }
    else if (computerChoice == 1)
    {
        Console.WriteLine("Computer: Paper");

        switch (playerChoice)
        {
            case "r":
                computerScore ++;
                Console.WriteLine("Computer wins this round!");
                Console.WriteLine("Player: " + playerScore + " --- Computer: " + computerScore);
                break;

            case "p":
                Console.WriteLine("Tie!");
                break;
                
            default:
                playerScore ++;
                Console.WriteLine("You win this round!");
                Console.WriteLine("Player: " + playerScore + " --- Computer: " + computerScore);
                break;
        }
    }
    else
    {
        Console.WriteLine("Computer: Scissors");

        switch (playerChoice)
        {
            case "r":
                playerScore ++;
                Console.WriteLine("You win this round!");
                Console.WriteLine("Player: " + playerScore + " --- Computer: " + computerScore);
                break;

            case "p":
                computerScore ++;
                Console.WriteLine("Computer wins this round!");
                Console.WriteLine("Player: " + playerScore + " --- Computer: " + computerScore);
                break;
                
            default:
                Console.WriteLine("Tie!");
                break;
        }
    }
}

if (playerScore == 3)
{
    Console.WriteLine("You win!");
    Console.WriteLine("Player: " + playerScore + " --- Computer: " + computerScore);
}
else
{
    Console.WriteLine("You lose!");
    Console.WriteLine("Player: " + playerScore + " --- Computer: " + computerScore);
}