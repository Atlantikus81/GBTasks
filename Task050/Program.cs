// Задача 50:
// Напишите программу, реализующую метод,
// принимающий позиции элемента в двумерном массиве,
// и возвращающий значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;

Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Write("Введите номер строки искомого элемента: ");
int m = int.Parse(ReadLine()!);
Write("Введите номер столбца искомого элемента: ");
int n = int.Parse(ReadLine()!);

int[,] array = GetMatrixArray
(int.Parse(parameters[0]), int.Parse(parameters[1]),
int.Parse(parameters[2]), int.Parse(parameters[3]));

PrintMatrixArray(array);

if (m <= int.Parse(parameters[0]) && n <= int.Parse(parameters[1]))
{
    int num = Num2DArray(array, m, n);
    WriteLine($"Искомый элемент массива: {num}");
}
else WriteLine("Такого элемента не существует");

int Num2DArray(int[,] inArray, int i, int j)
{
    int result = inArray[i - 1, j - 1];

    return result;
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
