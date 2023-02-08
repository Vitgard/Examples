// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

Console.Write("Пятизначное число: ");
//int number = new Random() .Next(10000, 100000);
int number = int.Parse(Console.ReadLine()!);
if 
(number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
{
    Console.WriteLine($"{number} палиндром");
}
else
{
    Console.WriteLine($"{number} не палиндром");

}

