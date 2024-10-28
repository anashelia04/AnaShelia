Console.WriteLine("Enter a number: ");
int num = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine("num cubed is: " + Math.Pow(i, 3));
}