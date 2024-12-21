static char[] CreateArray()
{
    Console.Write("Enter size of array: ");
    int size = Int32.Parse(Console.ReadLine());
    char[] charArray = new char[size];

    for (int i = 0; i < charArray.Length; i++)
    {
        Console.Write("Enter integer for index " + i + ": ");
        char enteredChar = Console.ReadLine()[0];
        charArray[i] = enteredChar;
    }
    return charArray;
}

static int charCompare(char[] charArray, char symbol)
{
    int count = 0;
    for (int i = 0; i < charArray.Length; i++)
    {
        if (charArray[i] == symbol)
        {
            count++;
        }
    }
    return count;
}

static void PrintResult()
{
    char[] charArray = CreateArray();
    int result = charCompare(charArray, 'h');
    Console.WriteLine("h shegvxvda " + result + "-jer" );
}

PrintResult();
