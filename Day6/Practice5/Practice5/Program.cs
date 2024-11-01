static int[] CreateArray()
{
    Console.Write("Enter size of array: ");
    int size = Int32.Parse(Console.ReadLine());
    int[] numsArray = new int[size];

    for (int i = 0; i < numsArray.Length; i++)
    {
        Console.Write("Enter integer for index " + i + ": ");
        numsArray[i] = Int32.Parse(Console.ReadLine());
    }
    return numsArray;
}

static int Factorial(int number)
{
    if (number == 0)
    {
        return 1;
    }
    return number * Factorial(number - 1);
}

static int ArrayElementFactorial(int[] nums, int number)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == number)
        {
            return Factorial(number);
        }
    }
    return -1;
}

int[] numsArray = CreateArray();
int factorial = ArrayElementFactorial(numsArray, 6);
if (factorial == -1)
{
    Console.WriteLine("Number was not found in the given array");
}
else
{
    Console.WriteLine("Factorial is " + factorial);
}
