static T FindMaximum<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            return default; 
        }

        T max = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
}


        string[] words = { "apple", "banana", "cherry" };
        int[] numbers = { 13, 5, 20, 1, 99 };

        Console.WriteLine("Max in words: " + FindMaximum(words));
        Console.WriteLine("Max in numbers: " + FindMaximum(numbers));


 

