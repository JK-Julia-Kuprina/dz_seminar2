// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}   ");
        System.Console.WriteLine();
    }
}

Console.Clear();
System.Console.WriteLine("Введите размер матрицы 1");
int rows1 = Convert.ToInt32(Console.ReadLine());
int cols1 = rows1;
int[,] array = new int[rows1, cols1];
System.Console.WriteLine("Введите размер матрицы 2");
int rows2 = Convert.ToInt32(Console.ReadLine());
int cols2 = rows2;
int[,] arr = new int[rows2, cols2];

FillArray(array);
FillArray(arr);
PrintArray(array);
System.Console.WriteLine();
PrintArray(arr);


int[,] Matrix1 = array;
int[,] Matrix2 = array;


int[,] result = new int[rows1, cols2];
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        int sum = 0;
        for (int k = 0; k < cols1; k++)
        {
            sum += Matrix1[i, k] * Matrix2[k, j];
        }
        result[i, j] = sum;
    }
}

System.Console.WriteLine("Произведение Матриц:");

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        System.Console.Write($"{result[i, j],3}   ");
    }
    System.Console.WriteLine();
}

// System.Console.WriteLine("Введите количество строк для 1-й матрицы ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов(обязательно равное количеству строк) ");
// int cols1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество строк для 2-й матрицы ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов(обязательно равное количеству строк) ");
// int cols2 = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows1, cols1];
// int[,] arr = new int[rows2, cols2];
// FillArray(array);
// PrintArray(array);
// int rows1 = Matrix1.GetLength(0);
// int cols1 = Matrix1.GetLength(1);
// int rows2 = Matrix2.GetLength(0);
// int cols2 = Matrix2.GetLength(1);


