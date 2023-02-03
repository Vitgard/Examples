// See https://aka.ms/new-console-template for more information
Console.Clear();

int num = new Random().Next(100, 1000);

Console.WriteLine($"Рандомное число {num}");
Console.WriteLine($"Получилось число {num / 100 * 10 + num % 10}");



