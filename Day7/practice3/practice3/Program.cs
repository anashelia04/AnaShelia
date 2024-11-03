static void SpacedString(string text)
{
    char[] chars = text.ToCharArray();
    string newString = "";
    for (int i = 0; i < chars.Length; i++)
    {
        newString = newString + chars[i] + " ";
    }
    Console.WriteLine(newString);
}

Console.WriteLine("Enter word: ");
string enteredString = Console.ReadLine().ToUpper();
SpacedString(enteredString);