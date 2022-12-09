// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

Console.Write("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit3 = 0;
if (num > 100)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    digit3 = num % 10;
    Console.WriteLine($"Третья цифра слева: {digit3}");
}
else
{
    Console.WriteLine("Третьей цифры здесь нет!");
}
