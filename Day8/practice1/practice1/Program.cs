static void MyMethod(int x)
{
    if (x < 1)
        return;

    MyMethod(x - 1);
    Console.Write(x + " ");
}

MyMethod(20);