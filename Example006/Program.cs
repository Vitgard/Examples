// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным
Console.Clear();

Console.Write("Введите число: ");
int even = int.Parse(Console.ReadLine()!);
if (even % 2 != 0)
{
    Console.Write("Данное число нечетное");
}
else
{
    Console.Write("Данное число четное");
}
