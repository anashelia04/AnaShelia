using Practice1;
using System.Reflection;

Type calculatorType = typeof(Calculator);
object calculatorInstance = Activator.CreateInstance(calculatorType);

Console.WriteLine("Methods available in the Calculator:");

MethodInfo[] methods = calculatorType.GetMethods();
foreach (var method in methods)
{
    if (method.DeclaringType != typeof(Calculator)) 
        continue;

    ParameterInfo[] parameters = method.GetParameters();
    Console.Write($"- {method.Name}(");

    for (int i = 0; i < parameters.Length; i++)
    {
        Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
        if (i < parameters.Length - 1) Console.Write(", ");
    }
    Console.WriteLine(")");
}

while (true)
{
    Console.WriteLine("\nChoose a method to execute or type 'exit' to quit:");
    string methodName = Console.ReadLine().ToLower(); 

    if (methodName == "exit")
        break;

    MethodInfo selectedMethod = null;

    foreach (var method in methods)
    {
        if (method.Name.ToLower() == methodName && method.DeclaringType == typeof(Calculator))
        {
            selectedMethod = method;
            break;
        }
    }

    if (selectedMethod == null)
    {
        Console.WriteLine("Invalid method name. Please choose a valid method.");
        continue;
    }

    ParameterInfo[] parameters = selectedMethod.GetParameters();
    object[] parameterValues = new object[parameters.Length];

    for (int i = 0; i < parameters.Length; i++)
    {
        Console.WriteLine($"Enter value for {parameters[i].Name} ({parameters[i].ParameterType.Name}):");
        string input = Console.ReadLine();

        try
        {
            object value = Convert.ChangeType(input, parameters[i].ParameterType);
            parameterValues[i] = value;
        }
        catch (Exception)
        {
            Console.WriteLine($"Invalid input for parameter '{parameters[i].Name}'. Expected a value of type {parameters[i].ParameterType.Name}.");
            i--; 
        }
    }



    try
    {
        object result = selectedMethod.Invoke(calculatorInstance, parameterValues);
        Console.WriteLine($"Result: {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}