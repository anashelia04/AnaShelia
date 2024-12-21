static int NumOfWords(string text)
{
    char[] chars = text.ToCharArray();

    int count = 1;
    for (int i = 0; i < text.Length; i++)
    {
        if (chars[i] == ' ')
        {
            count++;
        }
    }
    return count;
}

static void PrintNumOfWords(int count)
{
    Console.WriteLine(count);
}

Console.WriteLine("Write Input: ");
string text = Console.ReadLine();

PrintNumOfWords(NumOfWords(text));
