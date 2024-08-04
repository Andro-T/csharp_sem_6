using System;

class Program
{
    static void Main(string[] args)
    {
        // Пример значений m и n
        int m = 3;
        int n = 2;

        // Вычисление функции Аккермана
        int result = Ackermann(m, n);

        // Вывод результата
        Console.WriteLine($"A({m}, {n}) = {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}