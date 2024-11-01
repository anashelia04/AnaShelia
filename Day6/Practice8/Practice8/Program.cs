static int MyNumber()
{
    Console.Write("Enter a positive number: ");
    int num = Int32.Parse(Console.ReadLine());

    return num;
}

static void SplitNumber(int num)
{
    int power = 0;
    int initialNumber = num;
    string answer = "";
    while (num != 0)
    {
        int lastDigit = num % 10;
        answer = lastDigit + " * 10^" + power + " + " + answer;
        power++;
        num = num / 10;
    }
    Console.WriteLine(initialNumber + " = " + answer + "0");
}

int num = MyNumber();
SplitNumber(num);

