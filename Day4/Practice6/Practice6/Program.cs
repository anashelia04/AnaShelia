Console.WriteLine("Enter a number: "); 
int num = Int32.Parse(Console.ReadLine());

Console.Write("divisors of " + num + " are: 1");

for (int i = 2; i <= num; i++)
{
    if (num % i == 0)
    {
        Console.Write(", "+ i  );
    }
}