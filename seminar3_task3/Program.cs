// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
System.Console.WriteLine($"Введите число N:");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Таблици квадратов чисел от 1 до {n}:");
for (int i = 1; i <= n; i++)
{
    System.Console.Write($"{Math.Pow(i, 2)} ");
}
