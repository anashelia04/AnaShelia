using Practice3;

GenericStack<string> animeStack = new GenericStack<string>();

animeStack.Push("Dorohedoro");
animeStack.Push("Haikyu");
animeStack.Push("Attack on Titan");


animeStack.Display();

Console.WriteLine($"Peek: {animeStack.Peek()}");

Console.WriteLine($"Pop: {animeStack.Pop()}");
Console.WriteLine($"Pop: {animeStack.Pop()}");
Console.WriteLine($"Pop: {animeStack.Pop()}");

Console.WriteLine($"Pop (empty): {animeStack.Pop()}");

animeStack.Display();
    