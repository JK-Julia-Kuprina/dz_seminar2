// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 31);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}
void SumLineNumber(int[,] array)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = i;
        }
    }
    Console.WriteLine("Строка: " + index + " Сумма - " + sum);
}

Console.Clear();
System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов(обязательно отличное от количества строк) ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
SumLineNumber(array);
    
// Console.WriteLine();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     Console.Write(array[index, i] + " ");
// }