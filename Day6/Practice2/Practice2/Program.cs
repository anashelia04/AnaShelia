static int IndexSum(int[] numsArray, int numsIndex)
{
    int sum = 0;
    int num = numsArray[numsIndex];

    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

int[] numsArray = { 1, 3, 123, 15, 13, 23, 98 };
Console.WriteLine("The sum of the digits of a number at index " + 3 + " is " + IndexSum(numsArray, 3));
