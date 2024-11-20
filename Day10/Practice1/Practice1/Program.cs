using practice_1;

Console.WriteLine("Select the vehicle that you want: ");
Console.WriteLine("Military - m");
Console.WriteLine("Sports - s");
Console.WriteLine("Private - pr");
Console.WriteLine("Public - p");
string input = Console.ReadLine();
switch (input)
{
    case "m":
        Console.WriteLine("Choose a military vehicle: ");
        Console.WriteLine("tank - t");
        Console.WriteLine("btr - b");
        string militaryVehicle = Console.ReadLine();
        switch (militaryVehicle)
        {
            case "t":
                Console.WriteLine("description of tank: ");
                Military tank = new Military(5, 60, 8, 4);
                tank.Start();
                tank.Move();
                tank.Attack();
                tank.Stop();
                break;
            default:
                Console.WriteLine("description of btr: ");
                Military btr = new Military(6, 100, 8, 10);
                btr.Start();
                btr.Move();
                btr.Attack();
                btr.Stop();
                break;
        }
        break;
    case "s":
        Console.WriteLine("Choose a sports vehicle: ");
        Console.WriteLine("f1 - f");
        Console.WriteLine("offRoad - o");
        string sportsVehicle = Console.ReadLine();
        switch (sportsVehicle)
        {
            case "f1":
                Console.WriteLine("description of f1: ");
                Sports f1 = new Sports(9, 324, 4, 1);
                f1.Start();
                f1.Move();
                f1.DRS();
                f1.Stop();
                break;
            default:
                Console.WriteLine("description of offRoad: ");
                Sports offRoad = new Sports(10, 100, 4, 4);
                offRoad.Start();
                offRoad.Move();
                offRoad.Stop();
                break;

        }
        break;

    case "pr":
        Console.WriteLine("Choose a private vehicle: ");
        Console.WriteLine("sedan - s");
        Console.WriteLine("bicycle - bi");
        Console.WriteLine("motorCycle - m");
        Console.WriteLine("miniVan - mv");
        string privateVehicle = Console.ReadLine();
        switch (privateVehicle)
        {
            case "s":
                Console.WriteLine("description of sedan: ");
                Private sedan = new Private(1, 120, 4, 5);
                sedan.Start();
                sedan.Move();
                sedan.Signal();
                sedan.Stop();
                break;
            case "bi":
                Console.WriteLine("description of bicycle: ");
                Private bicycle = new Private(2, 20, 2, 1);
                bicycle.Move();
                bicycle.Signal();
                bicycle.Stop();
                break;
            case "m":
                Console.WriteLine("description of motorcycle: ");
                Private motorcycle = new Private(3, 80, 2, 2);
                motorcycle.Start();
                motorcycle.Move();
                motorcycle.Stop();
                break;
            default:
                Console.WriteLine("description of miniVan: ");
                Private miniVan = new Private(4, 100, 4, 7);
                miniVan.Start();
                miniVan.Move();
                miniVan.Signal();
                miniVan.Stop();
                break;
        }
        break;

    default:
        Console.WriteLine("Choose a public vehicle: ");
        Console.WriteLine("bus - bs");
        Console.WriteLine("tram - tr");
        string publicVehicle = Console.ReadLine();
        switch (publicVehicle)
        {
            case "bs":
                Console.WriteLine("description of bus: ");
                Public bus = new Public(7, 60, 4, 34);
                bus.Start();
                bus.OpenDoors();
                bus.CloseDoors();
                bus.Move();
                bus.Signal();
                bus.Stop();
                break;
            default:
                Console.WriteLine("description of tram: ");
                Public tram = new Public(8, 25, 30, 40);
                tram.Start();
                tram.OpenDoors();
                tram.CloseDoors();
                tram.Move();
                tram.Signal();
                tram.Stop();
                break;

        }
        break;
}
            
        