// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите любое положительное число:");
int N = Convert.ToInt32(Console.ReadLine());
int k = 1;
while (k < N+1)
{
    if (k % 2 == 0)
    {
        Console.Write($"{k} ");
    }
    k++;
}
Console.WriteLine("");