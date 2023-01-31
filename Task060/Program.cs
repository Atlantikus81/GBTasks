// Задача 60:
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;

Write("Введите размер трёхмерного массива через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int x = int.Parse(parameters[0]);
int y = int.Parse(parameters[1]);
int z = int.Parse(parameters[2]);
int min = 10;
int max = 99;

WriteLine("---------------------------");

if ((x * y * z) < 91)
{
    int[,,] array = Get3DArray(x, y, z);
    ForegroundColor = ConsoleColor.Green;
    Print3DArray(array);
    ResetColor();
}
else
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine("Размер полученного массива не позволяет вписать в него неповторяющиеся двузначные числа!");
    ResetColor();
}

int[,,] Get3DArray(int rows, int columns, int pages)
{
    int[,,] resultArray = new int[rows, columns, pages];
    int[] uniqueElements = UniqueArrayElements((rows * columns * pages), min, max);
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < pages; k++)
            {
                resultArray[i, j, k] = uniqueElements[index];
                index++;
            }
        }
    }
    return resultArray;
}

void Print3DArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i, j, k],3} ({i},{j},{k})");
            }
            WriteLine();
        }

    }
}

int[] UniqueArrayElements(int size, int minValue, int maxValue)
// Данный метод работает при условии,
// если (maxValue - minValue) < size
{
    Random rnd = new Random();
    int[] resultArray = new int[size];
    int number = 0;
    for (int i = 0; i < size; i++)
    {
        int count = 0;
        while (count != size)
        {
            count = 0;
            number = rnd.Next(minValue, maxValue + 1);
            foreach (int s in resultArray)
                count += s != number ? 1 : 0;
        }
        resultArray[i] = number;
    }
    return resultArray;
}
