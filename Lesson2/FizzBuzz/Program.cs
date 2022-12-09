// FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100.
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz.
// Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.

int[] array = new int[100];
for (int i = 0; i < array.Length; i++) array[i] = i + 1;
foreach (int a in array)
{
    if (a % 3 == 0 || a % 5 == 0)
    {
        if (a % 15 == 0) Console.Write("FizzBuzz ");
        else if (a % 3 == 0) Console.Write("Fizz ");
        else Console.Write("Buzz ");
    }
    else
    {
        Console.Write($"{a} ");
    }
}