try
{
    // Метод определения разрядности числа
    int BitDepth(int number)
    {
        int count = (int)Math.Log10(number) + 1;
        return count;
    }
    // Программа
    Console.Write("Введите целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int result = 0;

    for (int i = 0; i < BitDepth(num) / 2; i++)
    {
        int n1 = num / (int)Math.Pow(10, BitDepth(num) - 1 - i) % 10;   // Первые цифры числа;
        int n2 = num / (int)Math.Pow(10, i) % 10;                       // Последние цифры числа;
        if (n1 == n2)
        {
            result = 1;
            Console.WriteLine($"Цифра {n1} совпадает с {n2}");
        }
        else
        {
            result = 0;
            Console.WriteLine($"Цифра {n1} не совпадает с {n2}");
            break;
        }
    }

    if (result == 1) Console.WriteLine($"Число {num} является палиндромом!");
    else Console.WriteLine($"Число {num} не является палиндромом!");
}
catch (System.Exception)
{
  Console.WriteLine("Введены некорректные данные. Попробуйте снова.");
}