static int ArrayMultiplied(params int[] numsArray)
{
    int multiplied = 1;
    for (int i = 0; i < numsArray.Length; i++)
    {
        multiplied = multiplied * numsArray[i];
    }
    Console.WriteLine("The product of array elements is: " + multiplied);
    return multiplied;
}

int[] numsArray = { 1, 3, 4, 15, 13, 23, 98 };
ArrayMultiplied(numsArray);
