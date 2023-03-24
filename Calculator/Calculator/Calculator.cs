namespace Calculator;

public class Calculatoring
{
    public void Work()
    {
        bool isOpen = true;

        while (isOpen)
        {
            Console.WriteLine("Выберите тип калькулятора:");
            Console.WriteLine("1 - обратная польская нотация");
            Console.WriteLine("2 - простой пример по шагам");
            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    PolishNatation();
                    break;
                case "2":
                    ClassicCalculator();
                    break;
                default:
                    isOpen = false;
                    Console.WriteLine("Такой команды нет, выходим");
                    break;
            }
        }
    }

    public double PolishNatation()
    {
        Console.WriteLine("Введите выражение в обратной польской нотации: ");
        string? input = Console.ReadLine();
        Stack<double> stack = new Stack<double>();

        foreach (var token in input?.Split(' ')!)
        {
            if (double.TryParse(token, out double number))
            {
                stack.Push(number);
            }
            else
            {
                double right = stack.Pop();
                double left = stack.Pop();
                
                switch (token)
                {
                    case "+":
                        stack.Push(left + right);
                        break;
                    case "-":
                        stack.Push(left - right);
                        break;
                    case "*":
                        stack.Push(left * right);
                        break;
                    case "/":
                        stack.Push(left / right);
                        break;
                    default:
                        throw new ArgumentException($"Неизвестный оператор {token}");
                }
            }
        }

        return stack.Pop();
    }

    public static double ClassicCalculator()
    {
        Console.WriteLine("Введите первое число:");
        double firstNumber = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите операцию (+,-,*,/):");
        string operation = Console.ReadLine()!;
        Console.WriteLine("Введите второе число:");
        double secondNumber = double.Parse(Console.ReadLine()!);
        switch (operation)
        {
            case "+":
                return firstNumber + secondNumber;
                break;
            case "-":
                return firstNumber - secondNumber;
                break;
            case "*":
                return firstNumber * secondNumber;
                break;
            case "/":
                return firstNumber / secondNumber;
                break;
            default:
                throw new ArgumentException($"Неизвестный оператор {operation}");
        }
    }
}