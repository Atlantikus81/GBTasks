using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine()!);

if (a>b) WriteLine ($"Число {a} больше, чем число {b}");
else
{
   WriteLine ($"Число {b} больше, чем число {a}");
}
//int b = Convert ToInt32(ReadLine())

