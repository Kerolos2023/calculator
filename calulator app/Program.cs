using System;

Console.WriteLine("=== C# Console Calculator ===");

while (true)
{
    double num1 = GetValidNumber("Enter the first number: ");

    Console.WriteLine("Choose an operation: (+, -, *, /)");
    string? op = Console.ReadLine();

    double num2 = GetValidNumber("Enter the second number: ");

    switch (op)
    {
        case "+":
            Console.WriteLine($"\nResult: {num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"\nResult: {num1} - {num2} = {num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"\nResult: {num1} * {num2} = {num1 * num2}");
            break;
        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("\nError: Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine($"\nResult: {num1} / {num2} = {num1 / num2}");
            }
            break;
        default:
            Console.WriteLine("\nInvalid operation selected.");
            break;
    }

    Console.WriteLine("\nWould you like to perform another calculation? (y/n)");
    string? continueApp = Console.ReadLine();
    if (continueApp?.ToLower() != "y")
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    Console.Clear();
}

// Helper method to ensure the application doesn't crash on bad input
static double GetValidNumber(string prompt)
{
    double number;
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();

        if (double.TryParse(input, out number))
        {
            return number;
        }

        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}