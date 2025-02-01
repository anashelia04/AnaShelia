using ConsoleApp1;

Console.WriteLine("Enter number of players (1-7) ");
int playerCounter = int.Parse(Console.ReadLine());
if (playerCounter < 1 || playerCounter > 7)
{
    Console.WriteLine("input valid number");
}

Game game = new Game(playerCounter);
game.Play();