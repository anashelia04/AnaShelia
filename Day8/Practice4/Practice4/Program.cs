static int MyMethod(int number, int degree)
{
    if (degree == 0){
        return 1;
    }

    return number * MyMethod(number, degree - 1);
}

int answer = MyMethod(5, 3);
Console.WriteLine(answer);