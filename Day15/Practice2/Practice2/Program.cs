static double PointDistance(Tuple<int, int> point1, Tuple<int, int> point2)
{
    double distance = Math.Sqrt(Math.Pow(point2.Item1 - point1.Item1, 2) + Math.Pow(point2.Item2 - point1.Item2, 2));
    return distance;
}

Console.WriteLine(PointDistance(new Tuple<int, int>(9, 5), new Tuple<int, int>(1, 1)));
