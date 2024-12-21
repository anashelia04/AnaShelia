using Practice1;

Console.WriteLine("Creating Cat object...");
Console.Write("Enter name: ");
string name = Console.ReadLine();
Console.Write("Enter breed: ");
string breed = Console.ReadLine();
Console.Write("Enter age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sex: ");
string sex = Console.ReadLine();
Cat cat = new Cat();
cat.Name = name;
cat.Breed = breed;
cat.Age = age;
cat.Sex = sex;
Console.WriteLine("Cat object created.");
Console.Write("Enter food weight in grams: ");
int grams = Convert.ToInt32(Console.ReadLine());
cat.Eat(grams);
Console.Write("Enter meowing count: ");
int count = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < count; i++)
{
    cat.Meow();
}

