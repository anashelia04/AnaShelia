Console.WriteLine("Enter a number: ");
int num = Int32.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i<=num; i++)
{
    if (i % 2 == 1)
    {
        sum += i;
    } 
}
Console.WriteLine("Sum of odd numbers from 1 to " + num + " is " + sum);