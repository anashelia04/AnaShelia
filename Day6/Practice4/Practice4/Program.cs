using System.Runtime.Intrinsics.X86;

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

static double ArrayAvg(int[] numsArray)
{
    double sum = 0;
    for (int i = 0; i < numsArray.Length; i++)
    {
        sum = sum + numsArray[i];
    }

    double avg = sum / numsArray.Length;
    return avg;
}

int[] numsArray = CreateArray();
Console.WriteLine("Arithmetic average of array is " + ArrayAvg(numsArray));
