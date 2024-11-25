using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 5 };
            ShowPairs(7, arr);

        }
        static void ShowPairs(int number, int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int sum = array[left] + array[right];
                if (sum == number)
                {
                    Console.WriteLine(array[left] + " " + array[right]);
                    break;
                }
                else if (sum < number)
                {
                    left++;
                }
                else
                {
                    right--;
                }
                
            }
        }
    }
}
