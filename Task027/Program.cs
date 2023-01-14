// Задача 27:
// Напишите программу, реализующую метод,
// который принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;

Write("Введите любое целое число: ");
int a = int.Parse(ReadLine()!);

int sum = SumNumbers (a);

WriteLine ($"Сумма цифр числа {a} равна: {sum}");

int SumNumbers (int A)
{
    int result = 0;
    int A1 = 0;
    while (A > 0)
    {
        A1 = A%10;
        result = result + A1;
        A = A / 10;
    }
    return result;
}