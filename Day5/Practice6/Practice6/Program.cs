Console.Write("Enter array row size: ");
int rowSize = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter array column size: ");
int columnSize = Int32.Parse(Console.ReadLine());

int[,] nums = new int[rowSize, columnSize];

for (int i = 0; i < rowSize; i++)
{
    for (int j = 0; j < columnSize; j++)
    {
        Console.Write("Enter number for index " + i + ", " + j + ": ");
        nums[i, j] = Int32.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Here is a matrix view of multidimensional array: ");

for (int i = 0; i < rowSize; i++)
{
    for (int j = 0; j < columnSize; j++)
    {
        Console.Write(nums[i, j] + ", ");
    }
    Console.WriteLine();
}