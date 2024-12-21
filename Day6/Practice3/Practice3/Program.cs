static int[] CreateArray()
{
    Console.Write("Enter size of array: ");
    int size = Int32.Parse(Console.ReadLine());
    int[] numsArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter integer for index " + i + ": ");
        numsArray[i] = Int32.Parse(Console.ReadLine());
    }
    return numsArray;
}

static void MinMaxElements(int[] numsArray)
{
    int maxNumber = numsArray[0];

    for (int i = 1; i < numsArray.Length; i++)
    {
        if (numsArray[i] > maxNumber)
        {
            maxNumber = numsArray[i];
        }
    }

    Console.WriteLine("The maximum number in the array is " + maxNumber);

    int minNumber = numsArray[0];

    for (int i = numsArray.Length - 1; i >= 0; i--)
    {
        if (numsArray[i] < minNumber)
        {
            minNumber = numsArray[i];
        }
    }

    Console.WriteLine("The minimum number in the array is " + minNumber);
}

int[] numsArray = CreateArray();
MinMaxElements(numsArray);
