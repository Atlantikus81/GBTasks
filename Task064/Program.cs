// Задача 64:
// Напишите программу, которая реализует рекурсивный метод вывода
// всех натуральных числел в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;

Write("Введите начальное число: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите конечное число меньшее, чем начальное!: ");
int number2 = int.Parse(ReadLine()!);

WriteLine("---------------------------------");
ForegroundColor = ConsoleColor.Green;
PrintNumbers(number2, number1);
ResetColor();

void PrintNumbers(int end, int start)
{
    if (end == start) Write(end);
    else
    {
        PrintNumbers((end + 1), start);
        Write($", {end}");
    }
}
