Console.Write("Enter array row size: ");
int rowSize = Int32.Parse(Console.ReadLine());
Console.Write("Enter array column size: ");
int columnSize = Int32.Parse(Console.ReadLine());

int[,] nums1 = new int[rowSize, columnSize];
int[,] nums2 = new int[rowSize, columnSize];
int[,] nums3 = new int[rowSize, columnSize];

Console.WriteLine("Fill the first matrix ");
for (int i = 0; i < rowSize; i++)
{
    for (int j = 0; j < columnSize; j++)
    {
        Console.Write("Enter number for index " + i + ", " + j + ": ");
        nums1[i, j] = Int32.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("Fill the second matrix ");
for (int i = 0; i < rowSize; i++)
{
    for (int j = 0; j < columnSize; j++)
    {
        Console.Write("Enter number for index " + i + ", " + j + ": ");
        nums2[i, j] = Int32.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Here is the sum of two matrices: ");
for (int i = 0; i < rowSize; i++)
{
    for (int j = 0; j < columnSize; j++)
    {
        nums3[i, j] = nums1[i, j] + nums2[i, j];
        Console.Write(nums3[i, j] + ", ");
    }
    Console.WriteLine();
}









