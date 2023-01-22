// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;

Write("Введите несколько чисел через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = ConvertStringNum(parameters);
int result = PositiveNumbers(array);
WriteLine($"[{String.Join(",", array)}]");
WriteLine($"В этом списке количество положительных чисел равно {result}");

int[] ConvertStringNum(string[] inArray)
{
    int[] resultArray = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        resultArray[i] = int.Parse(inArray[i]);
    }
    return resultArray;
}

int PositiveNumbers(int[] inArray)
{
    int count = 0;
    foreach (int item in inArray)
    {
        if (item > 0)
            count++;
    }
    return count;
}
