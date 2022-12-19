using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine()!);
WriteLine("Введите третье число: ");
int c = int.Parse(ReadLine()!);

int max = a;

if (b>max) max=b;
if (c>max) max=c;

WriteLine ($"Число {max} является максимальным");

//int b = Convert ToInt32(ReadLine())
