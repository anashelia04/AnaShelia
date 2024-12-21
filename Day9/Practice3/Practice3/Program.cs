using Practice3;

Console.Write("Enter hours: ");
int hour = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minutes: ");
int minute = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter seconds: ");
int second = Convert.ToInt32(Console.ReadLine());

Clock clock = new Clock();
clock.Hour = hour;
clock.Minute = minute;
clock.Second = second;

clock.GetCurrentTime();
clock.AddSecond();
clock.AddSecond();
clock.AddSecond();
clock.GetCurrentTime();
clock.SubtractSecond();
clock.SubtractSecond();
clock.SubtractSecond();
clock.GetCurrentTime();