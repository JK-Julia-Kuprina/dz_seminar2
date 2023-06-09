﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

void FindSums(int[] array)
{
    int sumP = 0;
    int sumN = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sumP += array[i];
        else
            sumN += array[i];
    System.Console.WriteLine($"Сумма отрицательных элементов массива равна {sumN}");
    System.Console.WriteLine($"Сумма положительных элементов массива равна {sumP}");
}

int[] FindSums2(int[] array)
{
    int sumP = 0;
    int sumN = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sumP += array[i];
        else
            sumN += array[i];
    int[] result = { sumN, sumP };
    return result;
}


Console.Clear();
int[] array = new int[12];
FillArray(array);
PrintArray(array);
FindSums(array);
int[] result = FindSums2(array);
System.Console.WriteLine($"Сумма отрицательных элементов массива равна {result[0]}");
System.Console.WriteLine($"Сумма положительных элементов массива равна {result[1]}");
