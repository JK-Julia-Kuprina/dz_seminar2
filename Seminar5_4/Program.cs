// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int[] NewArray(int[] array)
{
    int[] result = new int[array.Length / 2 + array.Length % 2];
    int j = array.Length - 1;

    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[j - i];

    }
    if (array.Length % 2 != 0) 
        result[^1] = array[array.Length / 2];
    return result;
}

Console.Clear();
int[] array = new int[7];
FillArray(array);
PrintArray(array);
PrintArray(NewArray(array));
