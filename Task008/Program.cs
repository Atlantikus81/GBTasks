using static System.Console;

WriteLine("Введите любое положительное число: ");
int N = int.Parse(ReadLine()!);
int a = 1;

while (a<=N)
{
    if (a%2==0)
    {
        Write($"{a} ");
        a=a+1;
    }
    else a=a+1;
}