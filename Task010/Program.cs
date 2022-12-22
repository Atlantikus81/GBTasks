// Программа вывода второй цифры трёхзначного числа

using static System.Console;

int number = new Random().Next(100,1000);
WriteLine(number);

WriteLine($"Вторая цифра этого числа: {number/10%10}");

// WriteLine("Введите любое трёхзначное число: ");
// int a = int.Parse(ReadLine()!);

// if (a>99&&a<1000)
// {
//     Write($"Вторая цифра этого числа: {a=a/10%10}");
// }
// else
// {
//    Write("Введено некорректное число");
// }