while (true)
{
    Console.WriteLine("enter first number");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("error: invalid number.");
        Console.WriteLine();
        continue;
    }

    Console.WriteLine("enter + to add, - to sub, * to multiply, and / to divide");
    string operation = Console.ReadLine();

    Console.WriteLine("enter second number");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("error: invalid number.");
        Console.WriteLine();
        continue;
    }

    if (operation == "/" && num2 == 0)
    {
        Console.WriteLine("error: division by zero is not allowed.");
        Console.WriteLine();
        continue;
    }

    double result = operation switch
    {
        "+" => num1 + num2,
        "-" => num1 - num2,
        "*" => num1 * num2,
        "/" => num1 / num2,
        _ => double.NaN
    };

    if (double.IsNaN(result))
    {
        Console.WriteLine("error: invalid operation.");
        Console.WriteLine();
        continue;
    }

    Console.WriteLine($"{num1} {operation} {num2} = {result}");

    Console.WriteLine("want more? (yes/no)");
    string continueCalc = Console.ReadLine();
    Console.Clear();
    if (continueCalc == "yes")
    {
        continue;
    }
    else if (continueCalc == "no")
    {
        Console.WriteLine("goodbye");
        break;
    }
    else
    {
        Console.WriteLine("invalid input, goodbye anyway");
        break;
    }
}