Console.WriteLine("Enter your day of birth: ");
int day = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your month of birth: ");
string month = Console.ReadLine().ToLower();

switch (month)
{
    case "january":
        if (day <= 19)
        {
            Console.WriteLine(day + " " + month + " is Capricorn");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Aquarius");
        }
        break;
    case "february":
        if (day <= 18)
        {
            Console.WriteLine(day + " " + month + " is Aquarius");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Pisces");
        }
        break;
    case "march":
        if (day <= 20)
        {
            Console.WriteLine(day + " " + month + " is Pisces");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Aries");
        }
        break;
    case "april":
        if (day <= 19)
        {
            Console.WriteLine(day + " " + month + " is Aries");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Taurus");
        }
        break;
    case "may":
        if (day <= 20)
        {
            Console.WriteLine(day + " " + month + " is Taurus");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Gemini");
        }
        break;
    case "june":
        if (day <= 20)
        {
            Console.WriteLine(day + " " + month + " is Gemini");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Cancer");
        }
        break;
    case "july":
        if (day <= 22)
        {
            Console.WriteLine(day + " " + month + " is Cancer");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Leo");
        }
        break;
    case "august":
        if (day <= 22)
        {
            Console.WriteLine(day + " " + month + " is Leo");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is VIrgo");
        }
        break;
    case "september":
        if (day <= 22)
        {
            Console.WriteLine(day + " " + month + " is Virgo");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Libra");
        }
        break;
    case "october":
        if (day <= 22)
        {
            Console.WriteLine(day + " " + month + " is Libra");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Scorpio");
        }
        break;
    case "november":
        if (day <= 21)
        {
            Console.WriteLine(day + " " + month + " is Scorpio");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Sagittarius");
        }
        break;
    case "december":
        if (day <= 21)
        {
            Console.WriteLine(day + " " + month + " is Sagittarius");
        }
        else
        {
            Console.WriteLine(day + " " + month + " is Capricorn");
        }
        break;
    default:
        Console.WriteLine("Invalid month entered.");
        return;
}