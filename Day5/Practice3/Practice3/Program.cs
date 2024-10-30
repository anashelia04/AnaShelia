Console.Write("Enter array size: " + " ");
int arraySize = Int32.Parse(Console.ReadLine());

int[] nums = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.Write("Enter number for index " + i + " : ");
    nums[i] = Int32.Parse(Console.ReadLine());
}

int sum = 0;
foreach (int i in nums)
{
    sum = sum + i;
}

Console.WriteLine("Sum of array elements is " + sum);