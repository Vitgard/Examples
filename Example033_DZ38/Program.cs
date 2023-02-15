//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine()); // Задаём размер массива
int [] massive  = new int[n];      // Создаём массив
Random rnd = new Random();      // Создание объекта для генерации чисел
for (int i = 0; i < n; i++)
    { massive[i] = rnd.Next(-50, 50);  // Заполнение рандомами
    Console.Write($" {massive[i]} ");
}
int min = 0;
int max = 0;
foreach (int i in massive)  // Поиск максимального и минимального значения
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между ними: {max-min}");
