// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

int[] newArray(string[] Array, int n) // Метод преобразования строкового массива в числовой
{
    int[] newArray = new int[n];
    for (int i = 0; i < n; i++)
    {
        newArray[i] = int.Parse(Array[i]);
    }
    return newArray;
}

void PrintArray(int[] Array) // Метод вывода массива на экран в строку с квадратными скобками и запятыми
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == 0) Console.Write($"[");
        Console.Write(Array[i]);
        if (i < Array.Length - 1) Console.Write(",");
        if (i == Array.Length - 1) Console.WriteLine($"]");
    }
}

Console.WriteLine("Введите 8 целых чисел через пробел: ");
string text = Console.ReadLine();
string[] temp = text.Split(' ');
PrintArray(newArray(temp, 8));
