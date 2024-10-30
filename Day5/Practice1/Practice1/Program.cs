Console.WriteLine("Enter array size: ");
int arraySize = Int32.Parse(Console.ReadLine());

int[] nums = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine("Enter number for index " + i);
    nums[i] = Int32.Parse(Console.ReadLine());
}

Console.WriteLine("Here is your array!");

foreach (int i in nums)
{
    Console.WriteLine(i);
    Console.WriteLine();
}