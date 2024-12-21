Console.WriteLine("Enter a number: ");
int num = Int32.Parse(Console.ReadLine());
string ans = "";



if (num == 0)
{
    ans = "0";
}

for (int i = num; i > 0; i/=2)
{
  ans = (i % 2) + ans;
}

Console.WriteLine("decimal " + num + " in binary is " + ans);