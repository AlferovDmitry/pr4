using System;

class Program
{
    static void Main()
    {
        int N, M;

        // Ввод значения N
        Console.WriteLine("Введите начальное целое число N:");
        while (!int.TryParse(Console.ReadLine(), out N))
        {
            Console.WriteLine("Ошибка: введите корректное целое число.");
        }

        // Ввод значения M
        Console.WriteLine("Введите конечное целое число M:");
        while (!int.TryParse(Console.ReadLine(), out M) || M < N)
        {
            Console.WriteLine("Ошибка: введите корректное целое число больше или равное N.");
        }

        // Вычисление суммы
        int sum = CalculateSum(N, M);
        Console.WriteLine($"Сумма от {N} до {M} равна: {sum}");
    }

    static int CalculateSum(int N, int M)
    {
        return (M - N + 1) * (N + M) / 2; // Используем формулу суммы
    }
}


