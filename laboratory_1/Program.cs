using System;

class Program
{
    // Точка входа: диалог с пользователем
    static void Main()
    {
        Console.WriteLine("Choose number of tasks: ");
        string command = Console.ReadLine();

        while (command != "e" && command != "exit") //выход
        {
            if (command == "1") //1 задание
                SolveTask1();
            else if (command == "2") //2 задание
                SolveTask2();
            else if (command == "3") //3 задание
                SolveTask3();
            else
                Console.WriteLine("Incorrect input");

            Console.WriteLine("Choose number of tasks: "); //ввод команды
            command = Console.ReadLine();
        }

        Console.WriteLine("The End!!!");
    }

    static void Init(out double number) //инициализация одного числа
    {
        Console.Write("Enter number: ");
        number = double.Parse(Console.ReadLine());
    }

    static void Init(out double first, out double second)//инициализация двух чисел
    {
        Console.Write("Enter first number: ");
        first = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        second = double.Parse(Console.ReadLine());
    }

    // Задача 1
    static void SolveTask1()
    {
        double m, n, x;

        // m + --n
        Init(out m, out n);
        double result = m + (--n);
        Console.WriteLine($"m = {m} n = {n} m + --n = {result}");

        // m++ < --n
        Init(out m, out n);
        bool isLess = m++ < --n;
        Console.WriteLine($"m = {m} n = {n} m++ < --n = {isLess}");

        // --m > n--
        Init(out m, out n);
        bool isGreater = --m > n--;
        Console.WriteLine($"m = {m} n = {n} --m > n-- = {isGreater}");
        //(x^3+x^4)^0.2 + ctg(arctg(x^2))
        Init(out x);
        if (x != 0)
        {
            double baseVal = Math.Pow(x, 3) + Math.Pow(x, 4);
            double root = baseVal >= 0 ? Math.Pow(baseVal, 1.0 / 5.0) : -Math.Pow(-baseVal, 1.0 / 5.0);
            double resultX = root + 1.0 / (x * x); // ctg(arctg(x²)) = 1/x²
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"(x^3+x^4)^0.2 + ctg(arctg(x^2)) = {resultX}");
        }
        else
        {
            Console.WriteLine("Division by zero");
        }
    }

    // Задача 2
    static void SolveTask2()
    {
        double x1, y1;
        Init(out x1, out y1);
        bool isCircle = (x1 * x1 + y1 * y1) <= 4;//окружность
        bool isSquare = Math.Abs(x1) + Math.Abs(y1) > 2;//квадрат
        Console.WriteLine($"Point ({x1}, {y1}) belongs: {isCircle && isSquare}");
    }

    // Задача 3
    static void SolveTask3()
    {
        Console.Write("Choose type (double/float): ");
        string dataType = Console.ReadLine();

        if (dataType == "double" || dataType == "Double")
        {
            double a = 1000.0, b = 0.0001;
            double res1 = Math.Pow(a - b, 3);
            double res2 = res1 - Math.Pow(a, 3);
            double res3 = -Math.Pow(b, 3);
            double res4 = res3 - 3 * a * Math.Pow(b, 2);
            double res5 = res4 - 3 * Math.Pow(a, 2) * b;
            double result = res2 / res5;

            Console.WriteLine($"a = {a:F15}, b = {b:F15}");
            Console.WriteLine($"(a-b)^3 = {res1:F15}");
            Console.WriteLine($"(a-b)^3 - (a^3) = {res2:F15}");
            Console.WriteLine($"-b^3 = {res3:F15}");
            Console.WriteLine($"-b^3 + 3ab^2 = {res4:F15}");
            Console.WriteLine($"-b^3 + 3ab^2 - 3a^2b = {res5:F15}");
            Console.WriteLine($"Result = {result:F15}");
        }
        else if (dataType == "float" || dataType == "Float")
        {
            float a = 1000.0f, b = 0.0001f;
            float res1 = (float)Math.Pow(a - b, 3);
            float res2 = res1 - (float)Math.Pow(a, 3);
            float res3 = -(float)Math.Pow(b, 3);
            float res4 = res3 - 3 * a * (float)Math.Pow(b, 2);
            float res5 = res4 - 3 * (float)Math.Pow(a, 2) * b;
            float result = res2 / res5;

            Console.WriteLine($"a = {a:F10}, b = {b:F10}");
            Console.WriteLine($"(a-b)^3 = {res1:F10}");
            Console.WriteLine($"(a-b)^3 - (a^3) = {res2:F10}");
            Console.WriteLine($"-b^3 = {res3:F10}");
            Console.WriteLine($"-b^3 + 3ab^2 = {res4:F10}");
            Console.WriteLine($"-b^3 + 3ab^2 - 3a^2b = {res5:F10}");
            Console.WriteLine($"Result = {result:F10}");
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}