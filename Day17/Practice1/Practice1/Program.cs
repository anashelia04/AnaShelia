using Practice1;

Console.WriteLine("Search Country - 1");
Console.WriteLine("Search City - 2");
string userInput = Console.ReadLine();
try
{
    if (userInput == "1")
    {
        Console.WriteLine("Enter the name of the country:");
        string countryName = Console.ReadLine();
        SearchCountry(countryName);
    }
    else if (userInput == "2")
    {
        Console.WriteLine("Enter the name of the city:");
        string cityName = Console.ReadLine();
        SearchCity(cityName);
    }
    else
    {
        throw new Exception("Invalid input. Please type 1 or 2.");
        Console.WriteLine("Invalid input. Please type 1 or 2.");
    }
}
catch (Exception ex)
{
    LogError(ex.Message);
}





static void LogError(string message)
{
    try
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        string logFilePath = Path.Combine(desktopPath, "Logs.txt");

        using (StreamWriter sw = new StreamWriter(logFilePath, true))
        {
            sw.WriteLine($"{message}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Failed to write to log file: {ex.Message}");
    }
}

static void SearchCity(string city)
{
    List<City> cities = ReadCitiesFromFile();
    City cityInList = null;
    try
    {
        foreach (var item in cities)
        {
            if (string.Equals(item.Name, city, StringComparison.OrdinalIgnoreCase))
            {
                cityInList = item;
            }
        }
        if (cityInList != null)
        {

            Console.WriteLine(cityInList.ToString());
        } else
        {
            throw new Exception("No information on this country");
        }
    }
    catch (Exception ex)
    {
        LogError(ex.Message);
    }
}

static void SearchCountry(string country)
{
    List<Country> countries = ReadCountriesFromFile();
    Country countryInList = null;
    foreach (var item in countries)
    {
        if (string.Equals(item.Name, country, StringComparison.OrdinalIgnoreCase))
        {
            countryInList = item;
        }
    }
    if (countryInList != null)
    {
        Console.WriteLine(countryInList.ToString());
    }
}

static List<City> ReadCitiesFromFile()
{
    List<City> cities = new List<City>();
    List<Country> countries = new List<Country>();
    string filepath = @"D:\TBC\cities.txt";

    string[] lines = File.ReadAllLines(filepath);
    foreach (var line in lines)
    {
        if (string.IsNullOrEmpty(line))
        {
            continue;
        }
        string[] strings = line.Split('|');
        City city = new City(strings[0], double.Parse(strings[1].Replace(',', '.')), Convert.ToInt32(strings[2]), Convert.ToBoolean(strings[3]), strings[4]);
        cities.Add(city);
        string countryName = city.CountryName;
        if (!CountryIsInTheList(countries, countryName))
        {
            List<City> countryCities = new List<City>
                {
                    city
                };

            countries.Add(new Country(countryName, countryCities));
        }
        else
        {
            Country country = countries.Find(x => x.Name == countryName);
            country.Cities.Add(city);

        }

    }
    return cities;
}

static List<Country> ReadCountriesFromFile()
{
    List<City> cities = new List<City>();
    List<Country> countries = new List<Country>();
    string filepath = @"D:\TBC\Cities.txt";

    string[] lines = File.ReadAllLines(filepath);
    foreach (var line in lines)
    {
        if (string.IsNullOrEmpty(line))
        {
            continue;
        }
        string[] strings = line.Split('|');
        City city = new City(strings[0], double.Parse(strings[1].Replace(',', '.')), Convert.ToInt32(strings[2]), Convert.ToBoolean(strings[3]), strings[4]);
        cities.Add(city);
        string countryName = city.CountryName;
        if (!CountryIsInTheList(countries, countryName))
        {
            List<City> countryCities = new List<City>
                {
                    city
                };

            countries.Add(new Country(countryName, countryCities));
        }
        else
        {
            Country country = countries.Find(x => x.Name == countryName);
            country.Cities.Add(city);

        }

    }

    return countries;
}



static bool CountryIsInTheList(List<Country> countries, string countryName)
{
    foreach (Country country in countries)
    {
        if (string.Equals(countryName, country.Name, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
    }
    return false;
}

static List<City> CityInCountry(List<City> cities, string countryName)
{
    List<City> citiesInCountry = new List<City>();
    foreach (var city in citiesInCountry)
    {
        if (string.Equals(city.CountryName, countryName, StringComparison.OrdinalIgnoreCase))
        {
            citiesInCountry.Add(city);
        }
    }
    return citiesInCountry;
}
