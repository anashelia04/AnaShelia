Console.WriteLine("Enter array size: ");
int arraySize = Int32.Parse(Console.ReadLine());

int[] nums = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine("Enter number for index " + i);
    nums[i] = Int32.Parse(Console.ReadLine());
}

Console.WriteLine("Here is your array in reverse:");
for (int i = arraySize - 1; i >= 0; i--)
{
    Console.WriteLine(nums[i]);
    Console.WriteLine();
}