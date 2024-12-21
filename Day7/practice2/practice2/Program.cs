static string ReverseString(string text)
{
    char[] chars = text.ToCharArray();
    string result = "";

    for (int i = text.Length - 1; i >= 0; i--)
    {
       result = result + chars[i];
    }
    return result;
}

Console.WriteLine("Enter word: ");
string text = Console.ReadLine();

string resultPrint = ReverseString(text);
Console.WriteLine(resultPrint);