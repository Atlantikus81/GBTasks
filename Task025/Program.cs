// Программа по возведению одного числа в степень другого

using static System.Console;

Write ("Введите число A: ");
int A = int.Parse(ReadLine()!);

Write ("Введите число B: ");
int B = int.Parse(ReadLine()!);

int exp = EXP (A, B);

WriteLine ($"Значение числа {A} в степени {B} равно: {exp}");

int EXP (int a, int b)
{
    int result = a;
    int n = 1;
    while (n < b)
    {
        result = result * a;
        n++;
    }
    return result;
}
