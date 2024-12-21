static bool MyMethod(string text)
{
    if (text.Length <= 1)
        return true;

    if (text[0] != text[^1])
        return false;

    return MyMethod(text.Substring(1, text.Length - 2));
}

bool answer1 = MyMethod("RACECAR");
bool answer2 = MyMethod("APPLE");
Console.WriteLine("Is Palindrome? " + answer1);
Console.WriteLine("Is Palindrome? " + answer2);

