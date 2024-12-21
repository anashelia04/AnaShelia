Console.WriteLine("Enter integer number: ");
int x = Int32.Parse(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine("Entered number " + x + " is even");
}
else
{
    Console.WriteLine("Entered number " + x + " is odd");
}