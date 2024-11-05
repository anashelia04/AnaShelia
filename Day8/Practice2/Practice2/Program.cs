static int MyMethod(int x)
{
    if (x < 1)
    {
        return 0;
    }
   int sum = x + MyMethod(x - 1);
    return sum;
}

int answer = MyMethod(5);
Console.WriteLine(answer);