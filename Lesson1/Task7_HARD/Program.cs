// Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4

Console.Write("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int N = 0;
int count = (int)Math.Log10(num);
if (count < 2)
{
    Console.WriteLine($"Такой цифры здесь нет");
}
else
{
    N = num / (int)Math.Pow(10, (count - 2)) % 10;
    Console.WriteLine($"Третье число слева: {N}");
}