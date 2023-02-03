// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = number1 % 10;
if (number1 >= 100 && number1 < 1000)
    Console.WriteLine($"Третья цифра введенного числа {number2}");
else
    Console.WriteLine("Третьей цифры нет");




