using System;

class Program
{
    static void Main(string[] args)
    {
        int M = 1; // Начальное значение
        int N = 10; // Конечное значение

        PrintNumbers(M, N);
    }

    static void PrintNumbers(int M, int N)
    {
        // Базовый случай: если M > N, завершить выполнение
        if (M > N)
        {
            return;
        }

        // Выводим текущее значение M
        Console.WriteLine(M);

        // Рекурсивный вызов функции с увеличенным M
        PrintNumbers(M + 1, N);
    }
}