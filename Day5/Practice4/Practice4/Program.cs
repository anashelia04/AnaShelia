Console.Write("Enter array size: " + " ");
int arraySize = Int32.Parse(Console.ReadLine());

int[] nums = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.Write("Enter number for index " + i + " : ");
    nums[i] = Int32.Parse(Console.ReadLine());
}

int product = 1;
foreach (int i in nums)
{
    product = product * i;
}

Console.WriteLine("Product of array elements is " + product);
