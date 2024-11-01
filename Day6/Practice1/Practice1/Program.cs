static int ArrayIndex(int[] numsArray, int index)
{
    int num = numsArray[index];
    return num;
}

int[] numsArray = { 1, 3, 4, 15, 13, 23, 98 };
Console.WriteLine("Number at index " + 0 + " in the array is " + ArrayIndex(numsArray, 0));
