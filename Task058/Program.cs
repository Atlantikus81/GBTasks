// Задача 58:
// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;

Write("Введите размер первой матрицы и диапазон значений через пробел: ");
string[] parameters1 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] table1 = GetMatrixArray
(int.Parse(parameters1[0]), int.Parse(parameters1[1]),
int.Parse(parameters1[2]), int.Parse(parameters1[3]));

Write("Введите размер второй матрицы и диапазон значений через пробел: ");
string[] parameters2 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] table2 = GetMatrixArray
(int.Parse(parameters2[0]), int.Parse(parameters2[1]),
int.Parse(parameters2[2]), int.Parse(parameters2[3]));

WriteLine("--------------------");
PrintMatrixArray(table1);
WriteLine("--------------------");
PrintMatrixArray(table2);
WriteLine("--------------------");

if (table1.GetLength(1) != table2.GetLength(0))
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine("Матрицы нельзя перемножить!");
}
else
{
    ForegroundColor = ConsoleColor.Green;
    PrintMatrixArray(MatrixMultiplication(table1, table2));
}

int[,] MatrixMultiplication(int[,] inMatrix1, int[,] inMatrix2)
{
    int[,] resultMatrix = new int[inMatrix1.GetLength(0), inMatrix2.GetLength(1)];
    for (int i = 0; i < inMatrix1.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix2.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix2.GetLength(0); k++)
            {
                resultMatrix[i, j] += inMatrix1[i, k] * inMatrix2[k, j];
            }
        }
    }
    return resultMatrix;
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
