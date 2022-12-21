// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int n = Convert.ToInt32(Console.ReadLine());

int Exp(int X, int N) // Метод возведения числа в степень
{
int result = 1;
for (int i = 1; i <= N; i++) result *= x;
return result;
}

Console.WriteLine(Exp(x,n));