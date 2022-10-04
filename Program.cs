// Напишите программу, которая на вход принимает трехзначное число и 
// на выходе показывает вторую цифру этого числа

Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine()!);
int a12 = num / 10;
int a2 = a12 % 10;
Console.WriteLine($"{num} -> {a2}");
