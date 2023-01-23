// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;

Write("Введите коэффициенты b1, k1, b2, k2 через пробел: ");
string[] coefficients = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] array = ConvertStringNum(coefficients);
PointIntersection(array);

void PointIntersection(double[] inArray)
{
    double b1 = inArray[0];
    double k1 = inArray[1];
    double b2 = inArray[2];
    double k2 = inArray[3];

    if (k1 == k2 && b1 == b2)
    {
        WriteLine("Заданные прямые идентичны");
    }
    else if (k1 == k2)
    {
        WriteLine("Заданные прямые параллельны и не имеют точки пересечения");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        WriteLine($"Координаты точки пересечения: X={x}, Y={y}");
    }
}

double[] ConvertStringNum(string[] inArray)
{
    double[] resultArray = new double[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        resultArray[i] = double.Parse(inArray[i]);
    }
    return resultArray;
}
