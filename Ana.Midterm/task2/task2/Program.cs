using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4};
            Console.WriteLine(MissingNumber(arr));
        }

        static int MissingNumber(int[] array)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum1 = sum1 + array[i];
            }

            for (int i = 1; i <= array.Length + 1; i++)
            {
                sum2 = sum2 + i;
            }
            int answer = sum2 - sum1;
            return answer;
        }

    }
}
