// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();

//√ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2

Console.Write("Введите X1: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z1: ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите X2: ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y2: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z2: ");
int Z2 = int.Parse(Console.ReadLine()!);

double X = Math.Abs(X2 - X1);
double Y = Math.Abs(Y2 - Y1);
double Z = Math.Abs(Z2 - Z1);

double XX = Math.Pow(X, 2);
double YY = Math.Pow(Y, 2);
double ZZ = Math.Pow(Z, 2);

double result = Math.Sqrt(XX + YY + ZZ);
result = Math.Round(result, 2);
Console.Write(result);







