int year = 2000;

bool leapYear = (year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 && year % 400 == 0);
Console.WriteLine(leapYear);