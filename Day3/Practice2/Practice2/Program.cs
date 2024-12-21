Console.WriteLine("Enter first number: ");
int a = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int b = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int c = Int32.Parse(Console.ReadLine());

if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("This should be a triangle !");
}
else
{
    Console.WriteLine("This should not be a triangle !");
}
