Console.WriteLine("Enter a string of brackets ");
string input = Console.ReadLine();

bool isValid = IsValidString(input);
Console.WriteLine(isValid ? "The string is valid." : "The string is invalid.");
static bool IsValidString(string input)
{
    if (input.Length == 0)
    {
        return false;
    }
    var left = new[] { '(', '{', '[' };
    var right = new[] { ')', '}', ']' };
    var stack = new Stack<char>();

    for (int i = 0; i < input.Length; i++)
    {
        if (left.Contains(input[i]))
        {
            stack.Push(input[i]);
            continue;
        }

        if (right.Contains(input[i])) 
        {
            if (!stack.Any())
            {
                return false;
            }

            var x = stack.Peek() - input[i];

            if (x < 0 && x >= -2)
            {
                stack.Pop();
                continue;
            }
            return false;
        }
    }

    if (stack.Any())
    {
        return false;
    }
    return true;
}

