using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Оберіть завдання (1-7):");
        int choice = int.Parse(Console.ReadLine() ?? "0");

        switch (choice)
        {
            case 1: Task1(); break;
            case 2: Task2(); break;
            case 3: Task3(); break;
            case 4: Task4(); break;
            case 5: Task5(); break;
            case 6: Task6(); break;
            case 7: Task7(); break;
            default: Console.WriteLine("Невірний вибір."); break;
        }
    }

    // 1
    static void Task1()
    {
        Console.Write("Введіть число від 1 до 100: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number < 1 || number > 100)
            {
                Console.WriteLine("Помилка: число повинно бути від 1 до 100!");
                return;
            }

            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine("Fizz Buzz");
            else if (number % 3 == 0)
                Console.WriteLine("Fizz");
            else if (number % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(number);
        }
        else Console.WriteLine("Помилка: потрібно ввести число!");
    }

    // 2
    static void Task2()
    {
        Console.Write("Введіть число: ");
        double value = double.Parse(Console.ReadLine());
        Console.Write("Введіть відсоток: ");
        double percent = double.Parse(Console.ReadLine());

        double result = value * percent / 100;
        Console.WriteLine($"{percent}% від {value} = {result}");
    }

    // 3
    static void Task3()
    {
        Console.WriteLine("Введіть 4 цифри:");
        string result = "";
        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Цифра {i}: ");
            result += Console.ReadLine();
        }

        Console.WriteLine($"Сформоване число: {result}");
    }

    // 4
    static void Task4()
    {
        Console.Write("Введіть шестизначне число: ");
        string number = Console.ReadLine();

        if (number.Length != 6 || !int.TryParse(number, out _))
        {
            Console.WriteLine("Помилка: потрібно ввести шестизначне число!");
            return;
        }

        Console.Write("Введіть перший розряд для заміни: ");
        int pos1 = int.Parse(Console.ReadLine());
        Console.Write("Введіть другий розряд для заміни: ");
        int pos2 = int.Parse(Console.ReadLine());

        char[] digits = number.ToCharArray();
        (digits[pos1 - 1], digits[pos2 - 1]) = (digits[pos2 - 1], digits[pos1 - 1]);

        Console.WriteLine($"Результат: {new string(digits)}");
    }

    // 5
    static void Task5()
    {
        Console.Write("Введіть дату (дд.мм.рррр): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
        {
            string season = date.Month switch
            {
                12 or 1 or 2 => "Winter",
                3 or 4 or 5 => "Spring",
                6 or 7 or 8 => "Summer",
                9 or 10 or 11 => "Autumn",
                _ => "Unknown"
            };

            Console.WriteLine($"{season} {date.DayOfWeek}");
        }
        else Console.WriteLine("Помилка: некоректна дата!");
    }

    // 6
    static void Task6()
    {
        Console.Write("Введіть температуру: ");
        double temp = double.Parse(Console.ReadLine());
        Console.WriteLine("Оберіть напрямок конвертації:");
        Console.WriteLine("1 - Фаренгейт → Цельсій");
        Console.WriteLine("2 - Цельсій → Фаренгейт");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            double celsius = (temp - 32) * 5 / 9;
            Console.WriteLine($"Результат: {celsius:F2} °C");
        }
        else if (choice == 2)
        {
            double fahrenheit = temp * 9 / 5 + 32;
            Console.WriteLine($"Результат: {fahrenheit:F2} °F");
        }
        else Console.WriteLine("Помилка: неправильний вибір!");
    }

    // 7
    static void Task7()
    {
        Console.Write("Введіть перше число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine($"Парні числа у діапазоні від {a} до {b}:");
        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
