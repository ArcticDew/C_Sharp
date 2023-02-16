// // double d = double.MinValue;
// // double c = double.MaxValue;
// // System.Console.WriteLine(d);
// // System.Console.WriteLine(c);

// int BitDepth(double number)                                            // Метод определения разрядности числа
// {
//     int count = (int)Math.Log10(number) + 1;
//     return count;
// }

// int Exp(int x, int n)                                                  // Метод возведения числа в степень
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= x;
//     return result;
// }

// // Console.WriteLine("Введите число: ");
// // double num = Convert.ToDouble(Console.ReadLine());



// Console.WriteLine("Введите число: ");
// double num = Convert.ToDouble(Console.ReadLine());
// // System.Console.WriteLine(BitDepth((num - (int)num)*Exp(10,15)));
// for (int i = 15; i > 0; i--)
// {
//     int result = (int)(num*Exp(10, i)%10);
//     if (result == 0) Console.WriteLine($"При i = {i} остаток от деления равен {result}");
//     else Console.WriteLine($"При i = {i} остаток от деления равен {result}");
// }
var n = 196.12345;
var count = 0;
while (n != (long)n)
{
    n *= 10;
    count++;
}
Console.WriteLine($"{count} {n}");