static int[,] IntArrays()
{
    Console.Write("Enter count of rows: ");
    int rowSize = Int32.Parse(Console.ReadLine());
    Console.Write("Enter count of columns: ");
    int columnSize = Int32.Parse(Console.ReadLine());

    int[,] nums1 = new int[rowSize, columnSize];

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            Console.Write("Enter number for index " + i + ", " + j + ": ");
            nums1[i, j] = Int32.Parse(Console.ReadLine());
        }
    }
    return nums1;
}

static int[,] Sum(int[,] matrix1, int[,] matrix2)
{
    int[,] nums3 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            nums3[i, j] = matrix1[i, j] + matrix2[i, j];
        }
    }
    return nums3;
}

static void printMatrix(int[,] sum)
{
    Console.WriteLine("Here is the sum of matrices: ");
    for (int i = 0; i < sum.GetLength(0); i++)
    {
        for (int j = 0; j < sum.GetLength(1); j++)
        {
            Console.Write(sum[i, j] + ", ");
        }
        Console.WriteLine();
    }
}


int[,] nums1 = IntArrays();
int[,] nums2 = IntArrays();
int[,] nums3 = Sum(nums1, nums2);
printMatrix(nums3);
