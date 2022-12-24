// Программа вывода третьей цифры заданного числа

using static System.Console;

WriteLine("Введите любое число: ");
int a = int.Parse(ReadLine()!);

if (a<100)
{
    WriteLine("Третьей цифры нет");
    return;
}
if (a>99&&a<999)
{
    WriteLine($"{a%10}");
    return;
}
    while (a>999)
    {
        a=a/10;
    }
    WriteLine($"{a%10}");
