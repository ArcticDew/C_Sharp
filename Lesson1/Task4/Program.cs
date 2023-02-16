// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число:");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (max < n2)
{
    max = n2;
}
else if (max < n3)
{
    max = n3;
}
Console.WriteLine($"Максимальным числом является {max}");
Console.WriteLine();