Console.WriteLine("Enter a number: ");
int num = Int32.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i <= num; i++)
{
    sum += i;
}
Console.WriteLine("Sum from 1 to " + num + " is " + sum);