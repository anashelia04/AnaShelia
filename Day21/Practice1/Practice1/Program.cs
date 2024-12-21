using Practice1;

//1
LogMessage consoleLogger = message => Console.WriteLine($"Console Log: {message}");
LogMessage fileLogger = message =>
{
    using StreamWriter writer = new StreamWriter("log.txt", true);
    writer.WriteLine($"File Log: {message}");
};

LogMessage combinedLogger = consoleLogger + fileLogger;

combinedLogger("Message");

//2

MathOperation add = (a, b) => a + b;
MathOperation subtract = (a, b) => a - b;
MathOperation multiply = (a, b) => a * b;
MathOperation divide = (a, b) => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero.");

MathOperation addThenMultiply = add + multiply;
MathOperation subtractThenDivide = subtract + divide;

decimal x = 10m, y = 5m;

Console.WriteLine("Add and Multiply:");
foreach (MathOperation operation in addThenMultiply.GetInvocationList())
{
    Console.WriteLine(operation(x, y));
}

Console.WriteLine("\nSubtract and Divide:");
foreach (MathOperation operation in subtractThenDivide.GetInvocationList())
{
    Console.WriteLine(operation(x, y));
}

//3

var book = new Book
{
    Title = "1984",
    Author = "George Orwell",
    ISBN = "123453",
    Publisher = "A",
    PublicationDate = DateTime.Now.AddDays(-1),
    Genre = Genre.Fiction,
    NumberOfPages = 400,
    IsAvailable = true,
    Price = 22.99m
};

if (BookValidator.Validate(book, out string errorMessage))
{
    Console.WriteLine("Book is valid.");
}
else
{
    Console.WriteLine($"Validation failed: {errorMessage}");
}

//4

var books = new List<Book>
        {
            new Book { Title = "Flowers for Algernon", Author = "Daniel Keyes", ISBN = "1234567", Publisher = "A", PublicationDate = new DateTime(1959, 1, 1), Genre = Genre.Fiction, NumberOfPages = 300, IsAvailable = true, Price = 17.99m },
            new Book { Title = "Dune", Author = "Frank Herbert", ISBN = "9876543213", Publisher = "B", PublicationDate = new DateTime(1965, 5, 15), Genre = Genre.SciFi, NumberOfPages = 300, IsAvailable = false, Price = 15.99m },
            new Book { Title = "The Girl With The Dragon Tattoo", Author = "Stieg Larsson", ISBN = "567890167", Publisher = "C", PublicationDate = new DateTime(2005, 8, 1), Genre = Genre.Mystery, NumberOfPages = 300, IsAvailable = true, Price = 10.00m }
        };

var pipeline = new DataPipeline<Book>()
    .AddStep(b => b.Where(book => book.PublicationDate.Year > 2010))
    .AddStep(b => b.Where(book => book.NumberOfPages < 250));

var filteredBooks = pipeline.Process(books);

Func<Book, BookDto> transformToDto = book => new BookDto
{
    Title = book.Title,
    Author = book.Author,
    Genre = book.Genre,
    IsAvailable = book.IsAvailable,
    Price = book.Price
};

var bookDtos = filteredBooks.Select(transformToDto).ToList();

foreach (var bookDto in bookDtos)
{
    Console.WriteLine($"Title: {bookDto.Title}, Author: {bookDto.Author}, Genre: {bookDto.Genre}, IsAvailable: {bookDto.IsAvailable}, Price: {bookDto.Price:C}");
}

public delegate void LogMessage(string message);
public delegate decimal MathOperation(decimal a, decimal b);