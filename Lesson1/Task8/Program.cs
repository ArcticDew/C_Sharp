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