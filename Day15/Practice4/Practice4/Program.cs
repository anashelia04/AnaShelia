using Practice4;

Console.Write("Enter a base number: ");
double baseNumber = Double.Parse(Console.ReadLine());
Console.Write("Enter a power number: ");
int power = Int32.Parse(Console.ReadLine());

double result1 = MATH.MyPow(baseNumber, power, out Status status1);
Console.WriteLine($"Result: {result1}, Status: {status1}");
Console.WriteLine();


Console.Write("Enter first number: ");
int first = Int32.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int second = Int32.Parse(Console.ReadLine());

int result2 = MATH.MyMin(first, second, out Status status2);
Console.WriteLine($"Smaller Number: {result2}, Status: {status1}");

int result3 = MATH.MyMax(first, second, out Status status3);
Console.WriteLine($"Larger Number: {result3}, Status: {status1}");

//tuples

//Console.Write("Enter a base number: ");
//double baseNumber = Double.Parse(Console.ReadLine());
//Console.Write("Enter a power number: ");
//int power = Int32.Parse(Console.ReadLine());

//Tuple<double, Status> result1 = MATH.MyPowTuple(baseNumber, power);
//Console.WriteLine(result1);


//Console.Write("Enter first number: ");
//int first = Int32.Parse(Console.ReadLine());
//Console.Write("Enter second number: ");
//int second = Int32.Parse(Console.ReadLine());

//Tuple<int, Status> result2 = MATH.MyMinTuple(first, second);
//Console.WriteLine(result2);

//Tuple<int, Status> result3 = MATH.MyMaxTuple(first, second);
//Console.WriteLine(result3);





public enum Status
{
    PowMustBePositiveOrZero,
    Success
}
