// Задача 66:
// Напишите программу, которая реализует
// рекурсивный метод нахождения суммы натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine()!);

WriteLine("-------------------------");
ForegroundColor = ConsoleColor.Green;
int sum = SumNumbers(number2, number1);
WriteLine($"Сумма чисел от {number1} до {number2} равна {sum}");
ResetColor();

int SumNumbers(int start, int end)
{
    int result = start;
    if (start > end)
        if (start == end) return result;
        else
        {
            result += SumNumbers((start - 1), end);
        }
    else if (start == end) return result;
    else
    {
        result += SumNumbers((start + 1), end);
    }
    return result;
}
