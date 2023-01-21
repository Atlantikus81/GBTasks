// Задача 38:
// Напишите программу, реализующую методы формирования массива,
// заполненного случайными вещественными числами,
// и вычисления разницы между максимальным и минимальным элементами массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;

Write("Введите размер массива, минимальное и максимальное значения через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] arr = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(arr);
WriteLine();
DiffMinMax(arr);

void DiffMinMax(double[] inArray)
{
    double min = 0;
    double max = 0;
    foreach (double item in inArray)
    {
        if (item < min)
            min = item;
        if (item > max)
            max = item;
    }
    WriteLine($"Минимальное значение: {min}");
    WriteLine($"Максимальное значение: {max}");
    WriteLine($"Разница между минимальным и максимальным значениями: {max - min}");
}

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] resultArray = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = Math.Round(rnd.Next(minValue, maxValue) + rnd.NextDouble(), 3);
    }
    return resultArray;
}

void PrintArray(double[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]} ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}
