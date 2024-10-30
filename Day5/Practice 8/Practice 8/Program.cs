int[][] jaggedArray1 = new int[8][];

jaggedArray1[0] = new int[] { 1, 1, 1, 1, 1, 1, 1 };
jaggedArray1[1] = new int[] { 1, 1, 1, 1, 1, 1 };
jaggedArray1[2] = new int[] { 1, 1, 1, 1, 1 };
jaggedArray1[3] = new int[] { 1, 1, 1, 1 };
jaggedArray1[4] = new int[] { 1, 1, 1 };
jaggedArray1[5] = new int[] { 1, 1 };
jaggedArray1[6] = new int[] { 1 };
jaggedArray1[7] = new int[] { };


for (int i = 0; i < jaggedArray1.Length; i++)
{
    int size = jaggedArray1[0].Length - jaggedArray1[i].Length;
    for (int k = 0; k < size; k++)
    {
        Console.Write(0 + " ");
    }
    for (int j = 0; j < jaggedArray1[i].Length; j++)
    {
        Console.Write(jaggedArray1[i][j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = jaggedArray1.Length - 1; i >= 0; i--)
{
    int size = jaggedArray1[0].Length - jaggedArray1[i].Length;
    for (int k = 0; k < size; k++)
    {
        Console.Write(0 + " ");
    }
    for (int j = 0; j < jaggedArray1[i].Length; j++)
    {
        Console.Write(jaggedArray1[i][j] + " ");
    }
    Console.WriteLine();
}



