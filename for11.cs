using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N (> 0): ");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Число должно быть больше 0.");
            return;
        }

        // Вычисление суммы
        int sum = (3 * N * (N + 1)) / 2;

        Console.WriteLine($"Сумма от {N} до {2 * N} равна: {sum}");
    }
}