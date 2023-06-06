/// Задача 10: Напишите программу, которая принимает на вход 
/// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехначное число: ");
int num = int.Parse(Console.ReadLine());
int num100 = (num / 100) * 100;
int num1 = num % 10;

Console.WriteLine("Число " + num + "-> " + (num -num100-num1)/10);