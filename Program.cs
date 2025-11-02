using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Оберіть завдання (1–7): ");
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

    // 🧩 Завдання 1
    static void Task1()
    {
        double[] A = new double[5];
        double[,] B = new double[3, 4];
        Random rnd = new Random();

        // Введення масиву A
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = ");
            A[i] = double.Parse(Console.ReadLine());
        }

        // Заповнення масиву B випадковими числами
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
                B[i, j] = Math.Round(rnd.NextDouble() * 20 - 10, 2); // від -10 до 10

        Console.WriteLine("\nМасив A:");
        Console.WriteLine(string.Join(" ", A));

        Console.WriteLine("\nМасив B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write($"{B[i, j],6}");
            Console.WriteLine();
        }

        double max = Math.Max(A.Max(), B.Cast<double>().Max());
        double min = Math.Min(A.Min(), B.Cast<double>().Min());
        double sum = A.Sum() + B.Cast<double>().Sum();
        double product = A.Aggregate(1.0, (acc, x) => acc * x) * B.Cast<double>().Aggregate(1.0, (acc, x) => acc * x);
        double evenSumA = A.Where(x => x % 2 == 0).Sum();
        double oddColumnsSumB = 0;

        for (int j = 0; j < 4; j++)
            if (j % 2 != 0)
                for (int i = 0; i < 3; i++)
                    oddColumnsSumB += B[i, j];

        Console.WriteLine($"\nМаксимальний: {max}");
        Console.WriteLine($"Мінімальний: {min}");
        Console.WriteLine($"Сума елементів: {sum}");
        Console.WriteLine($"Добуток елементів: {product}");
        Console.WriteLine($"Сума парних елементів A: {evenSumA}");
        Console.WriteLine($"Сума непарних стовпців B: {oddColumnsSumB}");
    }

    // 🧩 Завдання 2
    static void Task2()
    {
        int[,] arr = new int[5, 5];
        Random rnd = new Random();

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                arr[i, j] = rnd.Next(-100, 101);

        Console.WriteLine("Матриця
