Console.WriteLine("Enter a number: ");
int num = Int32.Parse(Console.ReadLine());
int num1 = 0;
int num2 = 1;
int sum;


for (int i = 1; i <= num; i++)
{
   Console.Write(num1 + ", ");
   sum = num1 + num2;
   num1 = num2;
   num2 = sum;

}