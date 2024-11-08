using Practice2;

Console.Write("Enter side 1: ");
double side1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter side 2: ");
double side2 = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter side 3: ");
double side3 = Convert.ToSingle(Console.ReadLine());

Triangle triangle = new Triangle();
triangle.Side1 = side1;
triangle.Side2 = side2;
triangle.Side3 = side3;
Console.WriteLine($"Perimeter of the triangle is: {triangle.Perimeter()}");
Console.WriteLine($"Area of the triangle is: {triangle.Area()}");