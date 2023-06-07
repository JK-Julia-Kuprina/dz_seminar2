// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 100);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item }");
    System.Console.WriteLine();
    }
}
int SumOddNumber(int[] array)
{
    int Odd = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        Odd = Odd + array[i];
    }
    return Odd;
}



System.Console.WriteLine("Введите размерность массива ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
FillArray(array);
PrintArray(array);
SumOddNumber(array);
Console.WriteLine(SumOddNumber(array));