// See https://aka.ms/new-console-template for more information

Console.Write("Enter the first number: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double number2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Choose an operation (+, -, *, /): ");
char operation = Convert.ToChar(Console.ReadLine());

double result = 0;


switch (operation)
{
    case '+':
        result = number1 + number2;
        Console.WriteLine($"The result of addition is: {result}");
        break;
    case '-':
        result = number1 - number2;
        Console.WriteLine($"The result of subtraction is: {result}");
        break;
    case '*':
        result = number1 * number2;
        Console.WriteLine($"The result of multiplication is: {result}");
        break;
    case '/':
        if (number2 != 0)
        {
            result = number1 / number2;
            Console.WriteLine($"The result of division is: {result}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        break;
    default:
        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
        break;
}
