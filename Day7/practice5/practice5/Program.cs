static int LettersCount(string text)
{
    char[] chars = text.ToCharArray();
    int numOfLetters = 0;


    for (int i = 0; i < chars.Length; i++)
    {
        if ((chars[i] >= 'A' && chars[i] <= 'Z') || (chars[i] >= 'a' && chars[i] <= 'z'))
        {
            numOfLetters++;
        }
    }

    return numOfLetters;
}

static int NumbersCount(string text)
{
    char[] chars = text.ToCharArray();
    int numOfNumbers = 0;


    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i] >= '0' && chars[i] <= '9')
        {
            numOfNumbers++;
        }
    }
    return numOfNumbers;
}

static int OthersCount(string text)
{
    char[] chars = text.ToCharArray();
    int numOfOthers = 0;

    for (int i = 0; i < chars.Length; i++)
    {
        if (!((chars[i] >= 'A' && chars[i] <= 'Z') || (chars[i] >= 'a' && chars[i] <= 'z') || (chars[i] >= '0' && chars[i] <= '9')))
        {
            numOfOthers++;
        }
    }
    return numOfOthers;
}

static void Result(int numOfLetters, int numOfNumbers, int numOfOthers)
{
    Console.WriteLine("Letters: " + numOfLetters + ", Numbers: " + numOfNumbers + ", Others: " + numOfOthers);
}


Console.WriteLine("enter text ");
string text = Console.ReadLine();

Result(LettersCount(text), NumbersCount(text), OthersCount(text));

