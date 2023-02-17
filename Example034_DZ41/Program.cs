//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Clear();

Console.WriteLine("Какое количество цифр вы хотите ввести?");
int m = int.Parse(Console.ReadLine()!);
int count = 0;

for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите число ");
    int number = int.Parse(Console.ReadLine()!);
    if (number > 0)
    count++;
}

Console.WriteLine($"Количество чисел больше 0: {count}");
