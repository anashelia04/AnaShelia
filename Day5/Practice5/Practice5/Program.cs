Console.Write("Enter array size: " + " ");
int arraySize = Int32.Parse(Console.ReadLine());

int[] nums = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.Write("Enter number for index " + i + " : ");
    nums[i] = Int32.Parse(Console.ReadLine());
}

Console.WriteLine("Unique elements in the array are:");

for (int i = 0; i < arraySize; i++)
{
    int count = 0;
    for (int j = 0; j < arraySize; j++)
    {
        if (nums[i] == nums[j])
        {
            count++;
        }
    }

    if (count == 1)
    {
        Console.WriteLine(nums[i]);
    }
}
