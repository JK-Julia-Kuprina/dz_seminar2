﻿// Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 15 элементов. В своём решении сделайте для 15
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int Counter(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    count ++;
}
return count;
}

Console.Clear();
int[] array = new int[15];
FillArray(array);
PrintArray(array);
System.Console.WriteLine(Counter(array));
