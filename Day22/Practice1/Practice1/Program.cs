using Practice1;

string currentDirectory = Directory.GetCurrentDirectory();

var customers = File.ReadAllLines(@"D:\TBC\Day22\Practice1\Practice1\Customers.txt")
    .Select(line => line.Split('|'))
    .Select(parts => new Customer { CustomerID = int.Parse(parts[0]), CustomerName = parts[1] })
    .ToList();

var orders = File.ReadAllLines(@"D:\TBC\Day22\Practice1\Practice1\Orders.txt")
    .Select(line => line.Split('|'))
    .Select(parts => new Order
    {
        OrderID = int.Parse(parts[0]),
        Date = parts[1],
        Product = parts[2],
        Price = decimal.Parse(parts[3]),
        CustomerID = int.Parse(parts[4])
    })
    .ToList();

var customerStats = orders
    .GroupBy(o => o.CustomerID)
    .Select(g => new
    {
        CustomerID = g.Key,
        OrderCount = g.Count(),
        SumAmount = g.Sum(o => o.Price),
        MinAmount = g.Min(o => o.Price),
        AvgAmount = g.Average(o => o.Price)
    })
    .Where(stat => stat.OrderCount >= 1)
    .ToList();

foreach (var stat in customerStats)
{
    Console.WriteLine($"CustomerID: {stat.CustomerID}, OrderCount: {stat.OrderCount}, SumAmount: {stat.SumAmount}, MinAmount: {stat.MinAmount}, AvgAmount: {stat.AvgAmount}");
}