// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();

int num = new Random().Next(100, 1000);

Console.WriteLine($"Рандомное число {num}");
Console.WriteLine($"Получилось число {num / 100 * 10 + num % 10}");



