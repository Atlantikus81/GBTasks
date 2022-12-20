using static System.Console;

WriteLine("Введите любое число: ");
int a = int.Parse(ReadLine()!);

if (a%2==0) WriteLine ($"Число {a} является чётным");
else
{
   WriteLine ($"Число {a} НЕ является чётным");
}
