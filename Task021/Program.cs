// Программа по нахождению расстояния между двумя точками

using static System.Console;

Write("Введите координату X первой точки: ");
int x1 = int.Parse(ReadLine()!);

Write("Введите координату Y первой точки: ");
int y1 = int.Parse(ReadLine()!);

Write("Введите координату Z первой точки: ");
int z1 = int.Parse(ReadLine()!);

Write("Введите координату X второй точки: ");
int x2 = int.Parse(ReadLine()!);

Write("Введите координату Y второй точки: ");
int y2 = int.Parse(ReadLine()!);

Write("Введите координату Z второй точки: ");
int z2 = int.Parse(ReadLine()!);

double hypotenuse1 = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2));
double hypotenuse2 = Math.Sqrt(Math.Pow(hypotenuse1,2) + Math.Pow((z1-z2),2));

Write($"Расстояние между точками: {hypotenuse2}");
