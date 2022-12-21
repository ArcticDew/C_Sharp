// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exp(int x, int n) // Метод возведения числа в степень
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= x;
    return result;
}

Console.Write("Введите целое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {A} в степени {B} равно {Exp(A, B)}");