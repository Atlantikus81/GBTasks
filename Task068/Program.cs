// Задача 68:
// Напишите программу, реализующую метод вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine()!);

WriteLine("-------------------------------");
ForegroundColor = ConsoleColor.Green;
int result = AckermannFunction(number1, number2);
WriteLine($"Результат работы функции Аккермана: {result}");
ResetColor();

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m != 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return AckermannFunction(m, n);
}
