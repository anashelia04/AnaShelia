static int LetterCount(string text, bool isVowel = true)
{
    char[] charArray = text.ToCharArray();
    char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };

    int count = 0;

    if (isVowel)
    {
        for (int i = 0; i < charArray.Length; i++)
        {
            if (!(charArray[i] >= 'A' && charArray[i] <= 'Z') && !(charArray[i] >= 'a' && charArray[i] <= 'z'))
            {
                continue;
            }
     
           for (int j = 0; j < vowelArray.Length; j++)
           {
                if (charArray[i] == vowelArray[j])
                {
                    count++;
                }
           }
        }
        Console.WriteLine("Vowel count: " + count);
    } 
    else 
    {
        foreach (char currentChar in charArray)
        {
            if (!(currentChar >= 'A' && currentChar <= 'Z') && !(currentChar >= 'a' && currentChar <= 'z'))
            {
                continue;
            }

            bool vowel = false;

            for (int j = 0; j < vowelArray.Length; j++)
            {
                if (currentChar == vowelArray[j])
                {
                    vowel = true;
                }
            }
            if (vowel == false)
            {
                count++;
            }
        }
        Console.WriteLine("Consonant count: " + count);
    }
    return count;
}

static string TextPrint(string text, bool isVowel = true) { 

    char[] charArray = text.ToCharArray();
    char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };
    string lettersOnly = " ";

    if (isVowel)
    {
        for (int i = 0; i < charArray.Length; i++)
        {
            if (!(charArray[i] >= 'A' && charArray[i] <= 'Z') && !(charArray[i] >= 'a' && charArray[i] <= 'z'))
            {
                continue;
            }
            for (int j = 0; j < vowelArray.Length; j++)
            {
                if (charArray[i] == vowelArray[j])
                {
                    lettersOnly = lettersOnly + charArray[i] + " ";
                }
            }
        }
        Console.WriteLine("Vowels: " + lettersOnly);
    } 
    else
    {
        foreach (char currentChar in charArray)
        {
            if (!(currentChar >= 'A' && currentChar <= 'Z') && !(currentChar >= 'a' && currentChar <= 'z'))
            {
                continue;
            }
            bool vowel = false;

            for (int j = 0; j < vowelArray.Length; j++)
            {
                if (currentChar == vowelArray[j])
                {
                    vowel = true;
                }
            }
            if (vowel == false)
            {
                lettersOnly = lettersOnly + currentChar + " ";
            }
        }
        Console.WriteLine("Consonants: " + lettersOnly);
    }
    return lettersOnly;
}

Console.WriteLine("Enter text: ");
string text1 = Console.ReadLine();
string text = text1.ToLower();

int result1 = LetterCount(text);
string result3 = TextPrint(text);

int result2 = LetterCount(text1, false);
string result4 = TextPrint(text, false);



