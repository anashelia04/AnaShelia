using ConsoleApp1;

Board board = new Board();
board.CreateBoard1();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Player 1 Choose which ship to place on the board: ");
    Console.WriteLine("Choose 1 for Aircraft Carier ");
    Console.WriteLine("Choose 2 for Battleship");
    Console.WriteLine("Choose 3 for Cruiser");
    Console.WriteLine("Choose 4 for Submarine");
    Console.WriteLine("Choose 5 for Destroyer");

    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("Enter where you want to place the Aircraft Carier "); //a1 a5 formati
            AircraftCarrier aircraft = new AircraftCarrier(new Position(input1, input2), name);


            break;
        case "2":
            Console.WriteLine("Enter where you want to place the Battleship ");
            string input2 = Console.ReadLine();
            break;
        case "3":
            Console.WriteLine("Enter where you want to place the Cruiser ");
            string input3 = Console.ReadLine();
            break;
        case "4":
            Console.WriteLine("Enter where you want to place the Submarine ");
            string input4 = Console.ReadLine();
            break;
        case "5":
            Console.WriteLine("Enter where you want to place the Destroyer ");
            string input5 = Console.ReadLine();
            break;

    }
}


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Player 2 Choose which ship to place on the board: ");
    Console.WriteLine("Choose 1 for Aircraft Carier ");
    Console.WriteLine("Choose 2 for Battleship");
    Console.WriteLine("Choose 3 for Cruiser");
    Console.WriteLine("Choose 4 for Submarine");
    Console.WriteLine("Choose 5 for Destroyer");
