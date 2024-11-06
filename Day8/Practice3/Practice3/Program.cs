static int MyMethod(int x)
{
    if (x / 10 == 0)
        return 1;
    
    return 1 + MyMethod(x / 10);
}

Console.WriteLine(MyMethod(1999));