// Задача 52:
// Напишите программу, реализующую методы
// формирования двумерного массива и
// массива средних арифметических значений каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;

Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] table = GetMatrixArray
(int.Parse(parameters[0]), int.Parse(parameters[1]),
int.Parse(parameters[2]), int.Parse(parameters[3]));

PrintMatrixArray(table);
double[] array = AverageColumns(table);
WriteLine($"[{String.Join(",  ", array)}]");

double[] AverageColumns(int[,] inArray)
{
    double[] resultArray = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            resultArray[j] += inArray[i, j];
        }
        resultArray[j] = Math.Round((resultArray[j] / inArray.GetLength(0)), 2);
    }
    return resultArray;
}

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");
        }
        WriteLine();
    }
}
