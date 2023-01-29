// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;

Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] table = GetMatrixArray
(int.Parse(parameters[0]), int.Parse(parameters[1]),
int.Parse(parameters[2]), int.Parse(parameters[3]));

if (int.Parse(parameters[0]) == int.Parse(parameters[1]))
    WriteLine("Полученная матрица будет квадратной");

PrintMatrixArray(table);
WriteLine("---------------------------");
ForegroundColor = ConsoleColor.Green;
// int minSumIdex = RowMinSumElements(table);
WriteLine($"Номер строки с минимальной суммой элементов: {RowMinSumElements(table)}");

int RowMinSumElements(int[,] inArray)
{
    int minSumIndex = 0;
    int[] rowSumElements = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            rowSumElements[i] += inArray[i, j];
        }
        WriteLine($"{rowSumElements[i],3}   [{i + 1}]");
    }
    int minSumRow = rowSumElements[0];

    for (int i = 1; i < rowSumElements.Length; i++)
    {
        if (minSumRow > rowSumElements[i])
        {
            minSumRow = rowSumElements[i];
            minSumIndex = i + 1;
        }
    }
    return minSumIndex;
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
