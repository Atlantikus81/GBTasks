// Программа определения числа-палиндрома

using static System.Console;

WriteLine("Введите любое пятизначное число:");
int a = int.Parse(ReadLine()!);

int b=a%10;
int c=a/10%10;
int d=a/100%10;
int e=a/1000%10;
int f=a/10000;

if (a<10000||a>99999)
{
    WriteLine ("Введено некорректное число");
    return;
}

if (b==f&&c==e)
{
    WriteLine ($"Число {a} является палиндромом");
}
else
{
   WriteLine ($"Число {a} НЕ является палиндромом");
}
