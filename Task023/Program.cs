// Программа вывода кубов от 1 до заданного числа

using static System.Console;

WriteLine ("Введите любое число:");

int N = int.Parse(ReadLine()!);
int a = 1;

WriteLine ($"Список кубов чисел от 1 до {N}:");

while (a<=N)
{
    Write ($"{Math.Pow(a,3)}, ");
    a++;
}
