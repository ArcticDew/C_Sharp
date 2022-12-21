﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int N) // Метод нахождения суммы цифр заданного числа
{
    int sum = 0;
    while (N > 0)
    {
        sum += N % 10;
        N=N/10;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(num));