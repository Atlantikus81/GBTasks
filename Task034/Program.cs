// Задача 34:
// Напишите программу, реализующую методы формирования массива,
// заполненного случайными положительными трёхзначными числами,
// и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;

int [] arr = GetArray(7, 100, 999);

PrintArray(arr);
WriteLine();
EvenNumbers(arr);

void EvenNumbers(int [] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        int num = inArray[i];
        if (num%2 == 0)
        count ++;
    }
    Write($"Количество чётных чисел в массиве: {count}");
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

void PrintArray(int [] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}
