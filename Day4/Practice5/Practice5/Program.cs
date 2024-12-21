Console.WriteLine("Enter a number of rows of Floyd's triangle to be printed: ");
int num = Int32.Parse(Console.ReadLine());


for (int i = 1; i <= num; i++)
{
    for (int j = 1;  j<= i; j++)
    {
        if ((i + j) % 2 == 0)
        {
            Console.Write(1 + " ");
        }
        else
        {
            Console.Write(0 + " ");
        }
       
    }
    Console.WriteLine();
}