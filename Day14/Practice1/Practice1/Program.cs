static bool SwapElements<T>(int index1, int index2, T[] array)
{
    if (array == null || array.Length == 0)
        return false;

    if (index1 < 0 || index2 < 0 || index1 >= array.Length || index2 >= array.Length)
        return false;
    else if (index1 == index2)
    {
        return true;
    }

    T temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;

    return true;
}

int[] numbers = { 1, 2, 3, 4, 5 };
if (SwapElements(1, 3, numbers))
{
    Console.WriteLine("Swap successful:");
    foreach (var number in numbers)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Swap failed.");
}




