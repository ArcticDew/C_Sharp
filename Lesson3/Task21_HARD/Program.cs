// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве.
// Сначала задается N с клавиатуры, потом задаются координаты точек.

try
{
    void FillPoint(int[] array)                                             // Метод заполнения массива координатами точек
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    Console.Write("Введите размерность пространства: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] p1 = new int [N];
    int[] p2 = new int [N];

    Console.WriteLine("Введите координаты первой точки:");
    FillPoint(p1);

    Console.WriteLine("Введите координаты второй точки:");
    FillPoint(p2);

    int sum = 0;
    for (int i = 0; i < N; i++)
    {
        sum = sum + (int)Math.Pow((p2[i] - p1[i]), 2);
    }
    double result = Math.Sqrt(sum);
    Console.WriteLine($"Расстояние между точками = {result}");
}
catch (System.Exception)
{
    Console.WriteLine("Введены некорректные данные. Попробуйте снова");
}