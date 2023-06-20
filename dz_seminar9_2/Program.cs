// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ShowNumbersSum(int M, int N)
{
    if (M == N) return M;
    else if (M > N) return N + ShowNumbersSum(M, N + 1);
    else return M + ShowNumbersSum(M + 1, N);
} 


Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();

System.Console.WriteLine($"Сумма всех чисел от M до N равна {ShowNumbersSum(M, N)}");

